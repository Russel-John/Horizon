using System;
using System.Linq;
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

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter your username", "Username Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your password", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxPassword.Focus();
                return;
            }

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

            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (user.roleID == 1)
            {
                new AdminPage(user).Show();
            }
            else
            {
                new HomePage(user).Show();
            }
            
            this.Hide();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterPage().Show();
            this.Hide();
        }

        private void Loginpage_Load(object sender, EventArgs e)
        {

        }
    }
}
