namespace HorizonBookingSystem
{
    partial class SeatSelectionPage
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
            this.lblFlightInfo = new System.Windows.Forms.Label();
            this.lblTicketInfo = new System.Windows.Forms.Label();
            this.panelSeats = new System.Windows.Forms.Panel();
            this.lblSelectedSeats = new System.Windows.Forms.Label();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLegend = new System.Windows.Forms.Panel();
            this.pnlAvailableBox = new System.Windows.Forms.Panel();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.pnlSelectedBox = new System.Windows.Forms.Panel();
            this.lblSelected = new System.Windows.Forms.Label();
            this.pnlBookedBox = new System.Windows.Forms.Panel();
            this.lblBooked = new System.Windows.Forms.Label();
            this.PanelTitle.SuspendLayout();
            this.panelLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFlightInfo
            // 
            this.lblFlightInfo.AutoSize = true;
            this.lblFlightInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightInfo.Location = new System.Drawing.Point(19, 83);
            this.lblFlightInfo.Name = "lblFlightInfo";
            this.lblFlightInfo.Size = new System.Drawing.Size(85, 21);
            this.lblFlightInfo.TabIndex = 1;
            this.lblFlightInfo.Text = "Flight Info";
            this.lblFlightInfo.Click += new System.EventHandler(this.lblFlightInfo_Click);
            // 
            // lblTicketInfo
            // 
            this.lblTicketInfo.AutoSize = true;
            this.lblTicketInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketInfo.Location = new System.Drawing.Point(19, 116);
            this.lblTicketInfo.Name = "lblTicketInfo";
            this.lblTicketInfo.Size = new System.Drawing.Size(72, 19);
            this.lblTicketInfo.TabIndex = 2;
            this.lblTicketInfo.Text = "Ticket Info";
            this.lblTicketInfo.Click += new System.EventHandler(this.lblTicketInfo_Click);
            // 
            // panelSeats
            // 
            this.panelSeats.BackColor = System.Drawing.Color.White;
            this.panelSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSeats.Location = new System.Drawing.Point(20, 155);
            this.panelSeats.Name = "panelSeats";
            this.panelSeats.Size = new System.Drawing.Size(740, 320);
            this.panelSeats.TabIndex = 4;
            this.panelSeats.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSeats_Paint);
            // 
            // lblSelectedSeats
            // 
            this.lblSelectedSeats.AutoSize = true;
            this.lblSelectedSeats.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedSeats.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSelectedSeats.Location = new System.Drawing.Point(400, 116);
            this.lblSelectedSeats.Name = "lblSelectedSeats";
            this.lblSelectedSeats.Size = new System.Drawing.Size(103, 19);
            this.lblSelectedSeats.TabIndex = 3;
            this.lblSelectedSeats.Text = "Selected: None";
            this.lblSelectedSeats.Click += new System.EventHandler(this.lblSelectedSeats_Click);
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnConfirmBooking.FlatAppearance.BorderSize = 0;
            this.btnConfirmBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmBooking.ForeColor = System.Drawing.Color.White;
            this.btnConfirmBooking.Location = new System.Drawing.Point(640, 481);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(120, 35);
            this.btnConfirmBooking.TabIndex = 5;
            this.btnConfirmBooking.Text = "Confirm Booking";
            this.btnConfirmBooking.UseVisualStyleBackColor = false;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(23, 481);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PanelTitle.Controls.Add(this.lblTitle);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(784, 80);
            this.PanelTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Select Your Seat";
            // 
            // panelLegend
            // 
            this.panelLegend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLegend.Controls.Add(this.pnlAvailableBox);
            this.panelLegend.Controls.Add(this.lblAvailable);
            this.panelLegend.Controls.Add(this.pnlSelectedBox);
            this.panelLegend.Controls.Add(this.lblSelected);
            this.panelLegend.Controls.Add(this.pnlBookedBox);
            this.panelLegend.Controls.Add(this.lblBooked);
            this.panelLegend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLegend.Location = new System.Drawing.Point(0, 520);
            this.panelLegend.Name = "panelLegend";
            this.panelLegend.Size = new System.Drawing.Size(784, 50);
            this.panelLegend.TabIndex = 7;
            // 
            // pnlAvailableBox
            // 
            this.pnlAvailableBox.BackColor = System.Drawing.Color.LightGreen;
            this.pnlAvailableBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAvailableBox.Location = new System.Drawing.Point(20, 10);
            this.pnlAvailableBox.Name = "pnlAvailableBox";
            this.pnlAvailableBox.Size = new System.Drawing.Size(30, 30);
            this.pnlAvailableBox.TabIndex = 0;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(60, 15);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(63, 19);
            this.lblAvailable.TabIndex = 1;
            this.lblAvailable.Text = "Available";
            // 
            // pnlSelectedBox
            // 
            this.pnlSelectedBox.BackColor = System.Drawing.Color.Blue;
            this.pnlSelectedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelectedBox.Location = new System.Drawing.Point(170, 10);
            this.pnlSelectedBox.Name = "pnlSelectedBox";
            this.pnlSelectedBox.Size = new System.Drawing.Size(30, 30);
            this.pnlSelectedBox.TabIndex = 2;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(210, 15);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(59, 19);
            this.lblSelected.TabIndex = 3;
            this.lblSelected.Text = "Selected";
            // 
            // pnlBookedBox
            // 
            this.pnlBookedBox.BackColor = System.Drawing.Color.Gray;
            this.pnlBookedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBookedBox.Location = new System.Drawing.Point(320, 10);
            this.pnlBookedBox.Name = "pnlBookedBox";
            this.pnlBookedBox.Size = new System.Drawing.Size(30, 30);
            this.pnlBookedBox.TabIndex = 4;
            // 
            // lblBooked
            // 
            this.lblBooked.AutoSize = true;
            this.lblBooked.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooked.Location = new System.Drawing.Point(360, 15);
            this.lblBooked.Name = "lblBooked";
            this.lblBooked.Size = new System.Drawing.Size(55, 19);
            this.lblBooked.TabIndex = 5;
            this.lblBooked.Text = "Booked";
            // 
            // SeatSelectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 570);
            this.Controls.Add(this.panelLegend);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmBooking);
            this.Controls.Add(this.panelSeats);
            this.Controls.Add(this.lblSelectedSeats);
            this.Controls.Add(this.lblTicketInfo);
            this.Controls.Add(this.lblFlightInfo);
            this.Controls.Add(this.PanelTitle);
            this.MaximizeBox = false;
            this.Name = "SeatSelectionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seat Selection - Horizon Booking System";
            this.Load += new System.EventHandler(this.SeatSelectionPage_Load);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.panelLegend.ResumeLayout(false);
            this.panelLegend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFlightInfo;
        private System.Windows.Forms.Label lblTicketInfo;
        private System.Windows.Forms.Panel panelSeats;
        private System.Windows.Forms.Label lblSelectedSeats;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelLegend;
        private System.Windows.Forms.Panel pnlAvailableBox;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Panel pnlSelectedBox;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Panel pnlBookedBox;
        private System.Windows.Forms.Label lblBooked;
    }
}