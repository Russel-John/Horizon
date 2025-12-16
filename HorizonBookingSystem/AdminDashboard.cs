using System;
using System.Linq;
using System.Windows.Forms;

namespace HorizonBookingSystem
{
    public partial class AdminDashboard : Form
    {
        private Users AdminLoggedIn;
        private BookingDBEntities db = new BookingDBEntities();

        public AdminDashboard(Users admin)
        {
            InitializeComponent();
            AdminLoggedIn = admin;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {AdminLoggedIn.username}!";

            LoadStatistics();
        }

        private void LoadStatistics()
        {
            try
            {
                int totalUsers = db.Users.Count();
                lblTotalUsers.Text = totalUsers.ToString();

                int totalBookings = db.Bookings.Count();
                lblTotalBookings.Text = totalBookings.ToString();

                int totalFlights = db.Flights.Count();
                lblTotalFlights.Text = totalFlights.ToString();

                DateTime today = DateTime.Today;
                DateTime tomorrow = today.AddDays(1);
                int todayBookings = db.Bookings
                    .Where(b => b.BookingDate >= today && b.BookingDate < tomorrow)
                    .Count();
                lblTodayBookings.Text = todayBookings.ToString();

                decimal totalRevenue = db.Bookings.Sum(b => b.TotalPrice) ?? 0;
                lblTotalRevenue.Text = totalRevenue.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading statistics: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTotalBookings_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalUsers_Click(object sender, EventArgs e)
        {

        }

        private void panelStats_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
