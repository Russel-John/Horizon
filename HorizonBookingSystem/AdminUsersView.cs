using System;
using System.Linq;
using System.Windows.Forms;

namespace HorizonBookingSystem
{
    public partial class AdminUsersView : Form
    {
        private Users AdminLoggedIn;
        private BookingDBEntities db = new BookingDBEntities();

        public AdminUsersView(Users admin)
        {
            InitializeComponent();
            AdminLoggedIn = admin;
        }

        private void AdminUsersView_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            // TODO: Implement user management grid similar to ProfilePage bookings grid
            var users = db.Users.ToList();
            // Bind to grid when implemented
        }
    }

    partial class AdminUsersView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 450);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users Management\r\n(Coming Soon)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminUsersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUsersView";
            this.Text = "Users Management";
            this.Load += new System.EventHandler(this.AdminUsersView_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
    }
}
