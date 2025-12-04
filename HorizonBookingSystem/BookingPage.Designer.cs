namespace HorizonBookingSystem
{
    partial class BookingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblDeparture = new System.Windows.Forms.Label();
            this.LblDestination = new System.Windows.Forms.Label();
            this.LblFlight = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblTicket = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.numTickets = new System.Windows.Forms.NumericUpDown();
            this.LblPrice = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.LblTitle.Location = new System.Drawing.Point(12, 20);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(227, 37);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Booking Details:";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(26, 67);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(141, 21);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "Username: {name}";
            this.LblUsername.Click += new System.EventHandler(this.LblUsername_Click);
            // 
            // LblDeparture
            // 
            this.LblDeparture.AutoSize = true;
            this.LblDeparture.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LblDeparture.Location = new System.Drawing.Point(26, 102);
            this.LblDeparture.Name = "LblDeparture";
            this.LblDeparture.Size = new System.Drawing.Size(151, 21);
            this.LblDeparture.TabIndex = 2;
            this.LblDeparture.Text = "Departure: {depart}";
            this.LblDeparture.Click += new System.EventHandler(this.LblDeparture_Click);
            // 
            // LblDestination
            // 
            this.LblDestination.AutoSize = true;
            this.LblDestination.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LblDestination.Location = new System.Drawing.Point(26, 133);
            this.LblDestination.Name = "LblDestination";
            this.LblDestination.Size = new System.Drawing.Size(193, 21);
            this.LblDestination.TabIndex = 3;
            this.LblDestination.Text = "Destination: {destination}";
            this.LblDestination.Click += new System.EventHandler(this.LblDestination_Click);
            // 
            // LblFlight
            // 
            this.LblFlight.AutoSize = true;
            this.LblFlight.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LblFlight.Location = new System.Drawing.Point(27, 164);
            this.LblFlight.Name = "LblFlight";
            this.LblFlight.Size = new System.Drawing.Size(140, 21);
            this.LblFlight.TabIndex = 4;
            this.LblFlight.Text = "Flight Date: {date}";
            this.LblFlight.Click += new System.EventHandler(this.LblFlight_Click);
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LblTime.Location = new System.Drawing.Point(26, 199);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(142, 21);
            this.LblTime.TabIndex = 5;
            this.LblTime.Text = "Flight Time: {time}";
            this.LblTime.Click += new System.EventHandler(this.LblTime_Click);
            // 
            // LblTicket
            // 
            this.LblTicket.AutoSize = true;
            this.LblTicket.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LblTicket.Location = new System.Drawing.Point(26, 265);
            this.LblTicket.Name = "LblTicket";
            this.LblTicket.Size = new System.Drawing.Size(65, 21);
            this.LblTicket.TabIndex = 6;
            this.LblTicket.Text = "Tickets:";
            this.LblTicket.Click += new System.EventHandler(this.LblTicket_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.flowLayoutPanel1.Controls.Add(this.LblTotalPrice);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 328);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(598, 83);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.LblTotalPrice.Location = new System.Drawing.Point(3, 0);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(137, 21);
            this.LblTotalPrice.TabIndex = 3;
            this.LblTotalPrice.Text = "Total Price: {total}";
            this.LblTotalPrice.Click += new System.EventHandler(this.LblTotalPrice_Click);
            // 
            // numTickets
            // 
            this.numTickets.Location = new System.Drawing.Point(97, 268);
            this.numTickets.Name = "numTickets";
            this.numTickets.Size = new System.Drawing.Size(90, 20);
            this.numTickets.TabIndex = 8;
            this.numTickets.ValueChanged += new System.EventHandler(this.numTickets_ValueChanged);
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(27, 231);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(101, 21);
            this.LblPrice.TabIndex = 2;
            this.LblPrice.Text = "Price: {price}";
            this.LblPrice.Click += new System.EventHandler(this.LblPrice_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkBlue;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(3, 24);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 30);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // BookingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(598, 411);
            this.Controls.Add(this.LblTicket);
            this.Controls.Add(this.numTickets);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.LblFlight);
            this.Controls.Add(this.LblDestination);
            this.Controls.Add(this.LblDeparture);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.LblTitle);
            this.Name = "BookingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingPage";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblDeparture;
        private System.Windows.Forms.Label LblDestination;
        private System.Windows.Forms.Label LblFlight;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblTicket;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numTickets;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblTotalPrice;
        private System.Windows.Forms.Button btnConfirm;
    }
}