namespace LibraryMgtSystem
{
    partial class IssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooks));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearchStudent = new Button();
            txtEnrollment = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label10 = new Label();
            btnIssueBook = new Button();
            dateTimePicker = new DateTimePicker();
            comboBoxBooks = new ComboBox();
            txtEmail = new TextBox();
            txtConNo = new TextBox();
            txtSemester = new TextBox();
            txtDepartment = new TextBox();
            txtStName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 115);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(397, 46);
            label1.Name = "label1";
            label1.Size = new Size(126, 24);
            label1.TabIndex = 1;
            label1.Text = "Issue Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(208, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnSearchStudent);
            panel2.Controls.Add(txtEnrollment);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(1, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 383);
            panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Arial", 9F);
            btnExit.Location = new Point(167, 278);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(71, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Arial", 9F);
            btnRefresh.Location = new Point(12, 278);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(71, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.FlatStyle = FlatStyle.Popup;
            btnSearchStudent.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchStudent.Location = new Point(56, 216);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(125, 29);
            btnSearchStudent.TabIndex = 3;
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(56, 137);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(125, 27);
            txtEnrollment.TabIndex = 2;
            txtEnrollment.TextChanged += txtEnrollment_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 107);
            label2.Name = "label2";
            label2.Size = new Size(143, 17);
            label2.TabIndex = 1;
            label2.Text = "Enter Enrollment No.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(75, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(btnIssueBook);
            panel3.Controls.Add(dateTimePicker);
            panel3.Controls.Add(comboBoxBooks);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtConNo);
            panel3.Controls.Add(txtSemester);
            panel3.Controls.Add(txtDepartment);
            panel3.Controls.Add(txtStName);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(258, 122);
            panel3.Name = "panel3";
            panel3.Size = new Size(423, 383);
            panel3.TabIndex = 2;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(55, 359);
            label10.Name = "label10";
            label10.Size = new Size(355, 18);
            label10.TabIndex = 15;
            label10.Text = "Maximum 3 Books Can  be ISSUED to 1 Student   ";
            // 
            // btnIssueBook
            // 
            btnIssueBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIssueBook.FlatStyle = FlatStyle.Popup;
            btnIssueBook.Font = new Font("Arial", 9F);
            btnIssueBook.Location = new Point(296, 316);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(94, 29);
            btnIssueBook.TabIndex = 14;
            btnIssueBook.Text = "Issue Book";
            btnIssueBook.UseVisualStyleBackColor = true;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker.Location = new Point(159, 270);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(231, 27);
            dateTimePicker.TabIndex = 13;
            // 
            // comboBoxBooks
            // 
            comboBoxBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxBooks.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBooks.FormattingEnabled = true;
            comboBoxBooks.Location = new Point(159, 228);
            comboBoxBooks.Name = "comboBoxBooks";
            comboBoxBooks.Size = new Size(231, 28);
            comboBoxBooks.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(159, 186);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(231, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtConNo
            // 
            txtConNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtConNo.Location = new Point(159, 143);
            txtConNo.Name = "txtConNo";
            txtConNo.ReadOnly = true;
            txtConNo.Size = new Size(231, 27);
            txtConNo.TabIndex = 10;
            // 
            // txtSemester
            // 
            txtSemester.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSemester.Location = new Point(159, 99);
            txtSemester.Name = "txtSemester";
            txtSemester.ReadOnly = true;
            txtSemester.Size = new Size(231, 27);
            txtSemester.TabIndex = 9;
            // 
            // txtDepartment
            // 
            txtDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDepartment.Location = new Point(159, 56);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.ReadOnly = true;
            txtDepartment.Size = new Size(231, 27);
            txtDepartment.TabIndex = 8;
            // 
            // txtStName
            // 
            txtStName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtStName.Location = new Point(159, 13);
            txtStName.Name = "txtStName";
            txtStName.ReadOnly = true;
            txtStName.Size = new Size(231, 27);
            txtStName.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9F);
            label9.Location = new Point(27, 276);
            label9.Name = "label9";
            label9.Size = new Size(115, 17);
            label9.TabIndex = 6;
            label9.Text = "Book Issue Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F);
            label8.Location = new Point(27, 234);
            label8.Name = "label8";
            label8.Size = new Size(84, 17);
            label8.TabIndex = 5;
            label8.Text = "Book Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F);
            label7.Location = new Point(27, 192);
            label7.Name = "label7";
            label7.Size = new Size(45, 17);
            label7.TabIndex = 4;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F);
            label6.Location = new Point(27, 149);
            label6.Name = "label6";
            label6.Size = new Size(85, 17);
            label6.TabIndex = 3;
            label6.Text = "Contact No.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F);
            label5.Location = new Point(27, 107);
            label5.Name = "label5";
            label5.Size = new Size(72, 17);
            label5.TabIndex = 2;
            label5.Text = "Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F);
            label4.Location = new Point(27, 62);
            label4.Name = "label4";
            label4.Size = new Size(85, 17);
            label4.TabIndex = 1;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 17);
            label3.Name = "label3";
            label3.Size = new Size(101, 17);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(682, 504);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IssueBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IssueBooks";
            Load += IssueBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Button btnExit;
        private Button btnRefresh;
        private Button btnSearchStudent;
        private TextBox txtEnrollment;
        private Panel panel3;
        private TextBox txtStName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnIssueBook;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxBooks;
        private TextBox txtEmail;
        private TextBox txtConNo;
        private TextBox txtSemester;
        private TextBox txtDepartment;
        private Label label10;
    }
}