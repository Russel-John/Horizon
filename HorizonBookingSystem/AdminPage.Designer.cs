namespace HorizonBookingSystem
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoutButton = new FontAwesome.Sharp.IconButton();
            this.FlightsButton = new FontAwesome.Sharp.IconButton();
            this.UsersButton = new FontAwesome.Sharp.IconButton();
            this.DashboardButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.LogoutButton);
            this.panel1.Controls.Add(this.FlightsButton);
            this.panel1.Controls.Add(this.UsersButton);
            this.panel1.Controls.Add(this.DashboardButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 450);
            this.panel1.TabIndex = 0;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.LogoutButton.IconColor = System.Drawing.Color.White;
            this.LogoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogoutButton.IconSize = 30;
            this.LogoutButton.Location = new System.Drawing.Point(0, 333);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LogoutButton.Size = new System.Drawing.Size(186, 63);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // FlightsButton
            // 
            this.FlightsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlightsButton.FlatAppearance.BorderSize = 0;
            this.FlightsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlightsButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightsButton.ForeColor = System.Drawing.Color.White;
            this.FlightsButton.IconChar = FontAwesome.Sharp.IconChar.Plane;
            this.FlightsButton.IconColor = System.Drawing.Color.White;
            this.FlightsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FlightsButton.IconSize = 30;
            this.FlightsButton.Location = new System.Drawing.Point(0, 270);
            this.FlightsButton.Name = "FlightsButton";
            this.FlightsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FlightsButton.Size = new System.Drawing.Size(186, 63);
            this.FlightsButton.TabIndex = 3;
            this.FlightsButton.Text = "Flights";
            this.FlightsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FlightsButton.UseVisualStyleBackColor = true;
            this.FlightsButton.Click += new System.EventHandler(this.FlightsButton_Click);
            // 
            // UsersButton
            // 
            this.UsersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersButton.FlatAppearance.BorderSize = 0;
            this.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersButton.ForeColor = System.Drawing.Color.White;
            this.UsersButton.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.UsersButton.IconColor = System.Drawing.Color.White;
            this.UsersButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UsersButton.IconSize = 30;
            this.UsersButton.Location = new System.Drawing.Point(0, 207);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.UsersButton.Size = new System.Drawing.Size(186, 63);
            this.UsersButton.TabIndex = 2;
            this.UsersButton.Text = "Users";
            this.UsersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.ForeColor = System.Drawing.Color.White;
            this.DashboardButton.IconChar = FontAwesome.Sharp.IconChar.Gauge;
            this.DashboardButton.IconColor = System.Drawing.Color.White;
            this.DashboardButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DashboardButton.IconSize = 30;
            this.DashboardButton.Location = new System.Drawing.Point(0, 144);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DashboardButton.Size = new System.Drawing.Size(186, 63);
            this.DashboardButton.TabIndex = 1;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(186, 0);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(614, 450);
            this.DesktopPanel.TabIndex = 1;
            this.DesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DesktopPanel_Paint);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel - Horizon Booking System";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton DashboardButton;
        private FontAwesome.Sharp.IconButton UsersButton;
        private FontAwesome.Sharp.IconButton FlightsButton;
        private FontAwesome.Sharp.IconButton LogoutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel DesktopPanel;
    }
}