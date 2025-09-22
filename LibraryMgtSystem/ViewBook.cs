using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LibraryMgtSystem
{
    public partial class ViewBook : Form
    {
        string connectionString = "Data Source=DILMI-LAP\\MSSQLSERVER01; Initial Catalog=LMSDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;";
        int BookId;
        Int64 rowid;

        public ViewBook()
        {
            InitializeComponent();
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            LoadBooks();
        }

        private void LoadBooks(string searchTerm = "")
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = string.IsNullOrWhiteSpace(searchTerm)
                    ? @"SELECT BookId AS [ID], BookName AS [Book Name], BookAuthor AS [Book Author], BookPublication AS [Publication], BookPurchaseDate AS [Purchase Date], BookPrice AS [Price], BookQuantity AS [Quantity]
                        FROM NewBook"
                    : @"SELECT BookId AS [ID], BookName AS [Book Name], BookAuthor AS [Book Author], BookPublication AS [Publication], BookPurchaseDate AS [Purchase Date], BookPrice AS [Price], BookQuantity AS [Quantity]
                        FROM NewBook
                        WHERE BookName LIKE @SearchTerm";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", searchTerm + "%");
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                // Always refresh BookId and rowid
                BookId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                rowid = BookId;
                panel2.Visible = true;

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM NewBook WHERE BookId = @BookId", con))
                {
                    cmd.Parameters.AddWithValue("@BookId", BookId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[0].Rows[0];

                        txtBName.Text = row["BookName"].ToString();
                        txtAuthor.Text = row["BookAuthor"].ToString();
                        txtPublication.Text = row["BookPublication"].ToString();
                        txtPDate.Text = row["BookPurchaseDate"].ToString();
                        txtPrice.Text = row["BookPrice"].ToString();
                        txtQuantity.Text = row["BookQuantity"].ToString();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtBNSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBooks(txtBNSearch.Text.Trim());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBNSearch.Clear();
            panel2.Visible = false;
            LoadBooks();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Updated. Confirm?", "Confirm Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string bname = txtBName.Text.Trim();
                string bauthor = txtAuthor.Text.Trim();
                string publication = txtPublication.Text.Trim();
                string pdate = txtPDate.Text.Trim();
                Int64 price = Int64.Parse(txtPrice.Text);
                Int64 quantity = Int64.Parse(txtQuantity.Text);

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(@"UPDATE NewBook  SET BookName = @BookName, BookAuthor = @BookAuthor, BookPublication = @BookPublication, BookPurchaseDate = @BookPurchaseDate, BookPrice = @BookPrice, BookQuantity = @BookQuantity 
                                                         WHERE BookId = @BookId", con))
                {
                    cmd.Parameters.AddWithValue("@BookName", bname);
                    cmd.Parameters.AddWithValue("@BookAuthor", bauthor);
                    cmd.Parameters.AddWithValue("@BookPublication", publication);
                    cmd.Parameters.AddWithValue("@BookPurchaseDate", pdate);
                    cmd.Parameters.AddWithValue("@BookPrice", price);
                    cmd.Parameters.AddWithValue("@BookQuantity", quantity);
                    cmd.Parameters.AddWithValue("@BookId", rowid);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                // Refresh DataGridView after update
                LoadBooks(txtBNSearch.Text.Trim());

                // Keep updated row selected
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && Convert.ToInt64(row.Cells[0].Value) == rowid)
                    {
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted. Confirm?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM NewBook WHERE BookId = @BookId", con))
                {
                    cmd.Parameters.AddWithValue("@BookId", rowid);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                // Refresh DataGridView after delete
                LoadBooks(txtBNSearch.Text.Trim());

                // Hide details panel since deleted record no longer exists
                panel2.Visible = false;
            }
        }
    }
}
