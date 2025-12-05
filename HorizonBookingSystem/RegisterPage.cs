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

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxUsername_Enter(object sender, EventArgs e)
        {
            if (txtBoxUsername.Text == "Username")
            {
                txtBoxUsername.Text = "";
                txtBoxUsername.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            }
        }

        private void txtBoxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUsername.Text))
            {
                txtBoxUsername.Text = "Username";
                txtBoxUsername.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtBoxPassword_Enter(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text == "Password")
            {
                txtBoxPassword.Text = "";
                txtBoxPassword.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
                txtBoxPassword.PasswordChar = '●';
            }
        }

        private void txtBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                txtBoxPassword.PasswordChar = '\0';
                txtBoxPassword.Text = "Password";
                txtBoxPassword.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtBoxEmail_Enter(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text == "Email")
            {
                txtBoxEmail.Text = "";
                txtBoxEmail.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            }
        }

        private void txtBoxEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxEmail.Text))
            {
                txtBoxEmail.Text = "Email";
                txtBoxEmail.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Loginpage().Show();
            this.Hide();
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
    }
}
