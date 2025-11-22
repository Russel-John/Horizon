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
    public partial class ProfilePage : Form
    {
        private Users UserloggedIn;
        private BookingDBEntities db = new BookingDBEntities();
        public ProfilePage(Users user)
        {
            InitializeComponent();
            UserloggedIn = user; // Store the logged-in user
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            // Fill textboxes with current info
            if (UserloggedIn != null)
            {
                txtUsername.Text = UserloggedIn.username;
                txtEmail.Text = UserloggedIn.email;
                txtPassword.Text = UserloggedIn.password;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (UserloggedIn != null)
            {
                // Update the database
                var userInDb = db.Users.Where(u => u.userID == UserloggedIn.userID).FirstOrDefault();
                if (userInDb != null)
                {
                    userInDb.username = txtUsername.Text;
                    userInDb.email = txtEmail.Text;
                    userInDb.password = txtPassword.Text;

                    db.SaveChanges();
                    MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Optionally update the UserloggedIn object as well
                    UserloggedIn.username = userInDb.username;
                    UserloggedIn.email = userInDb.email;
                    UserloggedIn.password = userInDb.password;
                }
            }
        }
    }
}
