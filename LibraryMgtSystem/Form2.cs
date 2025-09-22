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
    public partial class Form2 : Form
    {
        // Connection string to your SQL Server
        string connectionString = "Data Source=DILMI-LAP\\MSSQLSERVER01; Initial Catalog=LMSDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;";

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "Username")
            {
                txtUserName.Clear();
            }
        }

        private void txtCrPswd_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCrPswd.Text == "Create Password")
            {
                txtCrPswd.Clear();
                //txtCrPswd.PasswordChar = '*';
            }
        }

        private void txtConPswd_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtConPswd.Text == "Confirm Password")
            {
                txtConPswd.Clear();
                txtConPswd.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtCrPswd.Text.Trim();
            string confirmPassword = txtConPswd.Text.Trim();

            // Basic validation
            if (string.IsNullOrEmpty(username) || username == "Username")
            {
                MessageBox.Show("Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password) || password == "Create Password")
            {
                MessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert into database
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Check if username already exists
                using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM loginTable WHERE username = @username", con))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Insert new user
                using (SqlCommand cmd = new SqlCommand("INSERT INTO loginTable (username, pass) VALUES (@username, @pass)", con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@pass", password);  // ⚠️ Plain text password (better to hash in production)

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally clear fields
                txtUserName.Text = "Username";
                txtCrPswd.Text = "Create Password";
                txtConPswd.Text = "Confirm Password";
                txtCrPswd.PasswordChar = '\0';
                txtConPswd.PasswordChar = '\0';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
