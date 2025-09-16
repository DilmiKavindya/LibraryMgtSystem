namespace LibraryMgtSystem
{
    partial class ReturnBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBooks));
            panel1 = new Panel();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearchStudent = new Button();
            txtEnrollment = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnCancel = new Button();
            btnReturn = new Button();
            txtBIssueDate = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtBookName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnSearchStudent);
            panel1.Controls.Add(txtEnrollment);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 568);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Arial", 9F);
            btnExit.Location = new Point(184, 304);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Arial", 9F);
            btnRefresh.Location = new Point(21, 304);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.FlatStyle = FlatStyle.Popup;
            btnSearchStudent.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchStudent.Location = new Point(68, 231);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(125, 29);
            btnSearchStudent.TabIndex = 3;
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Font = new Font("Arial", 9F);
            txtEnrollment.Location = new Point(55, 163);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(168, 25);
            txtEnrollment.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.Location = new Point(68, 130);
            label1.Name = "label1";
            label1.Size = new Size(143, 17);
            label1.TabIndex = 1;
            label1.Text = "Enter Enrollment No.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(305, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1202, 421);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnReturn);
            panel2.Controls.Add(txtBIssueDate);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(305, 425);
            panel2.Name = "panel2";
            panel2.Size = new Size(1202, 145);
            panel2.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial", 9F);
            btnCancel.Location = new Point(731, 94);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.Font = new Font("Arial", 9F);
            btnReturn.Location = new Point(731, 53);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // txtBIssueDate
            // 
            txtBIssueDate.Location = new Point(394, 55);
            txtBIssueDate.Name = "txtBIssueDate";
            txtBIssueDate.Size = new Size(250, 27);
            txtBIssueDate.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(394, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(394, 15);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(250, 27);
            txtBookName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F);
            label4.Location = new Point(233, 97);
            label4.Name = "label4";
            label4.Size = new Size(124, 17);
            label4.TabIndex = 2;
            label4.Text = "Book Return Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F);
            label3.Location = new Point(233, 55);
            label3.Name = "label3";
            label3.Size = new Size(115, 17);
            label3.TabIndex = 1;
            label3.Text = "Book Issue Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F);
            label2.Location = new Point(233, 15);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            // 
            // ReturnBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1485, 454);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ReturnBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBooks";
            Load += ReturnBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtEnrollment;
        private Button btnSearchStudent;
        private Button btnExit;
        private Button btnRefresh;
        private TextBox txtBIssueDate;
        private DateTimePicker dateTimePicker1;
        private TextBox txtBookName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancel;
        private Button btnReturn;
    }
}