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
            this.label1 = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblTicket = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.numTickets = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTotalPrice = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Flight Date: {date}";
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
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.flowLayoutPanel1.Controls.Add(this.LblTotalPrice);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 319);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(598, 92);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // numTickets
            // 
            this.numTickets.Location = new System.Drawing.Point(97, 268);
            this.numTickets.Name = "numTickets";
            this.numTickets.Size = new System.Drawing.Size(90, 20);
            this.numTickets.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price: {price}";
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.LblTotalPrice.Location = new System.Drawing.Point(458, 0);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(137, 21);
            this.LblTotalPrice.TabIndex = 3;
            this.LblTotalPrice.Text = "Total Price: {total}";
            // 
            // BookingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(598, 411);
            this.Controls.Add(this.LblTicket);
            this.Controls.Add(this.numTickets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblTicket;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTotalPrice;
    }
}