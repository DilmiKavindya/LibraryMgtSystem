using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryMgtSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void pictureBoxYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=DILMI-LAP\\MSSQLSERVER01; Initial Catalog=LMSDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;";
            string query = "SELECT COUNT(1) FROM loginTable WHERE username = @user AND pass = @pass";

            try
            {
                using (SqlConnection con = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text); // consider hashing passwords instead of storing plaintext

                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // Login successful: proceed
                        //MessageBox.Show("Login successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide(); // Hide the login form
                        Dashboard dsa = new Dashboard(); // Create an instance of the Dashboard form
                        dsa.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log ex.Message or show a user-friendly message
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
           Form2 frm = new Form2();
           frm.Show();
        }
    }
}

