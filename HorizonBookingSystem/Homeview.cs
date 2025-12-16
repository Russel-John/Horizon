using System;
using System.Linq;
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
            label1.Text = $"Welcome, {UserloggedIn.username}!";
            LoadUserStatistics();
        }

        private void LoadUserStatistics()
        {
            try
            {
                int totalBookings = db.Bookings
                    .Where(b => b.UserID == UserloggedIn.userID)
                    .Count();
                lblBookingCount.Text = totalBookings.ToString();

                int upcomingFlights = db.Bookings
                    .Where(b => b.UserID == UserloggedIn.userID && b.Flights.FlightDate >= DateTime.Today)
                    .Count();
                lblUpcomingCount.Text = upcomingFlights.ToString();
            }
            catch
            {
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
