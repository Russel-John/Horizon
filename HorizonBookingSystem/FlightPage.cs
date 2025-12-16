using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        private void FlightPage_Load(object sender, EventArgs e)
        {
            LoadFlights();
            LoadFilters();
        }

        private void LoadFlights()
        {
            this.flightsTableAdapter.Fill(this.bookingDBDataSet.Flights);
            this.flightsBindingSource.DataSource = this.bookingDBDataSet.Flights;
        }

        private void LoadFilters()
        {
            var departureCities = this.bookingDBDataSet.Flights
                .Select(f => f.Departure)
                .Distinct()
                .OrderBy(d => d)
                .ToList();
            cmBoxFrom.DataSource = departureCities;
            cmBoxFrom.SelectedIndex = -1;

            var destinationCities = this.bookingDBDataSet.Flights
                .Select(f => f.Destination)
                .Distinct()
                .OrderBy(d => d)
                .ToList();
            cmBoxTo.DataSource = destinationCities;
            cmBoxTo.SelectedIndex = -1;

            cmBoxSort.Items.Clear();
            cmBoxSort.Items.Add("Latest");
            cmBoxSort.Items.Add("Oldest");
            cmBoxSort.SelectedIndex = -1;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BookFlight();
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookFlight();
        }

        private void BookFlight()
        {
            if (dgvFlights.CurrentRow == null)
            {
                MessageBox.Show("Please select a flight first.", "No Flight Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = (DataRowView)dgvFlights.CurrentRow.DataBoundItem;
            
            var selectedFlight = new Flights
            {
                FlightID = (int)selectedRow["FlightID"],
                Departure = selectedRow["Departure"]?.ToString(),
                Destination = selectedRow["Destination"]?.ToString(),
                FlightDate = selectedRow["FlightDate"] as DateTime?,
                FlightTime = selectedRow["FlightTime"]?.ToString(),
                Price = selectedRow["Price"] as decimal?
            };

            var bookingPage = new BookingPage(userloggedIn, selectedFlight);
            bookingPage.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void CmBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string from = cmBoxFrom.SelectedItem as string;
            string to = cmBoxTo.SelectedItem as string;
            string sort = cmBoxSort.SelectedItem as string;

            var flightsTable = bookingDBDataSet.Flights;
            var filters = new List<string>();

            if (!string.IsNullOrWhiteSpace(from))
            {
                filters.Add($"Departure = '{from.Replace("'", "''")}'");
            }

            if (!string.IsNullOrWhiteSpace(to))
            {
                filters.Add($"Destination = '{to.Replace("'", "''")}'");
            }

            string filterExpression = string.Join(" AND ", filters);
            string sortExpression = "";

            if (sort == "Latest")
            {
                sortExpression = "FlightDate DESC";
            }
            else if (sort == "Oldest")
            {
                sortExpression = "FlightDate ASC";
            }

            if (string.IsNullOrEmpty(filterExpression) && string.IsNullOrEmpty(sortExpression))
            {
                flightsBindingSource.DataSource = flightsTable;
            }
            else
            {
                var view = new DataView(flightsTable);
                if (!string.IsNullOrEmpty(filterExpression))
                {
                    view.RowFilter = filterExpression;
                }
                if (!string.IsNullOrEmpty(sortExpression))
                {
                    view.Sort = sortExpression;
                }
                flightsBindingSource.DataSource = view;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblTo_Click(object sender, EventArgs e) { }
        private void cmBoxTo_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblFrom_Click(object sender, EventArgs e) { }
        private void cmBoxSort_SelectedIndexChanged_1(object sender, EventArgs e) { }
        private void cmBoxFrom_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
