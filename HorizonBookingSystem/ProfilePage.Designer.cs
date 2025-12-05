namespace HorizonBookingSystem
{
    partial class ProfilePage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Passlbl = new System.Windows.Forms.Label();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.tabBookings = new System.Windows.Forms.TabPage();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.btnRefreshBookings = new System.Windows.Forms.Button();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelBookingInfo = new System.Windows.Forms.Panel();
            this.lblBookingInfo = new System.Windows.Forms.Label();
            this.PanelTitle.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.tabBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingViewModelBindingSource)).BeginInit();
            this.panelBookingInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PanelTitle.Controls.Add(this.lblSubtitle);
            this.PanelTitle.Controls.Add(this.lblTitle);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(614, 80);
            this.PanelTitle.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblSubtitle.Location = new System.Drawing.Point(20, 50);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(280, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Manage your account and view bookings";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(17, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Your Profile";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabProfile);
            this.tabControl.Controls.Add(this.tabBookings);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 80);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(614, 370);
            this.tabControl.TabIndex = 1;
            // 
            // tabProfile
            // 
            this.tabProfile.BackColor = System.Drawing.Color.White;
            this.tabProfile.Controls.Add(this.btnSave);
            this.tabProfile.Controls.Add(this.txtEmail);
            this.tabProfile.Controls.Add(this.txtPassword);
            this.tabProfile.Controls.Add(this.txtUsername);
            this.tabProfile.Controls.Add(this.label3);
            this.tabProfile.Controls.Add(this.Passlbl);
            this.tabProfile.Controls.Add(this.Usernamelbl);
            this.tabProfile.Location = new System.Drawing.Point(4, 26);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(606, 340);
            this.tabProfile.TabIndex = 0;
            this.tabProfile.Text = "Profile Settings";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(220, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(180, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 27);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(180, 120);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(320, 27);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(180, 60);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(320, 27);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(80, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Passlbl
            // 
            this.Passlbl.AutoSize = true;
            this.Passlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Passlbl.Location = new System.Drawing.Point(80, 123);
            this.Passlbl.Name = "Passlbl";
            this.Passlbl.Size = new System.Drawing.Size(77, 20);
            this.Passlbl.TabIndex = 2;
            this.Passlbl.Text = "Password:";
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Usernamelbl.Location = new System.Drawing.Point(80, 63);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(82, 20);
            this.Usernamelbl.TabIndex = 1;
            this.Usernamelbl.Text = "Username:";
            // 
            // tabBookings
            // 
            this.tabBookings.BackColor = System.Drawing.Color.White;
            this.tabBookings.Controls.Add(this.btnCancelBooking);
            this.tabBookings.Controls.Add(this.btnRefreshBookings);
            this.tabBookings.Controls.Add(this.dgvBookings);
            this.tabBookings.Controls.Add(this.panelBookingInfo);
            this.tabBookings.Location = new System.Drawing.Point(4, 26);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookings.Size = new System.Drawing.Size(606, 340);
            this.tabBookings.TabIndex = 1;
            this.tabBookings.Text = "My Bookings";
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelBooking.FlatAppearance.BorderSize = 0;
            this.btnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBooking.ForeColor = System.Drawing.Color.White;
            this.btnCancelBooking.Location = new System.Drawing.Point(445, 290);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(140, 35);
            this.btnCancelBooking.TabIndex = 3;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // btnRefreshBookings
            // 
            this.btnRefreshBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.btnRefreshBookings.FlatAppearance.BorderSize = 0;
            this.btnRefreshBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshBookings.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshBookings.ForeColor = System.Drawing.Color.White;
            this.btnRefreshBookings.Location = new System.Drawing.Point(20, 290);
            this.btnRefreshBookings.Name = "btnRefreshBookings";
            this.btnRefreshBookings.Size = new System.Drawing.Size(140, 35);
            this.btnRefreshBookings.TabIndex = 2;
            this.btnRefreshBookings.Text = "Refresh";
            this.btnRefreshBookings.UseVisualStyleBackColor = false;
            this.btnRefreshBookings.Click += new System.EventHandler(this.btnRefreshBookings_Click);
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.AllowUserToResizeRows = false;
            this.dgvBookings.AutoGenerateColumns = false;
            this.dgvBookings.BackgroundColor = System.Drawing.Color.White;
            this.dgvBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBookings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.routeDataGridViewTextBoxColumn,
            this.flightDateDataGridViewTextBoxColumn,
            this.flightTimeDataGridViewTextBoxColumn,
            this.ticketsDataGridViewTextBoxColumn,
            this.seatsDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.bookedOnDataGridViewTextBoxColumn});
            this.dgvBookings.DataSource = this.bookingViewModelBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookings.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookings.EnableHeadersVisualStyles = false;
            this.dgvBookings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBookings.Location = new System.Drawing.Point(20, 60);
            this.dgvBookings.MultiSelect = false;
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.dgvBookings.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookings.RowTemplate.Height = 32;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(565, 215);
            this.dgvBookings.TabIndex = 1;
            this.dgvBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookings_CellContentClick);
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // routeDataGridViewTextBoxColumn
            // 
            this.routeDataGridViewTextBoxColumn.DataPropertyName = "Route";
            this.routeDataGridViewTextBoxColumn.HeaderText = "Route";
            this.routeDataGridViewTextBoxColumn.Name = "routeDataGridViewTextBoxColumn";
            this.routeDataGridViewTextBoxColumn.ReadOnly = true;
            this.routeDataGridViewTextBoxColumn.Width = 110;
            // 
            // flightDateDataGridViewTextBoxColumn
            // 
            this.flightDateDataGridViewTextBoxColumn.DataPropertyName = "FlightDate";
            this.flightDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.flightDateDataGridViewTextBoxColumn.Name = "flightDateDataGridViewTextBoxColumn";
            this.flightDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.flightDateDataGridViewTextBoxColumn.Width = 75;
            // 
            // flightTimeDataGridViewTextBoxColumn
            // 
            this.flightTimeDataGridViewTextBoxColumn.DataPropertyName = "FlightTime";
            this.flightTimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.flightTimeDataGridViewTextBoxColumn.Name = "flightTimeDataGridViewTextBoxColumn";
            this.flightTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.flightTimeDataGridViewTextBoxColumn.Width = 60;
            // 
            // ticketsDataGridViewTextBoxColumn
            // 
            this.ticketsDataGridViewTextBoxColumn.DataPropertyName = "Tickets";
            this.ticketsDataGridViewTextBoxColumn.HeaderText = "Tix";
            this.ticketsDataGridViewTextBoxColumn.Name = "ticketsDataGridViewTextBoxColumn";
            this.ticketsDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketsDataGridViewTextBoxColumn.Width = 40;
            // 
            // seatsDataGridViewTextBoxColumn
            // 
            this.seatsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.seatsDataGridViewTextBoxColumn.DataPropertyName = "Seats";
            this.seatsDataGridViewTextBoxColumn.HeaderText = "Seats";
            this.seatsDataGridViewTextBoxColumn.Name = "seatsDataGridViewTextBoxColumn";
            this.seatsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 70;
            // 
            // bookedOnDataGridViewTextBoxColumn
            // 
            this.bookedOnDataGridViewTextBoxColumn.DataPropertyName = "BookedOn";
            this.bookedOnDataGridViewTextBoxColumn.HeaderText = "Booked";
            this.bookedOnDataGridViewTextBoxColumn.Name = "bookedOnDataGridViewTextBoxColumn";
            this.bookedOnDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookedOnDataGridViewTextBoxColumn.Width = 90;
            // 
            // bookingViewModelBindingSource
            // 
            this.bookingViewModelBindingSource.DataSource = typeof(HorizonBookingSystem.BookingViewModel);
            // 
            // panelBookingInfo
            // 
            this.panelBookingInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panelBookingInfo.Controls.Add(this.lblBookingInfo);
            this.panelBookingInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBookingInfo.Location = new System.Drawing.Point(3, 3);
            this.panelBookingInfo.Name = "panelBookingInfo";
            this.panelBookingInfo.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelBookingInfo.Size = new System.Drawing.Size(600, 45);
            this.panelBookingInfo.TabIndex = 0;
            // 
            // lblBookingInfo
            // 
            this.lblBookingInfo.AutoSize = true;
            this.lblBookingInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblBookingInfo.Location = new System.Drawing.Point(15, 13);
            this.lblBookingInfo.Name = "lblBookingInfo";
            this.lblBookingInfo.Size = new System.Drawing.Size(361, 19);
            this.lblBookingInfo.TabIndex = 0;
            this.lblBookingInfo.Text = "View and manage your bookings. Select a row to cancel.";
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.PanelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfilePage";
            this.Text = "Profile Page - Horizon Booking System";
            this.Load += new System.EventHandler(this.ProfilePage_Load);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            this.tabBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingViewModelBindingSource)).EndInit();
            this.panelBookingInfo.ResumeLayout(false);
            this.panelBookingInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.Label Passlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabBookings;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Panel panelBookingInfo;
        private System.Windows.Forms.Label lblBookingInfo;
        private System.Windows.Forms.Button btnRefreshBookings;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.BindingSource bookingViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookedOnDataGridViewTextBoxColumn;
    }
}