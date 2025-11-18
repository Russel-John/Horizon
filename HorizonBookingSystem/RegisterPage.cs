using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
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

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            Users newUser = new Users
            {
                username = txtBoxUsername.Text,
                password = txtBoxPassword.Text, 
                email = txtBoxEmail.Text,
                roleID = 1 
            }; 
            db.Users.Add(newUser);
            db.SaveChanges();
            MessageBox.Show("Registration Successful", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Loginpage logpage = new Loginpage();
            logpage.Show();
            this.Hide();
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }
    }
}
