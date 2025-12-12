using System;
using System.Windows.Forms;
using System.Drawing;

namespace HorizonBookingSystem
{
    public partial class FlightFormDialog : Form
    {
        public string Departure { get; private set; }
        public string Destination { get; private set; }
        public DateTime? FlightDate { get; private set; }
        public string FlightTime { get; private set; }
        public decimal? Price { get; private set; }

        private TextBox txtDeparture;
        private TextBox txtDestination;
        private DateTimePicker dtpFlightDate;
        private TextBox txtFlightTime;
        private TextBox txtPrice;
        private Button btnSave;
        private Button btnCancel;
        private Label lblDeparture;
        private Label lblDestination;
        private Label lblFlightDate;
        private Label lblFlightTime;
        private Label lblPrice;
        private Label lblTitle;

        private bool isEditMode = false;

        // Constructor for ADD
        public FlightFormDialog()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Flight";
            isEditMode = false;
        }

        // Constructor for EDIT
        public FlightFormDialog(Flights flight)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Flight";
            isEditMode = true;

            // Load existing data
            txtDeparture.Text = flight.Departure;
            txtDestination.Text = flight.Destination;
            dtpFlightDate.Value = flight.FlightDate ?? DateTime.Now;
            txtFlightTime.Text = flight.FlightTime;
            txtPrice.Text = flight.Price?.ToString() ?? "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtDeparture.Text))
            {
                MessageBox.Show("Please enter departure city.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDeparture.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDestination.Text))
            {
                MessageBox.Show("Please enter destination city.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDestination.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFlightTime.Text))
            {
                MessageBox.Show("Please enter flight time (e.g., 10:00 AM).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFlightTime.Focus();
                return;
            }

            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            // Set properties
            Departure = txtDeparture.Text.Trim();
            Destination = txtDestination.Text.Trim();
            FlightDate = dtpFlightDate.Value;
            FlightTime = txtFlightTime.Text.Trim();
            Price = price;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblFlightDate = new System.Windows.Forms.Label();
            this.dtpFlightDate = new System.Windows.Forms.DateTimePicker();
            this.lblFlightTime = new System.Windows.Forms.Label();
            this.txtFlightTime = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Flight Form";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDeparture.Location = new System.Drawing.Point(20, 70);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(75, 19);
            this.lblDeparture.TabIndex = 1;
            this.lblDeparture.Text = "Departure:";
            // 
            // txtDeparture
            // 
            this.txtDeparture.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDeparture.Location = new System.Drawing.Point(20, 92);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(360, 25);
            this.txtDeparture.TabIndex = 2;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDestination.Location = new System.Drawing.Point(20, 130);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(83, 19);
            this.lblDestination.TabIndex = 3;
            this.lblDestination.Text = "Destination:";
            // 
            // txtDestination
            // 
            this.txtDestination.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDestination.Location = new System.Drawing.Point(20, 152);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(360, 25);
            this.txtDestination.TabIndex = 4;
            // 
            // lblFlightDate
            // 
            this.lblFlightDate.AutoSize = true;
            this.lblFlightDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFlightDate.Location = new System.Drawing.Point(20, 190);
            this.lblFlightDate.Name = "lblFlightDate";
            this.lblFlightDate.Size = new System.Drawing.Size(80, 19);
            this.lblFlightDate.TabIndex = 5;
            this.lblFlightDate.Text = "Flight Date:";
            // 
            // dtpFlightDate
            // 
            this.dtpFlightDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFlightDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFlightDate.Location = new System.Drawing.Point(20, 212);
            this.dtpFlightDate.Name = "dtpFlightDate";
            this.dtpFlightDate.Size = new System.Drawing.Size(360, 25);
            this.dtpFlightDate.TabIndex = 6;
            // 
            // lblFlightTime
            // 
            this.lblFlightTime.AutoSize = true;
            this.lblFlightTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFlightTime.Location = new System.Drawing.Point(20, 250);
            this.lblFlightTime.Name = "lblFlightTime";
            this.lblFlightTime.Size = new System.Drawing.Size(145, 19);
            this.lblFlightTime.TabIndex = 7;
            this.lblFlightTime.Text = "Flight Time (e.g., 10:00 AM):";
            // 
            // txtFlightTime
            // 
            this.txtFlightTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFlightTime.Location = new System.Drawing.Point(20, 272);
            this.txtFlightTime.Name = "txtFlightTime";
            this.txtFlightTime.Size = new System.Drawing.Size(360, 25);
            this.txtFlightTime.TabIndex = 8;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrice.Location = new System.Drawing.Point(20, 310);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 19);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.Location = new System.Drawing.Point(20, 332);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(360, 25);
            this.txtPrice.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(180, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(290, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FlightFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 440);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtFlightTime);
            this.Controls.Add(this.lblFlightTime);
            this.Controls.Add(this.dtpFlightDate);
            this.Controls.Add(this.lblFlightDate);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlightFormDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Flight Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
