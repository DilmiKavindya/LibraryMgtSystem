using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LibraryMgtSystem
{
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();

            // CellFormatting event for date display
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DILMI-LAP\\MSSQLSERVER01; Initial Catalog=LMSDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;"))
            {
                string query = @" SELECT stName AS [Name], enroll AS [Enroll No], dep AS [Department], sem AS [Semester], contact AS [Contact], email AS [Email],  bookName AS [Book Name], bookIssueDate AS [Issued Date], 
                        CASE 
                            WHEN bookReturnDate IS NULL OR bookReturnDate = 'Not Returned' 
                            THEN 'Not Returned'
                            ELSE bookReturnDate 
                        END AS [Return Date]
                    FROM IRBook 
                    WHERE enroll = @enroll";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@enroll", txtEnrollment.Text.Trim());

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Invalid Enrollment or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtEnrollment.Clear();

            // Show only date in picker
            dateTimePicker1.Format = DateTimePickerFormat.Short;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                panel2.Visible = true;

                txtBookName.Text = row.Cells["Book Name"].Value.ToString();

                // Show only date in textBox
                if (DateTime.TryParse(row.Cells["Issued Date"].Value.ToString(), out DateTime issueDate))
                {
                    txtBIssueDate.Text = issueDate.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtBIssueDate.Text = row.Cells["Issued Date"].Value.ToString();
                }

                string returnDateStr = row.Cells["Return Date"].Value.ToString();
                if (returnDateStr != "Not Returned" && DateTime.TryParse(returnDateStr, out DateTime returnDate))
                {
                    dateTimePicker1.Value = returnDate;
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Now;
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookName.Text) || string.IsNullOrEmpty(txtEnrollment.Text))
            {
                MessageBox.Show("Please select a book to return.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=DILMI-LAP\\MSSQLSERVER01; Initial Catalog=LMSDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;"))
            {
                try
                {
                    con.Open();

                    // Update both cases: 'Not Returned' OR NULL
                    string query = @"UPDATE IRBook 
                                     SET bookReturnDate = @returnDate 
                                     WHERE enroll = @enroll 
                                       AND bookName = @bookName 
                                       AND (bookReturnDate = 'Not Returned' OR bookReturnDate IS NULL)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@returnDate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@enroll", txtEnrollment.Text.Trim());
                    cmd.Parameters.AddWithValue("@bookName", txtBookName.Text.Trim());

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh grid
                        btnSearchStudent_Click(null, null);

                        panel2.Visible = true;
                        txtBookName.Clear();
                        txtBIssueDate.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Book return failed. Make sure the book is selected correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Format DataGridView dates 
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Issued Date")
            {
                if (e.Value != null && DateTime.TryParse(e.Value.ToString(), out DateTime issueDate))
                {
                    e.Value = issueDate.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Return Date")
            {
                if (e.Value != null && e.Value.ToString() != "Not Returned" &&
                    DateTime.TryParse(e.Value.ToString(), out DateTime returnDate))
                {
                    e.Value = returnDate.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }

        private void txtEnrollment_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollment.Text == "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollment.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible=false;
        }
    }
}
