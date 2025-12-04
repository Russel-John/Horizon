using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HorizonBookingSystem
{
    public partial class SeatSelectionPage : Form
    {
        private Users userLoggedIn;
        private Flights selectedFlight;
        private int numberOfTickets;
        private decimal totalPrice;
        private BookingDBEntities db = new BookingDBEntities();
        private List<string> selectedSeats = new List<string>();

        private const int ROWS = 5;
        private const int COLS = 6;

        public SeatSelectionPage(Users user, Flights flight, int tickets, decimal price)
        {
            InitializeComponent();
            this.userLoggedIn = user;
            this.selectedFlight = flight;
            this.numberOfTickets = tickets;
            this.totalPrice = price;
        }

        private void SeatSelectionPage_Load(object sender, EventArgs e)
        {
            // Add null checks
            if (selectedFlight == null)
            {
                MessageBox.Show("No flight selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (userLoggedIn == null)
            {
                MessageBox.Show("No user logged in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            LoadFlightInfo();
            LoadSeats();
        }

        private void LoadFlightInfo()
        {
            lblFlightInfo.Text = $"Flight: {selectedFlight.Departure} → {selectedFlight.Destination} | {selectedFlight.FlightDate?.ToString("MM/dd/yyyy")}";
            lblTicketInfo.Text = $"Select {numberOfTickets} seat(s) | Total: {totalPrice:C}";
            lblSelectedSeats.Text = "Selected Seats: None";
        }

        private void LoadSeats()
        {
            // Get seats for this flight from database
            var seats = db.Seats.Where(s => s.FlightID == selectedFlight.FlightID).ToList();

            // If no seats exist, create them
            if (seats.Count == 0)
            {
                CreateSeatsForFlight();
                seats = db.Seats.Where(s => s.FlightID == selectedFlight.FlightID).ToList();
            }

            // Create seat buttons in grid layout
            CreateSeatButtons(seats);
        }

        private void CreateSeatsForFlight()
        {
            // Create seats in format: A1, A2, A3... B1, B2, B3... etc.
            for (int row = 0; row < ROWS; row++)
            {
                char rowLetter = (char)('A' + row);
                for (int col = 1; col <= COLS; col++)
                {
                    var seat = new Seats
                    {
                        FlightID = selectedFlight.FlightID,
                        SeatNumber = $"{rowLetter}{col}",
                        IsBooked = false,
                        BookingID = null
                    };
                    db.Seats.Add(seat);
                }
            }
            db.SaveChanges();
        }

        private void CreateSeatButtons(List<Seats> seats)
        {
            // Clear existing controls
            panelSeats.Controls.Clear();

            // Configure panel for grid layout
            panelSeats.AutoScroll = true;
            panelSeats.BackColor = Color.White;
            panelSeats.BorderStyle = BorderStyle.FixedSingle;

            // Create TableLayoutPanel for grid
            TableLayoutPanel seatGrid = new TableLayoutPanel
            {
                RowCount = ROWS,
                ColumnCount = COLS,
                Dock = DockStyle.Fill,
                Padding = new Padding(20),
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None
            };

            // Set equal column and row sizes
            for (int i = 0; i < COLS; i++)
            {
                seatGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / COLS));
            }
            for (int i = 0; i < ROWS; i++)
            {
                seatGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / ROWS));
            }

            // Create buttons for each seat
            for (int row = 0; row < ROWS; row++)
            {
                char rowLetter = (char)('A' + row);
                for (int col = 1; col <= COLS; col++)
                {
                    string seatNumber = $"{rowLetter}{col}";
                    var seat = seats.FirstOrDefault(s => s.SeatNumber == seatNumber);

                    if (seat == null) continue;

                    Button btnSeat = new Button
                    {
                        Text = seatNumber,
                        Tag = seat,
                        Dock = DockStyle.Fill,
                        Margin = new Padding(5),
                        Font = new Font("Segoe UI", 12, FontStyle.Bold),
                        FlatStyle = FlatStyle.Flat,
                        Cursor = Cursors.Hand
                    };

                    // Set color based on booking status
                    if (seat.IsBooked == true)
                    {
                        // Booked seat - cannot be selected
                        btnSeat.BackColor = Color.Gray;
                        btnSeat.ForeColor = Color.White;
                        btnSeat.Enabled = false;
                        btnSeat.Cursor = Cursors.No;
                    }
                    else
                    {
                        // Available seat
                        btnSeat.BackColor = Color.LightGreen;
                        btnSeat.ForeColor = Color.Black;
                        btnSeat.Enabled = true;
                    }

                    btnSeat.FlatAppearance.BorderSize = 2;
                    btnSeat.FlatAppearance.BorderColor = Color.DarkGray;

                    btnSeat.Click += SeatButton_Click;

                    // Add button to grid at correct position
                    seatGrid.Controls.Add(btnSeat, col - 1, row);
                }
            }

            // Add the grid to the panel
            panelSeats.Controls.Add(seatGrid);
            
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button btnSeat = sender as Button;
            Seats seat = btnSeat.Tag as Seats;

            if (selectedSeats.Contains(seat.SeatNumber))
            {
                // Deselect seat
                selectedSeats.Remove(seat.SeatNumber);
                btnSeat.BackColor = Color.LightGreen;
                btnSeat.ForeColor = Color.Black;
            }
            else if (selectedSeats.Count < numberOfTickets)
            {
                // Select seat
                selectedSeats.Add(seat.SeatNumber);
                btnSeat.BackColor = Color.Blue;
                btnSeat.ForeColor = Color.White;

                if (selectedSeats.Count == numberOfTickets)
                {
                    MessageBox.Show("Maximum seats reached, cannot book more seats.", "Booking Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Max tickets reached
                MessageBox.Show($"You cannot select more than {numberOfTickets} seats.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            UpdateSelectionInfo();
        }

        private void UpdateSelectionInfo()
        {
            if (selectedSeats.Count > 0)
            {
                lblSelectedSeats.Text = $"Selected Seats: {string.Join(" ", selectedSeats.OrderBy(s => s))} ({selectedSeats.Count}/{numberOfTickets})";
            }
            else
            {
                lblSelectedSeats.Text = "Selected Seats: None";
            }
        }

        private void panelSeats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSelectedSeats_Click(object sender, EventArgs e)
        {

        }

        private void lblTicketInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblFlightInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("No seats booked yet.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedSeats.Count != numberOfTickets)
            {
                MessageBox.Show($"Please select exactly {numberOfTickets} seat(s).", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Create booking
                var booking = new Bookings
                {
                    UserID = userLoggedIn.userID,
                    FlightID = selectedFlight.FlightID,
                    NumberOfTickets = numberOfTickets,
                    TotalPrice = totalPrice,
                    BookingDate = DateTime.Now
                };

                db.Bookings.Add(booking);
                db.SaveChanges();

                // Mark seats as booked and create BookingSeats records
                foreach (string seatNumber in selectedSeats)
                {
                    var seat = db.Seats.FirstOrDefault(s => s.FlightID == selectedFlight.FlightID && s.SeatNumber == seatNumber);
                    if (seat != null)
                    {
                        seat.IsBooked = true;
                        seat.BookingID = booking.BookingID;

                        var bookingSeat = new BookingSeats
                        {
                            BookingID = booking.BookingID,
                            SeatID = seat.SeatID
                        };
                        db.BookingSeats.Add(bookingSeat);
                    }
                }

                db.SaveChanges();

                MessageBox.Show($"Booking Confirmed!\n\nBooking ID: {booking.BookingID}\nSeats: {string.Join(" ", selectedSeats.OrderBy(s => s))}\nTotal: {totalPrice:C}\n\nThank you, {userLoggedIn.username}!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel the booking?", "Cancel Booking",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void PanelTitle_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

