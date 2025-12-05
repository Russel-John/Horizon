using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (UserloggedIn != null)
            {
                txtUsername.Text = UserloggedIn.username;
                txtEmail.Text = UserloggedIn.email;
                txtPassword.Text = UserloggedIn.password;
            }

            LoadUserBookings();
        }

        private void LoadUserBookings()
        {
            if (UserloggedIn == null) return;

            try
            {
                var bookingDisplay = db.Bookings
                    .Where(b => b.UserID == UserloggedIn.userID)
                    .ToList()
                    .Select(b => new BookingViewModel
                    {
                        BookingID = b.BookingID,
                        Route = $"{b.Flights.Departure} → {b.Flights.Destination}",
                        FlightDate = b.Flights.FlightDate?.ToString("MM/dd/yyyy") ?? "N/A",
                        FlightTime = b.Flights.FlightTime ?? "N/A",
                        Tickets = b.NumberOfTickets,
                        Seats = GetSeatsForBooking(b.BookingID),
                        TotalPrice = b.TotalPrice?.ToString("C") ?? "N/A",
                        BookedOn = b.BookingDate?.ToString("MM/dd/yyyy HH:mm") ?? "N/A"
                    })
                    .ToList();

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
                .ToList();

            return seats.Any() ? string.Join(", ", seats.OrderBy(s => s)) : "No seats";
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
                    var seats = db.Seats.Where(s => s.BookingID == bookingID).ToList();

                    foreach (var bookingSeat in bookingSeats)
                        db.BookingSeats.Remove(bookingSeat);

                    foreach (var seat in seats)
                    {
                        seat.IsBooked = false;
                        seat.BookingID = null;
                    }

                    db.Bookings.Remove(booking);
                    db.SaveChanges();

                    MessageBox.Show(
                        $"Booking ID {bookingID} has been cancelled successfully!\n\nYour seats have been released.",
                        "Booking Cancelled",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadUserBookings();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error cancelling booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (UserloggedIn == null) return;

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || 
                string.IsNullOrWhiteSpace(txtPassword.Text) || 
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userInDb = db.Users.FirstOrDefault(u => u.userID == UserloggedIn.userID);
            if (userInDb != null)
            {
                userInDb.username = txtUsername.Text.Trim();
                userInDb.email = txtEmail.Text.Trim();
                userInDb.password = txtPassword.Text;

                db.SaveChanges();
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UserloggedIn.username = userInDb.username;
                UserloggedIn.email = userInDb.email;
                UserloggedIn.password = userInDb.password;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
