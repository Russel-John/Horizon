using System;
using System.Collections.Generic;
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
            var seats = db.Seats.Where(s => s.FlightID == selectedFlight.FlightID).ToList();

            if (seats.Count == 0)
            {
                CreateSeatsForFlight();
                seats = db.Seats.Where(s => s.FlightID == selectedFlight.FlightID).ToList();
            }

            CreateSeatButtons(seats);
        }

        private void CreateSeatsForFlight()
        {
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
            panelSeats.Controls.Clear();

            TableLayoutPanel seatGrid = new TableLayoutPanel
            {
                RowCount = ROWS,
                ColumnCount = COLS,
                Dock = DockStyle.Fill,
                Padding = new Padding(20),
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None
            };

            for (int i = 0; i < COLS; i++)
            {
                seatGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / COLS));
            }
            for (int i = 0; i < ROWS; i++)
            {
                seatGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / ROWS));
            }

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

                    if (seat.IsBooked == true)
                    {
                        btnSeat.BackColor = Color.Gray;
                        btnSeat.ForeColor = Color.White;
                        btnSeat.Enabled = false;
                        btnSeat.Cursor = Cursors.No;
                    }
                    else
                    {
                        btnSeat.BackColor = Color.LightGreen;
                        btnSeat.ForeColor = Color.Black;
                        btnSeat.Enabled = true;
                    }

                    btnSeat.FlatAppearance.BorderSize = 2;
                    btnSeat.FlatAppearance.BorderColor = Color.DarkGray;
                    btnSeat.Click += SeatButton_Click;

                    seatGrid.Controls.Add(btnSeat, col - 1, row);
                }
            }

            panelSeats.Controls.Add(seatGrid);
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button btnSeat = sender as Button;
            Seats seat = btnSeat.Tag as Seats;

            if (selectedSeats.Contains(seat.SeatNumber))
            {
                selectedSeats.Remove(seat.SeatNumber);
                btnSeat.BackColor = Color.LightGreen;
                btnSeat.ForeColor = Color.Black;
            }
            else if (selectedSeats.Count < numberOfTickets)
            {
                selectedSeats.Add(seat.SeatNumber);
                btnSeat.BackColor = Color.Blue;
                btnSeat.ForeColor = Color.White;
            }
            else
            {
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

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count != numberOfTickets)
            {
                MessageBox.Show($"Please select exactly {numberOfTickets} seat(s).", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
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

                foreach (string seatNumber in selectedSeats)
                {
                    var seat = db.Seats.FirstOrDefault(s => s.FlightID == selectedFlight.FlightID && s.SeatNumber == seatNumber);
                    seat.IsBooked = true;
                    seat.BookingID = booking.BookingID;

                    var bookingSeat = new BookingSeats
                    {
                        BookingID = booking.BookingID,
                        SeatID = seat.SeatID
                    };
                    db.BookingSeats.Add(bookingSeat);
                }

                db.SaveChanges();

                MessageBox.Show($"Booking Confirmed!\n\nBooking ID: {booking.BookingID}\nSeats: {string.Join(" ", selectedSeats.OrderBy(s => s))}\nTotal: {totalPrice:C}",
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
            var result = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panelSeats_Paint(object sender, PaintEventArgs e) { }
        private void lblSelectedSeats_Click(object sender, EventArgs e) { }
        private void lblTicketInfo_Click(object sender, EventArgs e) { }
        private void lblFlightInfo_Click(object sender, EventArgs e) { }
        private void PanelTitle_Paint(object sender, PaintEventArgs e) { }
    }
}

