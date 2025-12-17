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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblDeparture = new System.Windows.Forms.Label();
            this.LblDestination = new System.Windows.Forms.Label();
            this.LblFlight = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.panelTickets = new System.Windows.Forms.Panel();
            this.numTickets = new System.Windows.Forms.NumericUpDown();
            this.LblTicket = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.LblTitle.Location = new System.Drawing.Point(20, 15);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(220, 37);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Booking Details";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelHeader.Controls.Add(this.LblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelHeader.Size = new System.Drawing.Size(598, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.LblUsername, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.LblDeparture, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.LblDestination, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.LblFlight, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.LblTime, 0, 4);
            this.tableLayoutPanelMain.Controls.Add(this.LblPrice, 0, 5);
            this.tableLayoutPanelMain.Controls.Add(this.panelTickets, 0, 6);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.tableLayoutPanelMain.RowCount = 7;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(598, 258);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(28, 13);
            this.LblUsername.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(542, 32);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "Username: {name}";
            this.LblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDeparture
            // 
            this.LblDeparture.AutoSize = true;
            this.LblDeparture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDeparture.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LblDeparture.Location = new System.Drawing.Point(28, 48);
            this.LblDeparture.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.LblDeparture.Name = "LblDeparture";
            this.LblDeparture.Size = new System.Drawing.Size(542, 32);
            this.LblDeparture.TabIndex = 2;
            this.LblDeparture.Text = "Departure: {depart}";
            this.LblDeparture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDestination
            // 
            this.LblDestination.AutoSize = true;
            this.LblDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDestination.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LblDestination.Location = new System.Drawing.Point(28, 83);
            this.LblDestination.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.LblDestination.Name = "LblDestination";
            this.LblDestination.Size = new System.Drawing.Size(542, 32);
            this.LblDestination.TabIndex = 3;
            this.LblDestination.Text = "Destination: {destination}";
            this.LblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblFlight
            // 
            this.LblFlight.AutoSize = true;
            this.LblFlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFlight.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LblFlight.Location = new System.Drawing.Point(28, 118);
            this.LblFlight.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.LblFlight.Name = "LblFlight";
            this.LblFlight.Size = new System.Drawing.Size(542, 32);
            this.LblFlight.TabIndex = 4;
            this.LblFlight.Text = "Flight Date: {date}";
            this.LblFlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LblTime.Location = new System.Drawing.Point(28, 153);
            this.LblTime.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(542, 32);
            this.LblTime.TabIndex = 5;
            this.LblTime.Text = "Flight Time: {time}";
            this.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(28, 188);
            this.LblPrice.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(542, 32);
            this.LblPrice.TabIndex = 6;
            this.LblPrice.Text = "Price: {price}";
            this.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTickets
            // 
            this.panelTickets.Controls.Add(this.numTickets);
            this.panelTickets.Controls.Add(this.LblTicket);
            this.panelTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTickets.Location = new System.Drawing.Point(28, 223);
            this.panelTickets.Name = "panelTickets";
            this.panelTickets.Size = new System.Drawing.Size(542, 22);
            this.panelTickets.TabIndex = 7;
            // 
            // numTickets
            // 
            this.numTickets.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numTickets.Location = new System.Drawing.Point(91, 0);
            this.numTickets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTickets.Name = "numTickets";
            this.numTickets.Size = new System.Drawing.Size(120, 25);
            this.numTickets.TabIndex = 0;
            this.numTickets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTickets.ValueChanged += new System.EventHandler(this.numTickets_ValueChanged);
            // 
            // LblTicket
            // 
            this.LblTicket.AutoSize = true;
            this.LblTicket.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LblTicket.Location = new System.Drawing.Point(0, 2);
            this.LblTicket.Name = "LblTicket";
            this.LblTicket.Size = new System.Drawing.Size(65, 21);
            this.LblTicket.TabIndex = 8;
            this.LblTicket.Text = "Tickets:";
            this.LblTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelFooter.Controls.Add(this.btnConfirm);
            this.panelFooter.Controls.Add(this.LblTotalPrice);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 328);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(25, 15, 25, 15);
            this.panelFooter.Size = new System.Drawing.Size(598, 83);
            this.panelFooter.TabIndex = 2;
            this.panelFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFooter_Paint);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(458, 18);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(115, 40);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Choose Seat";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.LblTotalPrice.Location = new System.Drawing.Point(25, 25);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(109, 25);
            this.LblTotalPrice.TabIndex = 0;
            this.LblTotalPrice.Text = "Total Price:";
            this.LblTotalPrice.Click += new System.EventHandler(this.LblTotalPrice_Click_1);
            // 
            // BookingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(598, 411);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "BookingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Details - Horizon";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.panelTickets.ResumeLayout(false);
            this.panelTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblDeparture;
        private System.Windows.Forms.Label LblDestination;
        private System.Windows.Forms.Label LblFlight;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Panel panelTickets;
        private System.Windows.Forms.NumericUpDown numTickets;
        private System.Windows.Forms.Label LblTicket;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label LblTotalPrice;
    }
}