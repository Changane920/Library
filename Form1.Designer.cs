namespace Library
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pboProfile = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtLoginUserName = new System.Windows.Forms.TextBox();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.loginTimer = new System.Windows.Forms.Timer(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.lblLoginUserName = new System.Windows.Forms.Label();
            this.lblLoginPass = new System.Windows.Forms.Label();
            this.signuppanel = new System.Windows.Forms.Panel();
            this.lblCheckPass = new System.Windows.Forms.Label();
            this.txtCheckPass = new System.Windows.Forms.TextBox();
            this.lblPhNo = new System.Windows.Forms.Label();
            this.signuploginbtn = new System.Windows.Forms.Button();
            this.signupcreateaccbtn = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboProfile)).BeginInit();
            this.signuppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pboProfile
            // 
            this.pboProfile.Image = ((System.Drawing.Image)(resources.GetObject("pboProfile.Image")));
            this.pboProfile.Location = new System.Drawing.Point(202, 11);
            this.pboProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pboProfile.Name = "pboProfile";
            this.pboProfile.Size = new System.Drawing.Size(156, 133);
            this.pboProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboProfile.TabIndex = 0;
            this.pboProfile.TabStop = false;
            // 
            // txtLoginUserName
            // 
            this.txtLoginUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtLoginUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginUserName.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUserName.ForeColor = System.Drawing.Color.White;
            this.txtLoginUserName.Location = new System.Drawing.Point(244, 178);
            this.txtLoginUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.Size = new System.Drawing.Size(171, 21);
            this.txtLoginUserName.TabIndex = 1;
            this.txtLoginUserName.Text = "Username";
            this.txtLoginUserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUsername_MouseClick);
            this.txtLoginUserName.MouseEnter += new System.EventHandler(this.txtUsername_MouseEnter);
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtLoginPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginPass.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPass.ForeColor = System.Drawing.Color.White;
            this.txtLoginPass.Location = new System.Drawing.Point(246, 239);
            this.txtLoginPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.Size = new System.Drawing.Size(171, 21);
            this.txtLoginPass.TabIndex = 2;
            this.txtLoginPass.Text = "Password";
            this.txtLoginPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(246, 198);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(246, 261);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 1);
            this.panel2.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(195, 298);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(171, 27);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSignUp.Location = new System.Drawing.Point(195, 342);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(171, 30);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(531, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 29);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // loginTimer
            // 
            this.loginTimer.Tick += new System.EventHandler(this.loginTimer_Tick);
            // 
            // lblLoginUserName
            // 
            this.lblLoginUserName.AutoSize = true;
            this.lblLoginUserName.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUserName.ForeColor = System.Drawing.Color.White;
            this.lblLoginUserName.Location = new System.Drawing.Point(131, 177);
            this.lblLoginUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginUserName.Name = "lblLoginUserName";
            this.lblLoginUserName.Size = new System.Drawing.Size(91, 23);
            this.lblLoginUserName.TabIndex = 8;
            this.lblLoginUserName.Text = "Username";
            // 
            // lblLoginPass
            // 
            this.lblLoginPass.AutoSize = true;
            this.lblLoginPass.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPass.ForeColor = System.Drawing.Color.White;
            this.lblLoginPass.Location = new System.Drawing.Point(131, 239);
            this.lblLoginPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginPass.Name = "lblLoginPass";
            this.lblLoginPass.Size = new System.Drawing.Size(86, 23);
            this.lblLoginPass.TabIndex = 9;
            this.lblLoginPass.Text = "Password";
            // 
            // signuppanel
            // 
            this.signuppanel.Controls.Add(this.lblCheckPass);
            this.signuppanel.Controls.Add(this.txtCheckPass);
            this.signuppanel.Controls.Add(this.lblPhNo);
            this.signuppanel.Controls.Add(this.signuploginbtn);
            this.signuppanel.Controls.Add(this.signupcreateaccbtn);
            this.signuppanel.Controls.Add(this.lblPassword);
            this.signuppanel.Controls.Add(this.lblEmail);
            this.signuppanel.Controls.Add(this.lblUserName);
            this.signuppanel.Controls.Add(this.txtPass);
            this.signuppanel.Controls.Add(this.txtPhone);
            this.signuppanel.Controls.Add(this.txtEmail);
            this.signuppanel.Controls.Add(this.txtUserName);
            this.signuppanel.Location = new System.Drawing.Point(74, 148);
            this.signuppanel.Margin = new System.Windows.Forms.Padding(2);
            this.signuppanel.Name = "signuppanel";
            this.signuppanel.Size = new System.Drawing.Size(408, 299);
            this.signuppanel.TabIndex = 11;
            // 
            // lblCheckPass
            // 
            this.lblCheckPass.AutoSize = true;
            this.lblCheckPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCheckPass.Location = new System.Drawing.Point(51, 185);
            this.lblCheckPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckPass.Name = "lblCheckPass";
            this.lblCheckPass.Size = new System.Drawing.Size(108, 18);
            this.lblCheckPass.TabIndex = 12;
            this.lblCheckPass.Text = "Re-password";
            // 
            // txtCheckPass
            // 
            this.txtCheckPass.Location = new System.Drawing.Point(181, 184);
            this.txtCheckPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtCheckPass.Name = "txtCheckPass";
            this.txtCheckPass.Size = new System.Drawing.Size(171, 22);
            this.txtCheckPass.TabIndex = 4;
            // 
            // lblPhNo
            // 
            this.lblPhNo.AutoSize = true;
            this.lblPhNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPhNo.Location = new System.Drawing.Point(51, 105);
            this.lblPhNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhNo.Name = "lblPhNo";
            this.lblPhNo.Size = new System.Drawing.Size(56, 18);
            this.lblPhNo.TabIndex = 10;
            this.lblPhNo.Text = "Phone";
            // 
            // signuploginbtn
            // 
            this.signuploginbtn.BackColor = System.Drawing.Color.Black;
            this.signuploginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signuploginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signuploginbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.signuploginbtn.Location = new System.Drawing.Point(259, 231);
            this.signuploginbtn.Margin = new System.Windows.Forms.Padding(2);
            this.signuploginbtn.Name = "signuploginbtn";
            this.signuploginbtn.Size = new System.Drawing.Size(93, 33);
            this.signuploginbtn.TabIndex = 6;
            this.signuploginbtn.Text = "Login";
            this.signuploginbtn.UseVisualStyleBackColor = false;
            this.signuploginbtn.Click += new System.EventHandler(this.signuploginbtn_Click_1);
            // 
            // signupcreateaccbtn
            // 
            this.signupcreateaccbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.signupcreateaccbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signupcreateaccbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupcreateaccbtn.Location = new System.Drawing.Point(53, 231);
            this.signupcreateaccbtn.Margin = new System.Windows.Forms.Padding(2);
            this.signupcreateaccbtn.Name = "signupcreateaccbtn";
            this.signupcreateaccbtn.Size = new System.Drawing.Size(135, 35);
            this.signupcreateaccbtn.TabIndex = 5;
            this.signupcreateaccbtn.Text = "Create Account";
            this.signupcreateaccbtn.UseVisualStyleBackColor = false;
            this.signupcreateaccbtn.Click += new System.EventHandler(this.signupcreateaccbtn_Click_1);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassword.Location = new System.Drawing.Point(51, 145);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 18);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.Location = new System.Drawing.Point(51, 65);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 18);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUserName.Location = new System.Drawing.Point(51, 25);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(52, 18);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Name";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(181, 144);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(171, 22);
            this.txtPass.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(181, 104);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(171, 22);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(181, 64);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(181, 24);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(171, 22);
            this.txtUserName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(561, 458);
            this.Controls.Add(this.signuppanel);
            this.Controls.Add(this.lblLoginPass);
            this.Controls.Add(this.lblLoginUserName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtLoginPass);
            this.Controls.Add(this.txtLoginUserName);
            this.Controls.Add(this.pboProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboProfile)).EndInit();
            this.signuppanel.ResumeLayout(false);
            this.signuppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboProfile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtLoginUserName;
        private System.Windows.Forms.TextBox txtLoginPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer loginTimer;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label lblLoginUserName;
        private System.Windows.Forms.Label lblLoginPass;
        private System.Windows.Forms.Panel signuppanel;
        private System.Windows.Forms.Button signuploginbtn;
        private System.Windows.Forms.Button signupcreateaccbtn;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPhNo;
        private System.Windows.Forms.Label lblCheckPass;
        private System.Windows.Forms.TextBox txtCheckPass;
    }
}

