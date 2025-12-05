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
    public partial class Homeview : Form
    {
        private Users UserloggedIn;
        private BookingDBEntities db = new BookingDBEntities();

        public Homeview(Users userloggedIn)
        {
            InitializeComponent();
            UserloggedIn = userloggedIn;
        }

        private void Homeview_Load(object sender, EventArgs e)
        {
            // Update welcome message with username
            label1.Text = $"Welcome, {(UserloggedIn?.username ?? "Guest")}!";

            // Load user statistics
            LoadUserStatistics();
        }

        private void LoadUserStatistics()
        {
            if (UserloggedIn == null) return;

            try
            {
                // Get total bookings count for this user
                int totalBookings = db.Bookings
                    .Where(b => b.UserID == UserloggedIn.userID)
                    .Count();
                lblBookingCount.Text = totalBookings.ToString();

                // Get upcoming flights count (flights with future dates)
                int upcomingFlights = db.Bookings
                    .Where(b => b.UserID == UserloggedIn.userID && 
                                b.Flights != null && 
                                b.Flights.FlightDate.HasValue &&
                                b.Flights.FlightDate.Value >= DateTime.Today)
                    .Count();
                lblUpcomingCount.Text = upcomingFlights.ToString();
            }
            catch (Exception ex)
            {
                // If there's an error loading stats, show default values
                lblBookingCount.Text = "0";
                lblUpcomingCount.Text = "0";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
