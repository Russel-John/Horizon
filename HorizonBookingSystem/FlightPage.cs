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
    public partial class FlightPage : Form
    {
        private Users userloggedIn;

        public FlightPage(Users userloggedIn)
        {
            InitializeComponent();
            this.userloggedIn = userloggedIn;
        }

        public FlightPage()
        {
            
        }

        private void FlightPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookingDBDataSet.Flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter.Fill(this.bookingDBDataSet.Flights);

        }
    }
}
