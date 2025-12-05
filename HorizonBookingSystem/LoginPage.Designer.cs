namespace HorizonBookingSystem
{
    partial class Loginpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginpage));
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.lblRegister = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelPasswordBorder = new System.Windows.Forms.Panel();
            this.panelUsernameBorder = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelPasswordBorder.SuspendLayout();
            this.panelUsernameBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BackColor = System.Drawing.Color.White;
            this.txtBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxUsername.Location = new System.Drawing.Point(12, 10);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(296, 20);
            this.txtBoxUsername.TabIndex = 0;
            this.txtBoxUsername.Text = "Username";
            this.txtBoxUsername.Enter += new System.EventHandler(this.txtBoxUsername_Enter);
            this.txtBoxUsername.Leave += new System.EventHandler(this.txtBoxUsername_Leave);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.White;
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxPassword.Location = new System.Drawing.Point(12, 10);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(296, 20);
            this.txtBoxPassword.TabIndex = 1;
            this.txtBoxPassword.Text = "Password";
            this.txtBoxPassword.Enter += new System.EventHandler(this.txtBoxPassword_Enter);
            this.txtBoxPassword.Leave += new System.EventHandler(this.txtBoxPassword_Leave);
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn.FlatAppearance.BorderSize = 0;
            this.Loginbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Location = new System.Drawing.Point(30, 285);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(320, 45);
            this.Loginbtn.TabIndex = 2;
            this.Loginbtn.Text = "LOGIN";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // linkRegister
            // 
            this.linkRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.linkRegister.AutoSize = true;
            this.linkRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.linkRegister.Location = new System.Drawing.Point(225, 350);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(83, 15);
            this.linkRegister.TabIndex = 3;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Register here";
            this.linkRegister.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblRegister.Location = new System.Drawing.Point(75, 350);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(131, 15);
            this.lblRegister.TabIndex = 4;
            this.lblRegister.Text = "Don\'t have an account?";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.panelPasswordBorder);
            this.panelLogin.Controls.Add(this.panelUsernameBorder);
            this.panelLogin.Controls.Add(this.lblSubtitle);
            this.panelLogin.Controls.Add(this.lblTitle);
            this.panelLogin.Controls.Add(this.lblRegister);
            this.panelLogin.Controls.Add(this.linkRegister);
            this.panelLogin.Controls.Add(this.Loginbtn);
            this.panelLogin.Location = new System.Drawing.Point(220, 40);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(380, 400);
            this.panelLogin.TabIndex = 5;
            // 
            // panelPasswordBorder
            // 
            this.panelPasswordBorder.BackColor = System.Drawing.Color.White;
            this.panelPasswordBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPasswordBorder.Controls.Add(this.txtBoxPassword);
            this.panelPasswordBorder.Location = new System.Drawing.Point(30, 210);
            this.panelPasswordBorder.Name = "panelPasswordBorder";
            this.panelPasswordBorder.Size = new System.Drawing.Size(320, 42);
            this.panelPasswordBorder.TabIndex = 8;
            // 
            // panelUsernameBorder
            // 
            this.panelUsernameBorder.BackColor = System.Drawing.Color.White;
            this.panelUsernameBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsernameBorder.Controls.Add(this.txtBoxUsername);
            this.panelUsernameBorder.Location = new System.Drawing.Point(30, 140);
            this.panelUsernameBorder.Name = "panelUsernameBorder";
            this.panelUsernameBorder.Size = new System.Drawing.Size(320, 42);
            this.panelUsernameBorder.TabIndex = 7;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblSubtitle.Location = new System.Drawing.Point(85, 77);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(204, 17);
            this.lblSubtitle.TabIndex = 6;
            this.lblSubtitle.Text = "Book Your Journey to the Horizon";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitle.Location = new System.Drawing.Point(95, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 47);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "HORIZON";
            // 
            // Loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(820, 480);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Loginpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horizon - Login";
            this.Load += new System.EventHandler(this.Loginpage_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelPasswordBorder.ResumeLayout(false);
            this.panelPasswordBorder.PerformLayout();
            this.panelUsernameBorder.ResumeLayout(false);
            this.panelUsernameBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        private void txtBoxUsername_Enter(object sender, System.EventArgs e)
        {
            if (txtBoxUsername.Text == "Username")
            {
                txtBoxUsername.Text = "";
                txtBoxUsername.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            }
        }

        private void txtBoxUsername_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUsername.Text))
            {
                txtBoxUsername.Text = "Username";
                txtBoxUsername.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtBoxPassword_Enter(object sender, System.EventArgs e)
        {
            if (txtBoxPassword.Text == "Password")
            {
                txtBoxPassword.Text = "";
                txtBoxPassword.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
                txtBoxPassword.PasswordChar = '●';
            }
        }

        private void txtBoxPassword_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                txtBoxPassword.PasswordChar = '\0';
                txtBoxPassword.Text = "Password";
                txtBoxPassword.ForeColor = System.Drawing.Color.Gray;
            }
        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelUsernameBorder;
        private System.Windows.Forms.Panel panelPasswordBorder;
    }
}

