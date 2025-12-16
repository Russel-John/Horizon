using System;
using System.Windows.Forms;

namespace HorizonBookingSystem
{
    public partial class HomePage : Form
    {
        private Users UserloggedIn;
        private Form activeChildForm;

        public HomePage(Users userloggedIn)
        {
            InitializeComponent();
            UserloggedIn = userloggedIn;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Homeview(UserloggedIn));
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

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProfilePage(UserloggedIn));
        }

        private void FlightsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FlightPage(UserloggedIn));
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

        private void HomeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Homeview(UserloggedIn));
        }
    }
}
