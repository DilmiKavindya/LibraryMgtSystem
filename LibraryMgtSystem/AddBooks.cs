using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMgtSystem
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Basic validation (you can expand this)
            if (string.IsNullOrWhiteSpace(txtBookName.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtPublication.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please fill all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse numeric fields safely
            if (!Int64.TryParse(txtPrice.Text.Trim(), out long price))
            {
                MessageBox.Show("Price must be a valid number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Int64.TryParse(txtQuantity.Text.Trim(), out long quan))
            {
                MessageBox.Show("Quantity must be a valid number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bname = txtBookName.Text.Trim();
            string bauthor = txtAuthor.Text.Trim();
            string publication = txtPublication.Text.Trim();
            // If you have a separate publish date field, use that. 
            string pdate = txtPublication.Text.Trim(); // adjust if you really have a date field

            string connStr = "Data Source=DILMI-LAP\\MSSQLSERVER01; Initial Catalog=LMSDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;";

            string insertQuery = @"
            INSERT INTO NewBook (BookName, BookAuthor, BookPublication, BookPurchaseDate, BookPrice, BookQuantity)
            VALUES (@name, @author, @pub, @pdate, @price, @quan);";

            try
            {
                using (SqlConnection con = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@name", bname);
                    cmd.Parameters.AddWithValue("@author", bauthor);
                    cmd.Parameters.AddWithValue("@pub", publication);
                    cmd.Parameters.AddWithValue("@pdate", pdate);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@quan", quan);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields(); // Clear fields after save
                    }
                    else
                    {
                        MessageBox.Show("Insert failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close(); // Close the AddBooks form
            }
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearFields(); // Clears all fields when refresh button clicked
        }

        // Helper method to clear all text fields
        private void ClearFields()
        {
            txtBookName.Clear();
            txtAuthor.Clear();
            txtPublication.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();

            // Optional: set focus back to the first input
            txtBookName.Focus();
        }
    }
}
