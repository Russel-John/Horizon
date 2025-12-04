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
            // Load all flights into the typed DataSet
            this.flightsTableAdapter.Fill(this.bookingDBDataSet.Flights);

            // Ensure the binding source initially points to the full table
            this.flightsBindingSource.DataSource = this.bookingDBDataSet.Flights;

            // Populate departure cities from database (distinct values)
            var departureCities = this.bookingDBDataSet.Flights
                .Select(f => f.Departure)
                .Distinct()
                .OrderBy(d => d)
                .ToList();
            cmBoxFrom.DataSource = departureCities;
            cmBoxFrom.SelectedIndex = -1; // No selection initially

            // Populate destination cities from database (distinct values)
            var destinationCities = this.bookingDBDataSet.Flights
                .Select(f => f.Destination)
                .Distinct()
                .OrderBy(d => d)
                .ToList();
            cmBoxTo.DataSource = destinationCities;
            cmBoxTo.SelectedIndex = -1; // No selection initially

            // Populate sort options
            var sortOptions = new List<string> { "Latest", "Oldest" };
            cmBoxSort.DataSource = sortOptions;
            cmBoxSort.SelectedIndex = -1; // No selection initially

            // Hook events
            this.btnSearch.Click += BtnSearch_Click;
            this.cmBoxSort.SelectedIndexChanged += CmBoxSort_SelectedIndexChanged;
            
            // Hook double-click on DataGridView (optional)
            this.dgvFlights.CellDoubleClick += DataGridView1_CellDoubleClick;
        }

        // Handle row selection to navigate to BookingPage
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                NavigateToBookingPage();
            }
        }

        private void NavigateToBookingPage()
        {
            // Get the selected flight from the DataGridView
            if (dgvFlights.CurrentRow != null)
            {
                var selectedRow = (DataRowView)dgvFlights.CurrentRow.DataBoundItem;
                
                // Extract flight details from the DataRow
                int flightId = (int)selectedRow["FlightID"];
                
                // Create a Flights object with the selected data
                var selectedFlight = new Flights
                {
                    FlightID = flightId,
                    Departure = selectedRow["Departure"]?.ToString(),
                    Destination = selectedRow["Destination"]?.ToString(),
                    FlightDate = selectedRow["FlightDate"] as DateTime?,
                    FlightTime = selectedRow["FlightTime"]?.ToString(),
                    Price = selectedRow["Price"] as decimal?
                };

                // Open BookingPage with the selected flight
                var bookingPage = new BookingPage(userloggedIn, selectedFlight);
                bookingPage.Show();
            }
            else
            {
                MessageBox.Show("Please select a flight first.", "No Flight Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CmBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        /// <summary>
        /// Applies the filter based on cmBoxFrom / cmBoxTo and applies the selected sort (by FlightDate).
        /// When no filter is selected, shows all rows. When no sort is selected, preserves current order.
        /// </summary>
        private void ApplyFilterAndSort()
        {
            // Read selected values from databound ComboBoxes
            string from = cmBoxFrom.SelectedItem as string;
            string to = cmBoxTo.SelectedItem as string;

            // Get the typed DataTable
            var flightsTable = bookingDBDataSet.Flights;

            // Build a safe filter (escape single quotes)
            var filters = new List<string>();
            if (!string.IsNullOrWhiteSpace(from))
            {
                filters.Add($"Departure = '{from.Replace("'", "''")}'");
            }
            if (!string.IsNullOrWhiteSpace(to))
            {
                filters.Add($"Destination = '{to.Replace("'", "''")}'");
            }

            string filterExpression = filters.Count == 0 ? string.Empty : string.Join(" AND ", filters);

            // Determine sort direction based on cmBoxSort selection (by FlightDate)
            string sortExpression = null;
            var sortSelection = cmBoxSort.SelectedItem as string;
            if (!string.IsNullOrWhiteSpace(sortSelection))
            {
                if (sortSelection.Equals("Latest", StringComparison.OrdinalIgnoreCase))
                {
                    sortExpression = "FlightDate DESC";
                }
                else if (sortSelection.Equals("Oldest", StringComparison.OrdinalIgnoreCase))
                {
                    sortExpression = "FlightDate ASC";
                }
                // if additional options are present, ignore them (no sort)
            }

            if (string.IsNullOrEmpty(filterExpression) && string.IsNullOrEmpty(sortExpression))
            {
                // No filter, no sort -> show full table
                flightsBindingSource.DataSource = flightsTable;
            }
            else
            {
                var view = new DataView(flightsTable);
                if (!string.IsNullOrEmpty(filterExpression))
                    view.RowFilter = filterExpression;
                if (!string.IsNullOrEmpty(sortExpression))
                    view.Sort = sortExpression;

                flightsBindingSource.DataSource = view;
            }

            // Refresh the grid to reflect the new data source
            dgvFlights.Refresh();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            NavigateToBookingPage();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTo_Click(object sender, EventArgs e)
        {

        }

        private void cmBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFrom_Click(object sender, EventArgs e)
        {

        }
    }
}
