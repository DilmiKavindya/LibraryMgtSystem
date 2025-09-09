using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LibraryMgtSystem
{
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            // Load all book names into comboBox
            using (SqlConnection con = new SqlConnection("Data Source=DILMI-LAP\\MSSQLSERVER01; Initial Catalog=LMSDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;"))
            {
                SqlCommand cmd = new SqlCommand("SELECT BookName FROM NewBook", con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    comboBoxBooks.Items.Add(sdr["BookName"].ToString());
                }

                sdr.Close();
                con.Close();
            }
        }

        int count;

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            if (txtEnrollment.Text != "")
            {
                using (SqlConnection con = new SqlConnection("Data Source=DILMI-LAP\\MSSQLSERVER01; Initial Catalog=LMSDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;"))
                {
                    con.Open();

                    // Get student details
                    SqlCommand cmd = new SqlCommand("SELECT * FROM NewStudent WHERE enrollmentNo=@enroll", con);
                    cmd.Parameters.AddWithValue("@enroll", txtEnrollment.Text);
                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.Read())
                    {
                        txtStName.Text = sdr["studentName"].ToString();
                        txtDepartment.Text = sdr["department"].ToString();
                        txtSemester.Text = sdr["semester"].ToString();
                        txtConNo.Text = sdr["contactNo"].ToString();
                        txtEmail.Text = sdr["email"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Enrollment No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearStudentDetails();
                        txtEnrollment.Focus();
                    }
                    sdr.Close();

                    // Count how many books are currently issued (Not Returned)
                    cmd = new SqlCommand("SELECT COUNT(enroll) FROM IRBook WHERE enroll=@enroll AND bookReturnDate = 'Not Returned'", con);
                    cmd.Parameters.AddWithValue("@enroll", txtEnrollment.Text);

                    count = (int)cmd.ExecuteScalar();

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter valid enrollment No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtStName.Text != "")
            {
                if (comboBoxBooks.SelectedIndex != -1 && count < 3)
                {
                    string enroll = txtEnrollment.Text;
                    string sname = txtStName.Text;
                    string sdep = txtDepartment.Text;
                    string ssem = txtSemester.Text;
                    long scon;
                    if (!long.TryParse(txtConNo.Text, out scon))
                    {
                        MessageBox.Show("Invalid Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string semail = txtEmail.Text;
                    string bookname = comboBoxBooks.Text;
                    string bookissuedate = dateTimePicker.Value.ToString("yyyy-MM-dd");

                    using (SqlConnection con = new SqlConnection("Data Source=DILMI-LAP\\MSSQLSERVER01; Initial Catalog=LMSDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;"))
                    {
                        string query = @"INSERT INTO IRBook
                                        (enroll, stName, dep, sem, contact, email, bookName, bookIssueDate, bookReturnDate) 
                                         VALUES(@enroll, @sname, @sdep, @ssem, @scon, @semail, @bookname, @bookissuedate, @bookReturnDate)";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@enroll", enroll);
                            cmd.Parameters.AddWithValue("@sname", sname);
                            cmd.Parameters.AddWithValue("@sdep", sdep);
                            cmd.Parameters.AddWithValue("@ssem", ssem);
                            cmd.Parameters.AddWithValue("@scon", scon);
                            cmd.Parameters.AddWithValue("@semail", semail);
                            cmd.Parameters.AddWithValue("@bookname", bookname);
                            cmd.Parameters.AddWithValue("@bookissuedate", bookissuedate);

                            // Mark as Not Returned when issuing
                            cmd.Parameters.AddWithValue("@bookReturnDate", "Not Returned");

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    MessageBox.Show("Book Issued Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearStudentDetails();
                    txtEnrollment.Clear();
                    comboBoxBooks.SelectedIndex = -1;
                }
                else
                {
                    if (count >= 3)
                    {
                        MessageBox.Show("This student has already been issued 3 books. A book must be returned before issuing another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Please select a book to issue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter valid enrollment No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearStudentDetails()
        {
            txtStName.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtConNo.Clear();
            txtEmail.Clear();
        }

        private void txtEnrollment_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollment.Text == "")
            {
                txtStName.Clear();
                txtDepartment.Clear();
                txtSemester.Clear();
                txtConNo.Clear();
                txtEmail.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollment.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
