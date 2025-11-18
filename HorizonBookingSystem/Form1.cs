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
    public partial class Loginpage : Form
    {
        private BookingDBEntities db = new BookingDBEntities();
        public Loginpage()
        {
            InitializeComponent();
        }

        private void Loginpage_Load(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;

            // SELECT Users WHERE USERNAME = "name"
            var user = db.Users.Where(u => u.username.Equals(username)).FirstOrDefault();

            if (user == null)
            {

                MessageBox.Show("No Such Username Found in the System", "No User Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!user.password.Equals(password))
            {

                MessageBox.Show("Wrong Password", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (user != null)
            {
                // Successful login
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Open the main application form
                HomePage homePage = new HomePage(user); // Pass the user object to the main form
                homePage.Show();
                this.Hide();
            }
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
