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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    this.Close();
            //}
            if (MessageBox.Show("Are you sure you want to cancel?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close(); // Close the AddStudent form
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        //Reusable method to clear all fields
        private void ClearFields()
        {
            txtName.Clear();
            txtEnrollment.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEnrollment.Text) ||
                string.IsNullOrWhiteSpace(txtDepartment.Text) ||
                string.IsNullOrWhiteSpace(txtSemester.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Contact number validation (only digits, 10 characters)
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtContact.Text.Trim(), @"^\d{10}$"))
            {
                MessageBox.Show("Contact number must be exactly 10 digits.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Email validation
            try
            {
                var addr = new System.Net.Mail.MailAddress(txtEmail.Text.Trim());
                if (addr.Address != txtEmail.Text.Trim())
                {
                    MessageBox.Show("Invalid email address format.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Invalid email address format.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Data preparation
            string name = txtName.Text.Trim();
            string enrollment = txtEnrollment.Text.Trim();
            string department = txtDepartment.Text.Trim();
            string semester = txtSemester.Text.Trim();
            string contact = txtContact.Text.Trim(); // store as string
            string email = txtEmail.Text.Trim();

            string connectionString =
                @"Data Source=DILMI-LAP\MSSQLSERVER01; Initial Catalog=LMSDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Check if enrollment number already exists
                    using (SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(1) FROM NewStudent WHERE enrollmentNo = @enrollmentNo", con))
                    {
                        checkCmd.Parameters.Add("@enrollmentNo", SqlDbType.NVarChar, 50).Value = enrollment;

                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (exists > 0)
                        {
                            MessageBox.Show("Enrollment number already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert new student
                    string insertQuery = @"INSERT INTO NewStudent (studentName, enrollmentNo, department, semester, contactNo, email)
                        VALUES (@studentName, @enrollmentNo, @department, @semester, @contactNo, @email)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.Add("@studentName", SqlDbType.NVarChar, 100).Value = name;
                        cmd.Parameters.Add("@enrollmentNo", SqlDbType.NVarChar, 50).Value = enrollment;
                        cmd.Parameters.Add("@department", SqlDbType.NVarChar, 100).Value = department;
                        cmd.Parameters.Add("@semester", SqlDbType.NVarChar, 20).Value = semester;
                        cmd.Parameters.Add("@contactNo", SqlDbType.NVarChar, 20).Value = contact;
                        cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = email;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601) // Unique constraint violation
            {
                MessageBox.Show("Enrollment number already exists (unique constraint).", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
