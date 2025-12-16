using System;
using System.Linq;
using System.Text.RegularExpressions;
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

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxUsername_Enter(object sender, EventArgs e)
        {
            if (txtBoxUsername.Text == "Username")
            {
                txtBoxUsername.Text = "";
            }
        }

        private void txtBoxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUsername.Text))
            {
                txtBoxUsername.Text = "Username";
            }
        }

        private void txtBoxPassword_Enter(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text == "Password")
            {
                txtBoxPassword.Text = "";
                txtBoxPassword.PasswordChar = '●';
            }
        }

        private void txtBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                txtBoxPassword.PasswordChar = '\0';
                txtBoxPassword.Text = "Password";
            }
        }

        private void txtBoxEmail_Enter(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text == "Email")
            {
                txtBoxEmail.Text = "";
            }
        }

        private void txtBoxEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxEmail.Text))
            {
                txtBoxEmail.Text = "Email";
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Loginpage().Show();
            this.Hide();
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;
            string email = txtBoxEmail.Text;

            if ((username == "Username" || string.IsNullOrWhiteSpace(username)) && 
                (password == "Password" || string.IsNullOrWhiteSpace(password)) && 
                (email == "Email" || string.IsNullOrWhiteSpace(email)))
            {
                MessageBox.Show("Please enter all the required fields.", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username == "Username" || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter your username.", "Missing field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password == "Password" || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your password.", "Missing field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (email == "Email" || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your email.", "Missing field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existingUser = db.Users.FirstOrDefault(u => u.username == username);
            if (existingUser != null)
            {
                MessageBox.Show("Username already exists.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newUser = new Users
            {
                username = username,
                password = password,
                email = email,
                roleID = 2
            };

            db.Users.Add(newUser);
            db.SaveChanges();
            
            MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            new Loginpage().Show();
            this.Hide();
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
