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
            this.SuspendLayout();
            // 
            // lblFlightInfo
            // 
            this.lblFlightInfo.AutoSize = true;
            this.lblFlightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightInfo.Location = new System.Drawing.Point(20, 20);
            this.lblFlightInfo.Name = "lblFlightInfo";
            this.lblFlightInfo.Size = new System.Drawing.Size(98, 20);
            this.lblFlightInfo.TabIndex = 0;
            this.lblFlightInfo.Text = "Flight Info:";
            this.lblFlightInfo.Click += new System.EventHandler(this.lblFlightInfo_Click);
            // 
            // lblTicketInfo
            // 
            this.lblTicketInfo.AutoSize = true;
            this.lblTicketInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketInfo.Location = new System.Drawing.Point(20, 50);
            this.lblTicketInfo.Name = "lblTicketInfo";
            this.lblTicketInfo.Size = new System.Drawing.Size(81, 17);
            this.lblTicketInfo.TabIndex = 1;
            this.lblTicketInfo.Text = "label2";
            this.lblTicketInfo.Click += new System.EventHandler(this.lblTicketInfo_Click);
            // 
            // panelSeats
            // 
            this.panelSeats.Location = new System.Drawing.Point(48, 81);
            this.panelSeats.Name = "panelSeats";
            this.panelSeats.Size = new System.Drawing.Size(657, 296);
            this.panelSeats.TabIndex = 2;
            this.panelSeats.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSeats_Paint);
            // 
            // lblSelectedSeats
            // 
            this.lblSelectedSeats.AutoSize = true;
            this.lblSelectedSeats.Location = new System.Drawing.Point(201, 32);
            this.lblSelectedSeats.Name = "lblSelectedSeats";
            this.lblSelectedSeats.Size = new System.Drawing.Size(35, 13);
            this.lblSelectedSeats.TabIndex = 3;
            this.lblSelectedSeats.Text = "label1";
            this.lblSelectedSeats.Click += new System.EventHandler(this.lblSelectedSeats_Click);
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Location = new System.Drawing.Point(97, 399);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmBooking.TabIndex = 4;
            this.btnConfirmBooking.Text = "Confirm";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(204, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SeatSelectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmBooking);
            this.Controls.Add(this.lblSelectedSeats);
            this.Controls.Add(this.panelSeats);
            this.Controls.Add(this.lblTicketInfo);
            this.Controls.Add(this.lblFlightInfo);
            this.Name = "SeatSelectionPage";
            this.Text = "SeatSelectionPage";
            this.Load += new System.EventHandler(this.SeatSelectionPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlightInfo;
        private System.Windows.Forms.Label lblTicketInfo;
        private System.Windows.Forms.Panel panelSeats;
        private System.Windows.Forms.Label lblSelectedSeats;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.Button btnCancel;
    }
}