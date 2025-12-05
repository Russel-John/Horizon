using System;
using System.Linq;
using System.Windows.Forms;

namespace HorizonBookingSystem
{
    public partial class RegisterPage : Form
    {
        private BookingDBEntities db = new BookingDBEntities();
        
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;
            string email = txtBoxEmail.Text;

            if (username == "Username" || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter your username.", "Username Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxUsername.Focus();
                return;
            }

            if (password == "Password" || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your password.", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxPassword.Focus();
                return;
            }

            if (email == "Email" || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your email.", "Email Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxEmail.Focus();
                return;
            }

            var existingUser = db.Users.Where(u => u.username.Equals(username)).FirstOrDefault();
            if (existingUser != null)
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Users newUser = new Users
            {
                username = username,
                password = password,
                email = email,
                roleID = 2
            };

            db.Users.Add(newUser);
            db.SaveChanges();
            
            MessageBox.Show("Registration Successful! You can now login with your credentials.", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            new Loginpage().Show();
            this.Hide();
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }
    }
}
