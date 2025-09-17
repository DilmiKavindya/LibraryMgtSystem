using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LibraryMgtSystem
{
    public partial class CompletedBookDetails : Form
    {
        public CompletedBookDetails()
        {
            InitializeComponent();

            // Attach CellFormatting event
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void CompletedBookDetails_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DILMI-LAP\\MSSQLSERVER01; Initial Catalog=LMSDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM IRBook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            // Hide ID column
            if (dataGridView1.Columns.Contains("id"))
            {
                dataGridView1.Columns["id"].Visible = false;
            }

            // Set custom column headers
            dataGridView1.Columns["stName"].HeaderText = "Student Name";
            dataGridView1.Columns["enroll"].HeaderText = "Enrollment No.";
            dataGridView1.Columns["dep"].HeaderText = "Department";
            dataGridView1.Columns["sem"].HeaderText = "Semester";
            dataGridView1.Columns["contact"].HeaderText = "Contact No.";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["bookName"].HeaderText = "Book Name";
            dataGridView1.Columns["bookIssueDate"].HeaderText = "Issued Date";
            dataGridView1.Columns["bookReturnDate"].HeaderText = "Return Date";
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Format Issued Date
            if (dataGridView1.Columns[e.ColumnIndex].Name == "bookIssueDate" && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime dt))
                {
                    e.Value = dt.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }

            // Format Returned Date (if not "Not Returned")
            if (dataGridView1.Columns[e.ColumnIndex].Name == "bookReturnDate" && e.Value != null)
            {
                string val = e.Value.ToString();
                if (DateTime.TryParse(val, out DateTime dt))
                {
                    e.Value = dt.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
                else if (val == "Not Returned")
                {
                    e.Value = "Not Returned"; // keep as is
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
