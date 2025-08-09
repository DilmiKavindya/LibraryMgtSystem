namespace LibraryMgtSystem
{
    partial class AddBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooks));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtPublication = new TextBox();
            txtAuthor = new TextBox();
            txtBookName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 344);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(674, 77);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(361, 27);
            label2.Name = "label2";
            label2.Size = new Size(102, 24);
            label2.TabIndex = 1;
            label2.Text = "Add Book";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(368, 25);
            label1.Name = "label1";
            label1.Size = new Size(102, 24);
            label1.TabIndex = 1;
            label1.Text = "Add Book";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(234, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtPublication);
            panel2.Controls.Add(txtAuthor);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(238, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 348);
            panel2.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(338, 302);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(215, 302);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(187, 171);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(245, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(187, 258);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(245, 27);
            txtQuantity.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(187, 212);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(245, 27);
            txtPrice.TabIndex = 9;
            // 
            // txtPublication
            // 
            txtPublication.Location = new Point(187, 129);
            txtPublication.Name = "txtPublication";
            txtPublication.Size = new Size(245, 27);
            txtPublication.TabIndex = 8;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(187, 83);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(245, 27);
            txtAuthor.TabIndex = 7;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(187, 36);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(245, 27);
            txtBookName.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(27, 263);
            label8.Name = "label8";
            label8.Size = new Size(99, 17);
            label8.TabIndex = 5;
            label8.Text = "Book Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 222);
            label7.Name = "label7";
            label7.Size = new Size(79, 17);
            label7.TabIndex = 4;
            label7.Text = "Book Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 178);
            label6.Name = "label6";
            label6.Size = new Size(143, 17);
            label6.TabIndex = 3;
            label6.Text = "Book Purchase Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 134);
            label5.Name = "label5";
            label5.Size = new Size(116, 17);
            label5.TabIndex = 2;
            label5.Text = "Book Publication";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 88);
            label4.Name = "label4";
            label4.Size = new Size(129, 17);
            label4.TabIndex = 1;
            label4.Text = "Book Author Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 41);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 0;
            label3.Text = "Book Name";
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 420);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "AddBooks";
            Text = "AddBooks";
            Load += AddBooks_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtPublication;
        private TextBox txtAuthor;
        private TextBox txtBookName;
        private Button btnCancel;
        private Button btnSave;
    }
}