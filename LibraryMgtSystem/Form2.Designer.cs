namespace LibraryMgtSystem
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtCrPswd = new TextBox();
            txtConPswd = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 26);
            label1.Name = "label1";
            label1.Size = new Size(121, 33);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 123);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.DarkGray;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtUserName.Location = new Point(47, 196);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(257, 20);
            txtUserName.TabIndex = 2;
            txtUserName.Text = "Username";
            txtUserName.MouseClick += txtUserName_MouseClick;
            txtUserName.MouseEnter += txtUserName_MouseEnter;
            // 
            // txtCrPswd
            // 
            txtCrPswd.BackColor = Color.DarkGray;
            txtCrPswd.BorderStyle = BorderStyle.None;
            txtCrPswd.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtCrPswd.Location = new Point(45, 253);
            txtCrPswd.Name = "txtCrPswd";
            txtCrPswd.Size = new Size(257, 20);
            txtCrPswd.TabIndex = 3;
            txtCrPswd.Text = "Create Password";
            txtCrPswd.MouseClick += txtCrPswd_MouseClick;
            // 
            // txtConPswd
            // 
            txtConPswd.BackColor = Color.DarkGray;
            txtConPswd.BorderStyle = BorderStyle.None;
            txtConPswd.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtConPswd.Location = new Point(45, 312);
            txtConPswd.Name = "txtConPswd";
            txtConPswd.Size = new Size(257, 20);
            txtConPswd.TabIndex = 4;
            txtConPswd.Text = "Confirm Password";
            txtConPswd.MouseClick += txtConPswd_MouseClick;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(45, 401);
            button1.Name = "button1";
            button1.Size = new Size(257, 40);
            button1.TabIndex = 5;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(320, 4);
            button2.Name = "button2";
            button2.Size = new Size(26, 26);
            button2.TabIndex = 6;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(45, 226);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 2);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(45, 286);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 2);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(45, 345);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 2);
            panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(112, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(350, 497);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtConPswd);
            Controls.Add(txtCrPswd);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtCrPswd;
        private TextBox txtConPswd;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}