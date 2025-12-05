namespace HorizonBookingSystem
{
    partial class FlightPage
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmBoxSort = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.cmBoxTo = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.cmBoxFrom = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.departureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingDBDataSet = new HorizonBookingSystem.BookingDBDataSet();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnBook = new System.Windows.Forms.Button();
            this.flightsTableAdapter = new HorizonBookingSystem.BookingDBDataSetTableAdapters.FlightsTableAdapter();
            this.flightsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelHeader.SuspendLayout();
            this.panelFilters.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDBDataSet)).BeginInit();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelHeader.Size = new System.Drawing.Size(614, 85);
            this.panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblSubtitle.Location = new System.Drawing.Point(20, 52);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(233, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Search and select your ideal flight";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(17, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Available Flights";
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panelFilters.Controls.Add(this.btnSearch);
            this.panelFilters.Controls.Add(this.cmBoxSort);
            this.panelFilters.Controls.Add(this.lblSort);
            this.panelFilters.Controls.Add(this.cmBoxTo);
            this.panelFilters.Controls.Add(this.lblTo);
            this.panelFilters.Controls.Add(this.cmBoxFrom);
            this.panelFilters.Controls.Add(this.lblFrom);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 85);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelFilters.Size = new System.Drawing.Size(614, 70);
            this.panelFilters.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(494, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cmBoxSort
            // 
            this.cmBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmBoxSort.FormattingEnabled = true;
            this.cmBoxSort.Items.AddRange(new object[] {
            "Lowest Price",
            "Highest Price",
            "Earliest Date",
            "Latest Date"});
            this.cmBoxSort.Location = new System.Drawing.Point(380, 22);
            this.cmBoxSort.Name = "cmBoxSort";
            this.cmBoxSort.Size = new System.Drawing.Size(103, 25);
            this.cmBoxSort.TabIndex = 5;
            this.cmBoxSort.SelectedIndexChanged += new System.EventHandler(this.cmBoxSort_SelectedIndexChanged_1);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.BackColor = System.Drawing.Color.Transparent;
            this.lblSort.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblSort.Location = new System.Drawing.Point(317, 25);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(57, 19);
            this.lblSort.TabIndex = 4;
            this.lblSort.Text = "Sort by:";
            // 
            // cmBoxTo
            // 
            this.cmBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmBoxTo.FormattingEnabled = true;
            this.cmBoxTo.Location = new System.Drawing.Point(207, 22);
            this.cmBoxTo.Name = "cmBoxTo";
            this.cmBoxTo.Size = new System.Drawing.Size(104, 25);
            this.cmBoxTo.TabIndex = 3;
            this.cmBoxTo.SelectedIndexChanged += new System.EventHandler(this.cmBoxTo_SelectedIndexChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Transparent;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblTo.Location = new System.Drawing.Point(174, 25);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(27, 19);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To:";
            this.lblTo.Click += new System.EventHandler(this.lblTo_Click);
            // 
            // cmBoxFrom
            // 
            this.cmBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmBoxFrom.FormattingEnabled = true;
            this.cmBoxFrom.Location = new System.Drawing.Point(62, 22);
            this.cmBoxFrom.Name = "cmBoxFrom";
            this.cmBoxFrom.Size = new System.Drawing.Size(106, 25);
            this.cmBoxFrom.TabIndex = 1;
            this.cmBoxFrom.SelectedIndexChanged += new System.EventHandler(this.cmBoxFrom_SelectedIndexChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblFrom.Location = new System.Drawing.Point(12, 25);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(44, 19);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From:";
            this.lblFrom.Click += new System.EventHandler(this.lblFrom_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dgvFlights);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 155);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelGrid.Size = new System.Drawing.Size(614, 225);
            this.panelGrid.TabIndex = 2;
            // 
            // dgvFlights
            // 
            this.dgvFlights.AllowUserToAddRows = false;
            this.dgvFlights.AllowUserToDeleteRows = false;
            this.dgvFlights.AllowUserToResizeRows = false;
            this.dgvFlights.AutoGenerateColumns = false;
            this.dgvFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFlights.BackgroundColor = System.Drawing.Color.White;
            this.dgvFlights.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFlights.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFlights.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departureDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.flightDateDataGridViewTextBoxColumn,
            this.flightTimeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvFlights.DataSource = this.flightsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlights.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFlights.EnableHeadersVisualStyles = false;
            this.dgvFlights.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFlights.Location = new System.Drawing.Point(20, 15);
            this.dgvFlights.MultiSelect = false;
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.ReadOnly = true;
            this.dgvFlights.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvFlights.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFlights.RowTemplate.Height = 40;
            this.dgvFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlights.Size = new System.Drawing.Size(574, 195);
            this.dgvFlights.TabIndex = 0;
            this.dgvFlights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // departureDataGridViewTextBoxColumn
            // 
            this.departureDataGridViewTextBoxColumn.DataPropertyName = "Departure";
            this.departureDataGridViewTextBoxColumn.FillWeight = 80F;
            this.departureDataGridViewTextBoxColumn.HeaderText = "Departure";
            this.departureDataGridViewTextBoxColumn.Name = "departureDataGridViewTextBoxColumn";
            this.departureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.FillWeight = 80F;
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flightDateDataGridViewTextBoxColumn
            // 
            this.flightDateDataGridViewTextBoxColumn.DataPropertyName = "FlightDate";
            this.flightDateDataGridViewTextBoxColumn.FillWeight = 90F;
            this.flightDateDataGridViewTextBoxColumn.HeaderText = "Flight Date";
            this.flightDateDataGridViewTextBoxColumn.Name = "flightDateDataGridViewTextBoxColumn";
            this.flightDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flightTimeDataGridViewTextBoxColumn
            // 
            this.flightTimeDataGridViewTextBoxColumn.DataPropertyName = "FlightTime";
            this.flightTimeDataGridViewTextBoxColumn.FillWeight = 70F;
            this.flightTimeDataGridViewTextBoxColumn.HeaderText = "Flight Time";
            this.flightTimeDataGridViewTextBoxColumn.Name = "flightTimeDataGridViewTextBoxColumn";
            this.flightTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.FillWeight = 60F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "Flights";
            this.flightsBindingSource.DataSource = this.bookingDBDataSet;
            // 
            // bookingDBDataSet
            // 
            this.bookingDBDataSet.DataSetName = "BookingDBDataSet";
            this.bookingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.White;
            this.panelFooter.Controls.Add(this.btnBook);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 380);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(20, 10, 20, 15);
            this.panelFooter.Size = new System.Drawing.Size(614, 70);
            this.panelFooter.TabIndex = 3;
            // 
            // btnBook
            // 
            this.btnBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(242, 13);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(130, 42);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = "Book Flight";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
            // 
            // flightsBindingSource1
            // 
            this.flightsBindingSource1.DataMember = "Flights";
            this.flightsBindingSource1.DataSource = this.bookingDBDataSet;
            // 
            // FlightPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(614, 450);
            this.Name = "FlightPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Selection - Horizon";
            this.Load += new System.EventHandler(this.FlightPage_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDBDataSet)).EndInit();
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmBoxSort;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cmBoxTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox cmBoxFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvFlights;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnBook;
        private BookingDBDataSet bookingDBDataSet;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private BookingDBDataSetTableAdapters.FlightsTableAdapter flightsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource flightsBindingSource1;
    }
}