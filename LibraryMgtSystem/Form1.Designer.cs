namespace LibraryMgtSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btnLogin = new Button();
            btnSignUp = new Button();
            pictureBoxInstagram = new PictureBox();
            pictureBoxFacebook = new PictureBox();
            pictureBoxYoutube = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInstagram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFacebook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYoutube).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(132, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(54, 152);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(54, 220);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(224, 224, 224);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(116, 161);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 20);
            txtUsername.TabIndex = 3;
            txtUsername.Text = "Username";
            txtUsername.MouseClick += txtUsername_MouseClick;
            txtUsername.MouseEnter += txtUsername_MouseEnter;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(224, 224, 224);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(116, 228);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 20);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "Password";
            txtPassword.MouseClick += txtPassword_MouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(116, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 1);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(116, 257);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 1);
            panel2.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(54, 300);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(262, 40);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Gray;
            btnSignUp.FlatStyle = FlatStyle.Popup;
            btnSignUp.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(54, 354);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(262, 40);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // pictureBoxInstagram
            // 
            pictureBoxInstagram.Image = (Image)resources.GetObject("pictureBoxInstagram.Image");
            pictureBoxInstagram.Location = new Point(65, 466);
            pictureBoxInstagram.Name = "pictureBoxInstagram";
            pictureBoxInstagram.Size = new Size(48, 45);
            pictureBoxInstagram.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxInstagram.TabIndex = 9;
            pictureBoxInstagram.TabStop = false;
            // 
            // pictureBoxFacebook
            // 
            pictureBoxFacebook.Image = (Image)resources.GetObject("pictureBoxFacebook.Image");
            pictureBoxFacebook.Location = new Point(154, 466);
            pictureBoxFacebook.Name = "pictureBoxFacebook";
            pictureBoxFacebook.Size = new Size(48, 45);
            pictureBoxFacebook.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFacebook.TabIndex = 10;
            pictureBoxFacebook.TabStop = false;
            // 
            // pictureBoxYoutube
            // 
            pictureBoxYoutube.Image = (Image)resources.GetObject("pictureBoxYoutube.Image");
            pictureBoxYoutube.Location = new Point(248, 466);
            pictureBoxYoutube.Name = "pictureBoxYoutube";
            pictureBoxYoutube.Size = new Size(48, 45);
            pictureBoxYoutube.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxYoutube.TabIndex = 11;
            pictureBoxYoutube.TabStop = false;
            pictureBoxYoutube.Click += pictureBoxYoutube_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(224, 224, 224);
            btnClose.FlatStyle = FlatStyle.System;
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(338, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(26, 26);
            btnClose.TabIndex = 12;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(368, 544);
            Controls.Add(btnClose);
            Controls.Add(pictureBoxYoutube);
            Controls.Add(pictureBoxFacebook);
            Controls.Add(pictureBoxInstagram);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInstagram).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFacebook).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYoutube).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Panel panel1;
        private Panel panel2;
        private Button btnLogin;
        private Button btnSignUp;
        private PictureBox pictureBoxInstagram;
        private PictureBox pictureBoxFacebook;
        private PictureBox pictureBoxYoutube;
        private Button btnClose;
    }
}
