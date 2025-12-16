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
    public partial class BookingPage : Form
    {
        private Users userLoggedIn;
        private Flights selectedFlight;

        // Constructor to accept flight details
        public BookingPage(Users user, Flights flight)
        {
            InitializeComponent();
            this.userLoggedIn = user;
            this.selectedFlight = flight;
            
            LoadFlightDetails();
        }

        private void LoadFlightDetails()
        {
            if (selectedFlight != null)
            {
                // Directly set flight details to labels
                LblDeparture.Text = $"Departure: {selectedFlight.Departure ?? "N/A"}";
                LblDestination.Text = $"Destination: {selectedFlight.Destination ?? "N/A"}";
                LblFlight.Text = $"Flight Date: {selectedFlight.FlightDate?.ToString("MM/dd/yyyy") ?? "N/A"}";
                LblTime.Text = $"Time: {selectedFlight.FlightTime ?? "N/A"}";
                LblPrice.Text = $"Price: {selectedFlight.Price?.ToString("C") ?? "N/A"}";
            }

            if (userLoggedIn != null)
            {
                LblUsername.Text = $"User: {userLoggedIn.username}";
            }

            CalculateAndDisplayTotalPrice();
        }

        private void LblDestination_Click(object sender, EventArgs e)
        {

        }

        private void LblUsername_Click(object sender, EventArgs e)
        {

        }

        private void LblDeparture_Click(object sender, EventArgs e)
        {

        }

        private void LblPrice_Click(object sender, EventArgs e)
        {

        }

        private void LblTime_Click(object sender, EventArgs e)
        {

        }

        private void LblFlight_Click(object sender, EventArgs e)
        {

        }

        private void LblTicket_Click(object sender, EventArgs e)
        {

        }

        private void LblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void numTickets_ValueChanged(object sender, EventArgs e)
        {
            CalculateAndDisplayTotalPrice();
        }

        private void CalculateAndDisplayTotalPrice()
        {
            if (selectedFlight?.Price == null)
            {
                LblTotalPrice.Text = "Total Price: N/A";
                return;
            }

            int numberOfTickets = (int)numTickets.Value;
            decimal totalPrice = selectedFlight.Price.Value * numberOfTickets;
            LblTotalPrice.Text = $"Total Price: {totalPrice:C}";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Validate number of tickets
            int numberOfTickets = (int)numTickets.Value;
            if (numberOfTickets < 1)
            {
                MessageBox.Show("Please select at least 1 ticket.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate flight price
            if (selectedFlight?.Price == null)
            {
                MessageBox.Show("Flight price information is unavailable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate total price
            decimal totalPrice = selectedFlight.Price.Value * numberOfTickets;

            // Navigate to seat selection page with all booking details
            var seatSelectionPage = new SeatSelectionPage(userLoggedIn, selectedFlight, numberOfTickets, totalPrice);
            seatSelectionPage.FormClosed += (s, args) => this.Close();
            seatSelectionPage.Show();
            this.Hide();
        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }

        private void LblTotalPrice_Click_1(object sender, EventArgs e)
        {

        }
    }
}
