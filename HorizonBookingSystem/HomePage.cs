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
    public partial class HomePage : Form
    {
        private Users UserloggedIn;
        private object activeChildForm;

        public HomePage(Users userloggedIn)
        {
            InitializeComponent();
            UserloggedIn = userloggedIn;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            var homeview = new Homeview(UserloggedIn);
            OpenChildForm(homeview);
        }
            
        private void OpenChildForm(Form child)
        {
            // Close existing child
            if (activeChildForm != null)
            {
                // Remove and dispose previous form
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
            child.TopLevel = false; // make it a control of the parent form
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            DesktopPanel.Controls.Add(child);
            DesktopPanel.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            // Create ProfilePage with the logged in user and display it inside DesktopPanel
            var profilePage = new ProfilePage(UserloggedIn);
            OpenChildForm(profilePage);
        }

        private void FlightsButton_Click(object sender, EventArgs e)
        {
            var flightPage = new FlightPage(UserloggedIn);
            OpenChildForm(flightPage);
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

        private void HomeButton_Click(object sender, EventArgs e)
        {
            var homeview = new Homeview(UserloggedIn);
            OpenChildForm(homeview);
        }
    }
}
