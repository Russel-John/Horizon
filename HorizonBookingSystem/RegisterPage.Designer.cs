namespace HorizonBookingSystem
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            this.panelRegister = new System.Windows.Forms.Panel();
            this.panelEmailBorder = new System.Windows.Forms.Panel();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.panelPasswordBorder = new System.Windows.Forms.Panel();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.panelUsernameBorder = new System.Windows.Forms.Panel();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.panelRegister.SuspendLayout();
            this.panelEmailBorder.SuspendLayout();
            this.panelPasswordBorder.SuspendLayout();
            this.panelUsernameBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.White;
            this.panelRegister.Controls.Add(this.panelEmailBorder);
            this.panelRegister.Controls.Add(this.panelPasswordBorder);
            this.panelRegister.Controls.Add(this.panelUsernameBorder);
            this.panelRegister.Controls.Add(this.lblSubtitle);
            this.panelRegister.Controls.Add(this.lblTitle);
            this.panelRegister.Controls.Add(this.lblLogin);
            this.panelRegister.Controls.Add(this.linkLogin);
            this.panelRegister.Controls.Add(this.Registerbtn);
            this.panelRegister.Location = new System.Drawing.Point(220, 30);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(380, 450);
            this.panelRegister.TabIndex = 0;
            // 
            // panelEmailBorder
            // 
            this.panelEmailBorder.BackColor = System.Drawing.Color.White;
            this.panelEmailBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEmailBorder.Controls.Add(this.txtBoxEmail);
            this.panelEmailBorder.Location = new System.Drawing.Point(30, 230);
            this.panelEmailBorder.Name = "panelEmailBorder";
            this.panelEmailBorder.Size = new System.Drawing.Size(320, 42);
            this.panelEmailBorder.TabIndex = 2;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BackColor = System.Drawing.Color.White;
            this.txtBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtBoxEmail.Location = new System.Drawing.Point(12, 10);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(296, 20);
            this.txtBoxEmail.TabIndex = 2;
            this.txtBoxEmail.Text = "Email";
            this.txtBoxEmail.Enter += new System.EventHandler(this.txtBoxEmail_Enter);
            this.txtBoxEmail.Leave += new System.EventHandler(this.txtBoxEmail_Leave);
            // 
            // panelPasswordBorder
            // 
            this.panelPasswordBorder.BackColor = System.Drawing.Color.White;
            this.panelPasswordBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPasswordBorder.Controls.Add(this.txtBoxPassword);
            this.panelPasswordBorder.Location = new System.Drawing.Point(30, 175);
            this.panelPasswordBorder.Name = "panelPasswordBorder";
            this.panelPasswordBorder.Size = new System.Drawing.Size(320, 42);
            this.panelPasswordBorder.TabIndex = 1;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.White;
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtBoxPassword.Location = new System.Drawing.Point(12, 10);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(296, 20);
            this.txtBoxPassword.TabIndex = 1;
            this.txtBoxPassword.Text = "Password";
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            this.txtBoxPassword.Enter += new System.EventHandler(this.txtBoxPassword_Enter);
            this.txtBoxPassword.Leave += new System.EventHandler(this.txtBoxPassword_Leave);
            // 
            // panelUsernameBorder
            // 
            this.panelUsernameBorder.BackColor = System.Drawing.Color.White;
            this.panelUsernameBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsernameBorder.Controls.Add(this.txtBoxUsername);
            this.panelUsernameBorder.Location = new System.Drawing.Point(30, 120);
            this.panelUsernameBorder.Name = "panelUsernameBorder";
            this.panelUsernameBorder.Size = new System.Drawing.Size(320, 42);
            this.panelUsernameBorder.TabIndex = 0;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BackColor = System.Drawing.Color.White;
            this.txtBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtBoxUsername.Location = new System.Drawing.Point(12, 10);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(296, 20);
            this.txtBoxUsername.TabIndex = 0;
            this.txtBoxUsername.Text = "Username";
            this.txtBoxUsername.Enter += new System.EventHandler(this.txtBoxUsername_Enter);
            this.txtBoxUsername.Leave += new System.EventHandler(this.txtBoxUsername_Leave);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblSubtitle.Location = new System.Drawing.Point(85, 77);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(212, 17);
            this.lblSubtitle.TabIndex = 7;
            this.lblSubtitle.Text = "Create Your Account to Get Started";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitle.Location = new System.Drawing.Point(101, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 47);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "REGISTER";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblLogin.Location = new System.Drawing.Point(85, 405);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(142, 15);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Already have an account?";
            // 
            // linkLogin
            // 
            this.linkLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.linkLogin.Location = new System.Drawing.Point(235, 405);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(66, 15);
            this.linkLogin.TabIndex = 4;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Login here";
            this.linkLogin.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // Registerbtn
            // 
            this.Registerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Registerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registerbtn.FlatAppearance.BorderSize = 0;
            this.Registerbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registerbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerbtn.ForeColor = System.Drawing.Color.White;
            this.Registerbtn.Location = new System.Drawing.Point(30, 295);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(320, 45);
            this.Registerbtn.TabIndex = 3;
            this.Registerbtn.Text = "REGISTER";
            this.Registerbtn.UseVisualStyleBackColor = false;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 510);
            this.Controls.Add(this.panelRegister);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horizon - Register";
            this.Load += new System.EventHandler(this.RegisterPage_Load);
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.panelEmailBorder.ResumeLayout(false);
            this.panelEmailBorder.PerformLayout();
            this.panelPasswordBorder.ResumeLayout(false);
            this.panelPasswordBorder.PerformLayout();
            this.panelUsernameBorder.ResumeLayout(false);
            this.panelUsernameBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Panel panelEmailBorder;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Panel panelPasswordBorder;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Panel panelUsernameBorder;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.Button Registerbtn;
    }
}
