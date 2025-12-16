using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HorizonBookingSystem
{
    public partial class ProfilePage : Form
    {
        private Users UserloggedIn;
        private BookingDBEntities db = new BookingDBEntities();

        public ProfilePage(Users user)
        {
            InitializeComponent();
            UserloggedIn = user;
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            txtUsername.Text = UserloggedIn.username;
            txtEmail.Text = UserloggedIn.email;
            txtPassword.Text = UserloggedIn.password;
            LoadUserBookings();
        }

        private void LoadUserBookings()
        {
            try
            {
                var bookings = db.Bookings.Where(b => b.UserID == UserloggedIn.userID).ToList();
                
                var bookingDisplay = bookings.Select(b => new BookingViewModel
                {
                    BookingID = b.BookingID,
                    Route = $"{b.Flights.Departure} → {b.Flights.Destination}",
                    FlightDate = b.Flights.FlightDate?.ToString("MM/dd/yyyy") ?? "N/A",
                    FlightTime = b.Flights.FlightTime ?? "N/A",
                    Tickets = b.NumberOfTickets,
                    Seats = GetSeatsForBooking(b.BookingID),
                    TotalPrice = b.TotalPrice?.ToString("C") ?? "N/A",
                    BookedOn = b.BookingDate?.ToString("MM/dd/yyyy HH:mm") ?? "N/A"
                }).ToList();

                bookingViewModelBindingSource.DataSource = bookingDisplay;
                lblBookingInfo.Text = $"You have {bookingDisplay.Count} booking(s). Select a row to cancel.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bookings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSeatsForBooking(int bookingID)
        {
            var seats = db.BookingSeats
                .Where(bs => bs.BookingID == bookingID)
                .Select(bs => bs.Seats.SeatNumber)
                .OrderBy(s => s)
                .ToList();

            if (seats.Count > 0)
                return string.Join(", ", seats);
            else
                return "No seats";
        }

        private void btnRefreshBookings_Click(object sender, EventArgs e)
        {
            LoadUserBookings();
            MessageBox.Show("Bookings refreshed successfully!", "Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to cancel.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedBooking = (BookingViewModel)dgvBookings.SelectedRows[0].DataBoundItem;
            int bookingID = selectedBooking.BookingID;

            var result = MessageBox.Show(
                $"Are you sure you want to cancel Booking ID {bookingID}?\n\nThis action cannot be undone.",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var booking = db.Bookings.FirstOrDefault(b => b.BookingID == bookingID);
                    if (booking == null)
                    {
                        MessageBox.Show("Booking not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var bookingSeats = db.BookingSeats.Where(bs => bs.BookingID == bookingID).ToList();
                    foreach (var bookingSeat in bookingSeats)
                    {
                        db.BookingSeats.Remove(bookingSeat);
                    }

                    var seats = db.Seats.Where(s => s.BookingID == bookingID).ToList();
                    foreach (var seat in seats)
                    {
                        seat.IsBooked = false;
                        seat.BookingID = null;
                    }

                    db.Bookings.Remove(booking);
                    db.SaveChanges();

                    MessageBox.Show("Booking cancelled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserBookings();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error cancelling booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userInDb = db.Users.FirstOrDefault(u => u.userID == UserloggedIn.userID);
            userInDb.username = username;
            userInDb.email = email;
            userInDb.password = password;

            db.SaveChanges();
            
            UserloggedIn.username = username;
            UserloggedIn.email = email;
            UserloggedIn.password = password;
            
            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void tabProfile_Click(object sender, EventArgs e) { }
    }
}
