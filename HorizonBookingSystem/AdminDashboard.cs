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
            lblWelcome.Text = $"Welcome, {(AdminLoggedIn?.username ?? "Admin")}!";
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            try
            {
                // Total Users
                int totalUsers = db.Users.Count();
                lblTotalUsers.Text = totalUsers.ToString();

                // Total Bookings
                int totalBookings = db.Bookings.Count();
                lblTotalBookings.Text = totalBookings.ToString();

                // Total Flights
                int totalFlights = db.Flights.Count();
                lblTotalFlights.Text = totalFlights.ToString();

                // Today's Bookings
                DateTime today = DateTime.Today;
                DateTime tomorrow = today.AddDays(1);
                int todayBookings = db.Bookings
                    .Where(b => b.BookingDate.HasValue && 
                                b.BookingDate.Value >= today &&
                                b.BookingDate.Value < tomorrow)
                    .Count();
                lblTodayBookings.Text = todayBookings.ToString();

                // Total Revenue
                decimal totalRevenue = db.Bookings
                    .Where(b => b.TotalPrice.HasValue)
                    .Sum(b => b.TotalPrice.Value);
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
    }
}
