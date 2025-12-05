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
    public partial class AdminPage : Form
    {
        private Users AdminLoggedIn;
        private object activeChildForm;

        public AdminPage(Users admin)
        {
            InitializeComponent();
            AdminLoggedIn = admin;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            // Load dashboard view by default
            var dashboardView = new AdminDashboard(AdminLoggedIn);
            OpenChildForm(dashboardView);
        }

        private void OpenChildForm(Form child)
        {
            // Close existing child
            if (activeChildForm != null)
            {
                DesktopPanel.Controls.Remove((Control)activeChildForm);
                var previousForm = activeChildForm as Form;
                if (previousForm != null)
                {
                    previousForm.Close();
                    previousForm.Dispose();
                }
                activeChildForm = null;
            }

            activeChildForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            DesktopPanel.Controls.Add(child);
            DesktopPanel.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            var dashboardView = new AdminDashboard(AdminLoggedIn);
            OpenChildForm(dashboardView);
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            var usersView = new AdminUsersView(AdminLoggedIn);
            OpenChildForm(usersView);
        }

        private void FlightsButton_Click(object sender, EventArgs e)
        {
            var flightsView = new AdminFlightsView(AdminLoggedIn);
            OpenChildForm(flightsView);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Loginpage loginPage = new Loginpage();
                loginPage.Show();
                this.Close();
            }
        }

        private void DesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
