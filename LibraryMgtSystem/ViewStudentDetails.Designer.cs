namespace LibraryMgtSystem
{
    partial class ViewStudentDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentDetails));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtSearchEnrollment = new TextBox();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtEmail = new TextBox();
            txtConNo = new TextBox();
            txtSemester = new TextBox();
            txtDepartment = new TextBox();
            txtEnNo = new TextBox();
            txtStName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 140);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(564, 66);
            label2.Name = "label2";
            label2.Size = new Size(95, 24);
            label2.TabIndex = 2;
            label2.Text = "Students";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(533, 42);
            label1.Name = "label1";
            label1.Size = new Size(54, 24);
            label1.TabIndex = 1;
            label1.Text = "View";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(357, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(230, 148);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 1;
            label3.Text = "Enrollment No.";
            // 
            // txtSearchEnrollment
            // 
            txtSearchEnrollment.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchEnrollment.Location = new Point(357, 145);
            txtSearchEnrollment.Name = "txtSearchEnrollment";
            txtSearchEnrollment.Size = new Size(201, 25);
            txtSearchEnrollment.TabIndex = 2;
            txtSearchEnrollment.TextChanged += txtSearchEnrollment_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(578, 143);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(967, 254);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtConNo);
            panel2.Controls.Add(txtSemester);
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(txtEnNo);
            panel2.Controls.Add(txtStName);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 443);
            panel2.Name = "panel2";
            panel2.Size = new Size(967, 274);
            panel2.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial", 9F);
            btnCancel.Location = new Point(784, 205);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Arial", 9F);
            btnDelete.Location = new Point(660, 205);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(538, 205);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(650, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtConNo
            // 
            txtConNo.Location = new Point(650, 84);
            txtConNo.Name = "txtConNo";
            txtConNo.Size = new Size(232, 27);
            txtConNo.TabIndex = 10;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(650, 32);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(232, 27);
            txtSemester.TabIndex = 9;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(182, 138);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(232, 27);
            txtDepartment.TabIndex = 8;
            // 
            // txtEnNo
            // 
            txtEnNo.Location = new Point(182, 86);
            txtEnNo.Name = "txtEnNo";
            txtEnNo.Size = new Size(232, 27);
            txtEnNo.TabIndex = 7;
            // 
            // txtStName
            // 
            txtStName.Location = new Point(182, 32);
            txtStName.Name = "txtStName";
            txtStName.Size = new Size(232, 27);
            txtStName.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9F);
            label9.Location = new Point(537, 142);
            label9.Name = "label9";
            label9.Size = new Size(45, 17);
            label9.TabIndex = 5;
            label9.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F);
            label8.Location = new Point(537, 86);
            label8.Name = "label8";
            label8.Size = new Size(85, 17);
            label8.TabIndex = 4;
            label8.Text = "Contact No.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F);
            label7.Location = new Point(537, 32);
            label7.Name = "label7";
            label7.Size = new Size(72, 17);
            label7.TabIndex = 3;
            label7.Text = "Semester";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F);
            label6.Location = new Point(73, 142);
            label6.Name = "label6";
            label6.Size = new Size(85, 17);
            label6.TabIndex = 2;
            label6.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F);
            label5.Location = new Point(73, 86);
            label5.Name = "label5";
            label5.Size = new Size(104, 17);
            label5.TabIndex = 1;
            label5.Text = "Enrollment No.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F);
            label4.Location = new Point(73, 32);
            label4.Name = "label4";
            label4.Size = new Size(101, 17);
            label4.TabIndex = 0;
            label4.Text = "Student Name";
            // 
            // ViewStudentDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(968, 469);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearchEnrollment);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "ViewStudentDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStudentDetails";
            Load += ViewStudentDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtSearchEnrollment;
        private Button btnRefresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtEmail;
        private TextBox txtConNo;
        private TextBox txtSemester;
        private TextBox txtDepartment;
        private TextBox txtEnNo;
        private TextBox txtStName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}