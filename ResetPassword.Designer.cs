﻿namespace Hospital_Management_System
{
    partial class ResetPassword
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
            this.picPasswordStrength = new System.Windows.Forms.PictureBox();
            this.picButtonReturnToLogin = new System.Windows.Forms.PictureBox();
            this.lblPasswordStrength = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picButtonRequestReset = new System.Windows.Forms.PictureBox();
            this.lblCharacterLimitWarning = new System.Windows.Forms.Label();
            this.txtBoxPasswordInput = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblResetPasswordTitle = new System.Windows.Forms.Label();
            this.txtBoxUsernameInput = new System.Windows.Forms.TextBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.timerCheckPasswordLength = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonReturnToLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonRequestReset)).BeginInit();
            this.SuspendLayout();
            // 
            // picPasswordStrength
            // 
            this.picPasswordStrength.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPasswordStrength.Image = global::Hospital_Management_System.Properties.Resources.WeakPassword;
            this.picPasswordStrength.Location = new System.Drawing.Point(83, 221);
            this.picPasswordStrength.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picPasswordStrength.Name = "picPasswordStrength";
            this.picPasswordStrength.Size = new System.Drawing.Size(301, 21);
            this.picPasswordStrength.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPasswordStrength.TabIndex = 35;
            this.picPasswordStrength.TabStop = false;
            // 
            // picButtonReturnToLogin
            // 
            this.picButtonReturnToLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picButtonReturnToLogin.BackColor = System.Drawing.Color.Transparent;
            this.picButtonReturnToLogin.Image = global::Hospital_Management_System.Properties.Resources.ReturnToLoginButton;
            this.picButtonReturnToLogin.Location = new System.Drawing.Point(155, 313);
            this.picButtonReturnToLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picButtonReturnToLogin.Name = "picButtonReturnToLogin";
            this.picButtonReturnToLogin.Size = new System.Drawing.Size(156, 41);
            this.picButtonReturnToLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picButtonReturnToLogin.TabIndex = 34;
            this.picButtonReturnToLogin.TabStop = false;
            this.picButtonReturnToLogin.Click += new System.EventHandler(this.picButtonReturnToLogin_Click);
            // 
            // lblPasswordStrength
            // 
            this.lblPasswordStrength.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPasswordStrength.AutoSize = true;
            this.lblPasswordStrength.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordStrength.Location = new System.Drawing.Point(128, 195);
            this.lblPasswordStrength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordStrength.Name = "lblPasswordStrength";
            this.lblPasswordStrength.Size = new System.Drawing.Size(210, 21);
            this.lblPasswordStrength.TabIndex = 33;
            this.lblPasswordStrength.Text = "Password Strength - To Weak";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(59, 122);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 21);
            this.lblPassword.TabIndex = 32;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(55, 63);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 21);
            this.lblUsername.TabIndex = 31;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picButtonRequestReset
            // 
            this.picButtonRequestReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picButtonRequestReset.BackColor = System.Drawing.Color.LightSteelBlue;
            this.picButtonRequestReset.Image = global::Hospital_Management_System.Properties.Resources.ResetRequestButton;
            this.picButtonRequestReset.Location = new System.Drawing.Point(142, 252);
            this.picButtonRequestReset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picButtonRequestReset.Name = "picButtonRequestReset";
            this.picButtonRequestReset.Size = new System.Drawing.Size(183, 44);
            this.picButtonRequestReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picButtonRequestReset.TabIndex = 30;
            this.picButtonRequestReset.TabStop = false;
            this.picButtonRequestReset.Click += new System.EventHandler(this.picButtonRequestReset_Click);
            // 
            // lblCharacterLimitWarning
            // 
            this.lblCharacterLimitWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharacterLimitWarning.AutoSize = true;
            this.lblCharacterLimitWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblCharacterLimitWarning.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCharacterLimitWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblCharacterLimitWarning.Location = new System.Drawing.Point(120, 150);
            this.lblCharacterLimitWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCharacterLimitWarning.Name = "lblCharacterLimitWarning";
            this.lblCharacterLimitWarning.Size = new System.Drawing.Size(226, 38);
            this.lblCharacterLimitWarning.TabIndex = 29;
            this.lblCharacterLimitWarning.Text = "Should be atleast 8 characters long,\r\nbut no longer then 24 characters";
            this.lblCharacterLimitWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxPasswordInput
            // 
            this.txtBoxPasswordInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPasswordInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPasswordInput.Location = new System.Drawing.Point(151, 119);
            this.txtBoxPasswordInput.Margin = new System.Windows.Forms.Padding(0, 3, 2, 3);
            this.txtBoxPasswordInput.MaxLength = 24;
            this.txtBoxPasswordInput.Name = "txtBoxPasswordInput";
            this.txtBoxPasswordInput.PlaceholderText = "Enter password";
            this.txtBoxPasswordInput.Size = new System.Drawing.Size(270, 29);
            this.txtBoxPasswordInput.TabIndex = 28;
            this.txtBoxPasswordInput.UseSystemPasswordChar = true;
            this.txtBoxPasswordInput.WordWrap = false;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPassword.BackColor = System.Drawing.Color.White;
            this.txtBoxPassword.Enabled = false;
            this.txtBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPassword.Location = new System.Drawing.Point(45, 119);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(2, 3, 0, 3);
            this.txtBoxPassword.MaxLength = 0;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.ReadOnly = true;
            this.txtBoxPassword.Size = new System.Drawing.Size(107, 29);
            this.txtBoxPassword.TabIndex = 27;
            this.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResetPasswordTitle
            // 
            this.lblResetPasswordTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResetPasswordTitle.AutoSize = true;
            this.lblResetPasswordTitle.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblResetPasswordTitle.Location = new System.Drawing.Point(125, 7);
            this.lblResetPasswordTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResetPasswordTitle.Name = "lblResetPasswordTitle";
            this.lblResetPasswordTitle.Size = new System.Drawing.Size(216, 37);
            this.lblResetPasswordTitle.TabIndex = 26;
            this.lblResetPasswordTitle.Text = "Reset Password";
            // 
            // txtBoxUsernameInput
            // 
            this.txtBoxUsernameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxUsernameInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxUsernameInput.Location = new System.Drawing.Point(151, 60);
            this.txtBoxUsernameInput.Margin = new System.Windows.Forms.Padding(0, 3, 2, 3);
            this.txtBoxUsernameInput.MaxLength = 20;
            this.txtBoxUsernameInput.Name = "txtBoxUsernameInput";
            this.txtBoxUsernameInput.PlaceholderText = "Enter username";
            this.txtBoxUsernameInput.Size = new System.Drawing.Size(270, 29);
            this.txtBoxUsernameInput.TabIndex = 25;
            this.txtBoxUsernameInput.WordWrap = false;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxUsername.BackColor = System.Drawing.Color.White;
            this.txtboxUsername.Enabled = false;
            this.txtboxUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtboxUsername.Location = new System.Drawing.Point(45, 60);
            this.txtboxUsername.Margin = new System.Windows.Forms.Padding(2, 3, 0, 3);
            this.txtboxUsername.MaxLength = 0;
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.ReadOnly = true;
            this.txtboxUsername.Size = new System.Drawing.Size(107, 29);
            this.txtboxUsername.TabIndex = 24;
            this.txtboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerCheckPasswordLength
            // 
            this.timerCheckPasswordLength.Enabled = true;
            this.timerCheckPasswordLength.Interval = 200;
            this.timerCheckPasswordLength.Tick += new System.EventHandler(this.checkPassword);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(466, 362);
            this.Controls.Add(this.picPasswordStrength);
            this.Controls.Add(this.picButtonReturnToLogin);
            this.Controls.Add(this.lblPasswordStrength);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.picButtonRequestReset);
            this.Controls.Add(this.lblCharacterLimitWarning);
            this.Controls.Add(this.txtBoxPasswordInput);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblResetPasswordTitle);
            this.Controls.Add(this.txtBoxUsernameInput);
            this.Controls.Add(this.txtboxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonReturnToLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonRequestReset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picPasswordStrength;
        private PictureBox picButtonReturnToLogin;
        private Label lblPasswordStrength;
        private Label lblPassword;
        private Label lblUsername;
        private PictureBox picButtonRequestReset;
        private Label lblCharacterLimitWarning;
        private TextBox txtBoxPasswordInput;
        private TextBox txtBoxPassword;
        private Label lblResetPasswordTitle;
        private TextBox txtBoxUsernameInput;
        private TextBox txtboxUsername;
        private System.Windows.Forms.Timer timerCheckPasswordLength;
    }
}