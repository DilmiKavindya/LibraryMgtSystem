namespace LibraryMgtSystem
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            txtEmail = new TextBox();
            label7 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            btnRefresh = new Button();
            txtContact = new TextBox();
            txtSemester = new TextBox();
            txtDepartment = new TextBox();
            txtEnrollment = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 97);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(382, 39);
            label1.Name = "label1";
            label1.Size = new Size(138, 24);
            label1.TabIndex = 2;
            label1.Text = "Add Students";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(267, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(268, 323);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtSemester);
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(txtEnrollment);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(267, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 323);
            panel2.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(163, 219);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(215, 27);
            txtEmail.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F);
            label7.Location = new Point(17, 229);
            label7.Name = "label7";
            label7.Size = new Size(45, 17);
            label7.TabIndex = 13;
            label7.Text = "Email";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial", 9F);
            btnCancel.Location = new Point(298, 281);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Arial", 9F);
            btnSave.Location = new Point(185, 281);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Arial", 9F);
            btnRefresh.Location = new Point(72, 281);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtContact
            // 
            txtContact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContact.Location = new Point(163, 180);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(215, 27);
            txtContact.TabIndex = 9;
            // 
            // txtSemester
            // 
            txtSemester.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSemester.Location = new Point(163, 140);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(215, 27);
            txtSemester.TabIndex = 8;
            // 
            // txtDepartment
            // 
            txtDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDepartment.Location = new Point(163, 100);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(215, 27);
            txtDepartment.TabIndex = 7;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEnrollment.Location = new Point(163, 60);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(215, 27);
            txtEnrollment.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(163, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(215, 27);
            txtName.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F);
            label6.Location = new Point(17, 188);
            label6.Name = "label6";
            label6.Size = new Size(85, 17);
            label6.TabIndex = 4;
            label6.Text = "Contact No.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F);
            label5.Location = new Point(17, 147);
            label5.Name = "label5";
            label5.Size = new Size(126, 17);
            label5.TabIndex = 3;
            label5.Text = "Student Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F);
            label4.Location = new Point(17, 106);
            label4.Name = "label4";
            label4.Size = new Size(85, 17);
            label4.TabIndex = 2;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F);
            label3.Location = new Point(17, 68);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 1;
            label3.Text = "Enrollment No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F);
            label2.Location = new Point(17, 25);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 420);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private TextBox txtName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancel;
        private Button btnSave;
        private Button btnRefresh;
        private TextBox txtContact;
        private TextBox txtSemester;
        private TextBox txtDepartment;
        private TextBox txtEnrollment;
        private TextBox txtEmail;
        private Label label7;
    }
}