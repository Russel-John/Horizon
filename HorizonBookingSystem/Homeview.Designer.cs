namespace HorizonBookingSystem
{
    partial class Homeview
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.panelBookingCount = new System.Windows.Forms.Panel();
            this.lblBookingCount = new System.Windows.Forms.Label();
            this.lblBookingLabel = new System.Windows.Forms.Label();
            this.panelUpcoming = new System.Windows.Forms.Panel();
            this.lblUpcomingCount = new System.Windows.Forms.Label();
            this.lblUpcomingLabel = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblQuickStart = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelBookingCount.SuspendLayout();
            this.panelUpcoming.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panelHeader.Size = new System.Drawing.Size(614, 120);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblSubtitle.Location = new System.Drawing.Point(30, 70);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(292, 21);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Your journey to the skies begins here ✈️";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome {name}";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.White;
            this.panelStats.Controls.Add(this.panelBookingCount);
            this.panelStats.Controls.Add(this.panelUpcoming);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Location = new System.Drawing.Point(0, 120);
            this.panelStats.Name = "panelStats";
            this.panelStats.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panelStats.Size = new System.Drawing.Size(614, 120);
            this.panelStats.TabIndex = 1;
            // 
            // panelBookingCount
            // 
            this.panelBookingCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.panelBookingCount.Controls.Add(this.lblBookingCount);
            this.panelBookingCount.Controls.Add(this.lblBookingLabel);
            this.panelBookingCount.Location = new System.Drawing.Point(30, 20);
            this.panelBookingCount.Name = "panelBookingCount";
            this.panelBookingCount.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelBookingCount.Size = new System.Drawing.Size(260, 80);
            this.panelBookingCount.TabIndex = 0;
            // 
            // lblBookingCount
            // 
            this.lblBookingCount.AutoSize = true;
            this.lblBookingCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBookingCount.ForeColor = System.Drawing.Color.White;
            this.lblBookingCount.Location = new System.Drawing.Point(20, 30);
            this.lblBookingCount.Name = "lblBookingCount";
            this.lblBookingCount.Size = new System.Drawing.Size(33, 37);
            this.lblBookingCount.TabIndex = 1;
            this.lblBookingCount.Text = "0";
            // 
            // lblBookingLabel
            // 
            this.lblBookingLabel.AutoSize = true;
            this.lblBookingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblBookingLabel.ForeColor = System.Drawing.Color.White;
            this.lblBookingLabel.Location = new System.Drawing.Point(20, 10);
            this.lblBookingLabel.Name = "lblBookingLabel";
            this.lblBookingLabel.Size = new System.Drawing.Size(109, 20);
            this.lblBookingLabel.TabIndex = 0;
            this.lblBookingLabel.Text = "Total Bookings";
            // 
            // panelUpcoming
            // 
            this.panelUpcoming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelUpcoming.Controls.Add(this.lblUpcomingCount);
            this.panelUpcoming.Controls.Add(this.lblUpcomingLabel);
            this.panelUpcoming.Location = new System.Drawing.Point(324, 20);
            this.panelUpcoming.Name = "panelUpcoming";
            this.panelUpcoming.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelUpcoming.Size = new System.Drawing.Size(260, 80);
            this.panelUpcoming.TabIndex = 1;
            // 
            // lblUpcomingCount
            // 
            this.lblUpcomingCount.AutoSize = true;
            this.lblUpcomingCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblUpcomingCount.ForeColor = System.Drawing.Color.White;
            this.lblUpcomingCount.Location = new System.Drawing.Point(20, 30);
            this.lblUpcomingCount.Name = "lblUpcomingCount";
            this.lblUpcomingCount.Size = new System.Drawing.Size(33, 37);
            this.lblUpcomingCount.TabIndex = 1;
            this.lblUpcomingCount.Text = "0";
            // 
            // lblUpcomingLabel
            // 
            this.lblUpcomingLabel.AutoSize = true;
            this.lblUpcomingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblUpcomingLabel.ForeColor = System.Drawing.Color.White;
            this.lblUpcomingLabel.Location = new System.Drawing.Point(20, 10);
            this.lblUpcomingLabel.Name = "lblUpcomingLabel";
            this.lblUpcomingLabel.Size = new System.Drawing.Size(129, 20);
            this.lblUpcomingLabel.TabIndex = 0;
            this.lblUpcomingLabel.Text = "Upcoming Flights";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panelContent.Controls.Add(this.lblQuickStart);
            this.panelContent.Controls.Add(this.lblDescription);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 240);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(30);
            this.panelContent.Size = new System.Drawing.Size(614, 210);
            this.panelContent.TabIndex = 2;
            // 
            // lblQuickStart
            // 
            this.lblQuickStart.AutoSize = true;
            this.lblQuickStart.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblQuickStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblQuickStart.Location = new System.Drawing.Point(30, 30);
            this.lblQuickStart.Name = "lblQuickStart";
            this.lblQuickStart.Size = new System.Drawing.Size(212, 30);
            this.lblQuickStart.TabIndex = 0;
            this.lblQuickStart.Text = "Getting Started 🚀";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.lblDescription.Location = new System.Drawing.Point(30, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(554, 110);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "• Click on \"Flights\" to browse available flights\r\n• Select your desired flight an" +
    "d book your tickets\r\n• Choose your preferred seats\r\n• View your profile to manag" +
    "e your bookings";
            // 
            // Homeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Homeview";
            this.Text = "Homeview";
            this.Load += new System.EventHandler(this.Homeview_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.panelBookingCount.ResumeLayout(false);
            this.panelBookingCount.PerformLayout();
            this.panelUpcoming.ResumeLayout(false);
            this.panelUpcoming.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelBookingCount;
        private System.Windows.Forms.Label lblBookingCount;
        private System.Windows.Forms.Label lblBookingLabel;
        private System.Windows.Forms.Panel panelUpcoming;
        private System.Windows.Forms.Label lblUpcomingCount;
        private System.Windows.Forms.Label lblUpcomingLabel;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblQuickStart;
        private System.Windows.Forms.Label lblDescription;
    }
}