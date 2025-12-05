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

        private void Loginpage_Load(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;

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
                AdminPage adminPage = new AdminPage(user);
                adminPage.Show();
                this.Hide();
            }
            else
            {
                HomePage homePage = new HomePage(user);
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

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
            this.Hide();
        }
    }
}
