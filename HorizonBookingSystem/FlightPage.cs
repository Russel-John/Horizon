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

            // Replace sort options with date-based options (designer had price labels)
            cmBoxSort.Items.Clear();
            cmBoxSort.Items.AddRange(new object[] { "Latest", "Oldest" });
            cmBoxSort.SelectedIndex = -1;

            // Hook events
            this.btnSearch.Click += BtnSearch_Click;
            this.cmBoxSort.SelectedIndexChanged += CmBoxSort_SelectedIndexChanged;
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
            // Read selected values (allow typed selection or typed-in text)
            string from = (cmBoxFrom.SelectedItem as string) ?? cmBoxFrom.Text;
            string to = (cmBoxTo.SelectedItem as string) ?? cmBoxTo.Text;

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
            var sortSelection = (cmBoxSort.SelectedItem as string) ?? cmBoxSort.Text;
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
            dataGridView1.Refresh();
        }
    }
}
