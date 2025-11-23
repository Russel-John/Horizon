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
    public partial class Homeview : Form
    {
        private Users UserloggedIn;
        public Homeview(Users userloggedIn)
        {
            InitializeComponent();
            UserloggedIn = userloggedIn;
        }

        private void Homeview_Load(object sender, EventArgs e)
        {

        }
    }
}
