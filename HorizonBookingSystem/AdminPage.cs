using System;
using System.Windows.Forms;

namespace HorizonBookingSystem
{
    public partial class AdminPage : Form
    {
        private Users AdminLoggedIn;
        private Form activeChildForm;

        public AdminPage(Users admin)
        {
            InitializeComponent();
            AdminLoggedIn = admin;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            OpenChildForm(new AdminDashboard(AdminLoggedIn));
        }

        private void OpenChildForm(Form child)
        {
            if (activeChildForm != null)
            {
                DesktopPanel.Controls.Remove(activeChildForm);
                activeChildForm.Close();
                activeChildForm.Dispose();
            }

            activeChildForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            DesktopPanel.Controls.Add(child);
            child.Show();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminDashboard(AdminLoggedIn));
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminUsersView(AdminLoggedIn));
        }

        private void FlightsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminFlightsView(AdminLoggedIn));
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                new Loginpage().Show();
                this.Close();
            }
        }

        private void DesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
