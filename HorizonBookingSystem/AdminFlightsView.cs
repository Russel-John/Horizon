using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace HorizonBookingSystem
{
    public partial class AdminFlightsView : Form
    {
        private Users AdminLoggedIn;
        private BookingDBEntities db = new BookingDBEntities();

        public AdminFlightsView(Users admin)
        {
            InitializeComponent();
            AdminLoggedIn = admin;
        }

        private void AdminFlightsView_Load(object sender, EventArgs e)
        {
            LoadFlights();
            PopulateFilters();
        }

        private void LoadFlights()
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Flight ID", typeof(int));
                dataTable.Columns.Add("Departure", typeof(string));
                dataTable.Columns.Add("Destination", typeof(string));
                dataTable.Columns.Add("Flight Date", typeof(string));
                dataTable.Columns.Add("Flight Time", typeof(string));
                dataTable.Columns.Add("Price", typeof(string));

                var flights = db.Flights.ToList();

                foreach (var flight in flights)
                {
                    dataTable.Rows.Add(
                        flight.FlightID,
                        flight.Departure,
                        flight.Destination,
                        flight.FlightDate?.ToString("MM/dd/yyyy") ?? "N/A",
                        flight.FlightTime ?? "N/A",
                        flight.Price?.ToString("C") ?? "N/A"
                    );
                }

                dgvFlights.DataSource = dataTable;

                // Format the DataGridView
                if (dgvFlights.Columns.Count > 0)
                {
                    // Set column widths
                    dgvFlights.Columns["Flight ID"].Width = 80;
                    dgvFlights.Columns["Departure"].Width = 120;
                    dgvFlights.Columns["Destination"].Width = 120;
                    dgvFlights.Columns["Flight Date"].Width = 100;
                    dgvFlights.Columns["Flight Time"].Width = 100;
                    dgvFlights.Columns["Price"].Width = 100;

                    // Format headers
                    dgvFlights.EnableHeadersVisualStyles = false;
                    dgvFlights.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
                    dgvFlights.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvFlights.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    dgvFlights.ColumnHeadersHeight = 40;

                    // Format rows
                    dgvFlights.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                    dgvFlights.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
                    dgvFlights.DefaultCellStyle.SelectionForeColor = Color.White;
                    dgvFlights.RowTemplate.Height = 35;
                }

                lblTotalFlights.Text = $"Total Flights: {flights.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading flights: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateFilters()
        {
            var flights = db.Flights.ToList();

            // Populate departure cities
            cmBoxFrom.Items.Clear();
            cmBoxFrom.Items.Add("All Departures");

            var departures = flights.Select(f => f.Departure).Distinct().OrderBy(d => d).ToList();
            foreach (var departure in departures)
            {
                if (!string.IsNullOrEmpty(departure))
                    cmBoxFrom.Items.Add(departure);
            }
            cmBoxFrom.SelectedIndex = 0;

            // Populate destination cities
            cmBoxTo.Items.Clear();
            cmBoxTo.Items.Add("All Destinations");

            var destinations = flights.Select(f => f.Destination).Distinct().OrderBy(d => d).ToList();
            foreach (var destination in destinations)
            {
                if (!string.IsNullOrEmpty(destination))
                    cmBoxTo.Items.Add(destination);
            }
            cmBoxTo.SelectedIndex = 0;

            // Populate sort options
            cmBoxSort.Items.Clear();
            cmBoxSort.Items.Add("No Sort");
            cmBoxSort.Items.Add("Latest");
            cmBoxSort.Items.Add("Oldest");
            cmBoxSort.Items.Add("Price: Low to High");
            cmBoxSort.Items.Add("Price: High to Low");
            cmBoxSort.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cmBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cmBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cmBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Flight ID", typeof(int));
                dataTable.Columns.Add("Departure", typeof(string));
                dataTable.Columns.Add("Destination", typeof(string));
                dataTable.Columns.Add("Flight Date", typeof(string));
                dataTable.Columns.Add("Flight Time", typeof(string));
                dataTable.Columns.Add("Price", typeof(string));

                string fromFilter = cmBoxFrom.SelectedItem?.ToString();
                string toFilter = cmBoxTo.SelectedItem?.ToString();
                string sortOption = cmBoxSort.SelectedItem?.ToString();

                var flights = db.Flights.ToList();

                // Apply departure filter
                if (!string.IsNullOrEmpty(fromFilter) && fromFilter != "All Departures")
                {
                    flights = flights.Where(f => f.Departure == fromFilter).ToList();
                }

                // Apply destination filter
                if (!string.IsNullOrEmpty(toFilter) && toFilter != "All Destinations")
                {
                    flights = flights.Where(f => f.Destination == toFilter).ToList();
                }

                // Apply sorting
                if (!string.IsNullOrEmpty(sortOption))
                {
                    if (sortOption == "Latest")
                    {
                        flights = flights.OrderByDescending(f => f.FlightDate).ToList();
                    }
                    else if (sortOption == "Oldest")
                    {
                        flights = flights.OrderBy(f => f.FlightDate).ToList();
                    }
                    else if (sortOption == "Price: Low to High")
                    {
                        flights = flights.OrderBy(f => f.Price).ToList();
                    }
                    else if (sortOption == "Price: High to Low")
                    {
                        flights = flights.OrderByDescending(f => f.Price).ToList();
                    }
                }

                foreach (var flight in flights)
                {
                    dataTable.Rows.Add(
                        flight.FlightID,
                        flight.Departure,
                        flight.Destination,
                        flight.FlightDate?.ToString("MM/dd/yyyy") ?? "N/A",
                        flight.FlightTime ?? "N/A",
                        flight.Price?.ToString("C") ?? "N/A"
                    );
                }

                dgvFlights.DataSource = dataTable;
                lblTotalFlights.Text = $"Total Flights: {flights.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering flights: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmBoxFrom.SelectedIndex = 0;
            cmBoxTo.SelectedIndex = 0;
            cmBoxSort.SelectedIndex = 0;
            LoadFlights();
            PopulateFilters();
        }

        private void dgvFlights_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ViewFlightDetails();
            }
        }

        private void ViewFlightDetails()
        {
            if (dgvFlights.CurrentRow != null)
            {
                var flightId = dgvFlights.CurrentRow.Cells["Flight ID"].Value.ToString();
                var departure = dgvFlights.CurrentRow.Cells["Departure"].Value.ToString();
                var destination = dgvFlights.CurrentRow.Cells["Destination"].Value.ToString();
                var flightDate = dgvFlights.CurrentRow.Cells["Flight Date"].Value.ToString();
                var flightTime = dgvFlights.CurrentRow.Cells["Flight Time"].Value.ToString();
                var price = dgvFlights.CurrentRow.Cells["Price"].Value.ToString();

                string details = $"Flight ID: {flightId}\n" +
                               $"Route: {departure} → {destination}\n" +
                               $"Date: {flightDate}\n" +
                               $"Time: {flightTime}\n" +
                               $"Price: {price}";

                MessageBox.Show(details, "Flight Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // CREATE - Add new flight
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new FlightFormDialog();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var newFlight = new Flights
                    {
                        Departure = addForm.Departure,
                        Destination = addForm.Destination,
                        FlightDate = addForm.FlightDate,
                        FlightTime = addForm.FlightTime,
                        Price = addForm.Price
                    };

                    db.Flights.Add(newFlight);
                    db.SaveChanges();

                    MessageBox.Show("Flight added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFlights();
                    PopulateFilters();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding flight: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // UPDATE - Edit existing flight
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvFlights.CurrentRow == null)
            {
                MessageBox.Show("Please select a flight to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int flightId = Convert.ToInt32(dgvFlights.CurrentRow.Cells["Flight ID"].Value);
            var flight = db.Flights.FirstOrDefault(f => f.FlightID == flightId);

            if (flight == null)
            {
                MessageBox.Show("Flight not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var editForm = new FlightFormDialog(flight);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    flight.Departure = editForm.Departure;
                    flight.Destination = editForm.Destination;
                    flight.FlightDate = editForm.FlightDate;
                    flight.FlightTime = editForm.FlightTime;
                    flight.Price = editForm.Price;

                    db.SaveChanges();

                    MessageBox.Show("Flight updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFlights();
                    PopulateFilters();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating flight: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // DELETE - Remove flight
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFlights.CurrentRow == null)
            {
                MessageBox.Show("Please select a flight to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int flightId = Convert.ToInt32(dgvFlights.CurrentRow.Cells["Flight ID"].Value);
            var flight = db.Flights.FirstOrDefault(f => f.FlightID == flightId);

            if (flight == null)
            {
                MessageBox.Show("Flight not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to delete this flight?\n\nFlight ID: {flight.FlightID}\nRoute: {flight.Departure} → {flight.Destination}\n\nThis will also delete all related bookings and seats!",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Delete related records first
                    var bookingSeats = db.BookingSeats.Where(bs => bs.Bookings.FlightID == flightId).ToList();
                    foreach (var bs in bookingSeats)
                    {
                        db.BookingSeats.Remove(bs);
                    }

                    var bookings = db.Bookings.Where(b => b.FlightID == flightId).ToList();
                    foreach (var booking in bookings)
                    {
                        db.Bookings.Remove(booking);
                    }

                    var seats = db.Seats.Where(s => s.FlightID == flightId).ToList();
                    foreach (var seat in seats)
                    {
                        db.Seats.Remove(seat);
                    }

                    db.Flights.Remove(flight);
                    db.SaveChanges();

                    MessageBox.Show("Flight deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFlights();
                    PopulateFilters();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting flight: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
