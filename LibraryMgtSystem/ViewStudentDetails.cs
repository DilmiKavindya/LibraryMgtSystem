using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryMgtSystem
{
    public partial class ViewStudentDetails : Form
    {
        public ViewStudentDetails()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: handle if you need clicks inside grid cells
        }

        private void txtSearchEnrollment_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEnrollment.Text != "")
            {
                label1.Visible = false;
                pictureBox1.Image = Image.FromFile("D://LibraryManagementSystem//LibraryMgtSystem//Icons/search1.gif");

                using (SqlConnection con = new SqlConnection("Data Source=DILMI-LAP\\MSSQLSERVER01; Initial Catalog=LMSDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;"))
                {
                    string searchText = txtSearchEnrollment.Text.Trim();

                    string query = @"SELECT * FROM NewStudent 
                                     WHERE studentName LIKE '%' + @search + '%'
                                        OR enrollmentNo LIKE '%' + @search + '%'
                                        OR department LIKE '%' + @search + '%'
                                        OR semester LIKE '%' + @search + '%'
                                        OR contactNo LIKE '%' + @search + '%'
                                        OR email LIKE '%' + @search + '%'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@search", searchText);

                        SqlDataAdapter DA = new SqlDataAdapter(cmd);
                        DataSet DS = new DataSet();
                        DA.Fill(DS);

                        dataGridView1.DataSource = DS.Tables[0];
                    }
                }
            }
            else
            {
                label1.Visible = true;
                pictureBox1.Image = Image.FromFile("D://LibraryManagementSystem//LibraryMgtSystem//Icons/search.gif");
                LoadAllStudents();
            }
        }

        private void ViewStudentDetails_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            LoadAllStudents();
        }

        private void LoadAllStudents()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DILMI-LAP\\MSSQLSERVER01; Initial Catalog=LMSDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;"))
            {
                string query = "SELECT * FROM NewStudent";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    dataGridView1.DataSource = DS.Tables[0];
                }
            }
        }

        int StudentId;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // prevent error when clicking header row
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    StudentId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                }

                panel2.Visible = true;

                using (SqlConnection con = new SqlConnection("Data Source=DILMI-LAP\\MSSQLSERVER01; Initial Catalog=LMSDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;"))
                {
                    string query = "SELECT * FROM NewStudent WHERE StudentId = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", StudentId);

                        SqlDataAdapter DA = new SqlDataAdapter(cmd);
                        DataSet DS = new DataSet();
                        DA.Fill(DS);

                        if (DS.Tables[0].Rows.Count > 0)
                        {
                            rowid = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());
                            txtStName.Text = DS.Tables[0].Rows[0][1].ToString();
                            txtEnNo.Text = DS.Tables[0].Rows[0][2].ToString();
                            txtDepartment.Text = DS.Tables[0].Rows[0][3].ToString();
                            txtSemester.Text = DS.Tables[0].Rows[0][4].ToString();
                            txtConNo.Text = DS.Tables[0].Rows[0][5].ToString();
                            txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string stname = txtStName.Text.Trim();
            string enno = txtEnNo.Text.Trim();
            string dep = txtDepartment.Text.Trim();
            string sem = txtSemester.Text.Trim();
            string conno = txtConNo.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (MessageBox.Show("Data will be Updated. Confirm?", "Confirm Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection("Data Source=DILMI-LAP\\MSSQLSERVER01; Initial Catalog=LMSDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;"))
                {
                    string query = @"UPDATE NewStudent 
                                     SET studentName = @stname,
                                         enrollmentNo = @enno,
                                         department = @dep,
                                         semester = @sem,
                                         contactNo = @conno,
                                         email = @email
                                     WHERE StudentId = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@stname", stname);
                        cmd.Parameters.AddWithValue("@enno", enno);
                        cmd.Parameters.AddWithValue("@dep", dep);
                        cmd.Parameters.AddWithValue("@sem", sem);
                        cmd.Parameters.AddWithValue("@conno", conno);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@id", rowid);

                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rows > 0)
                        {
                            // MessageBox.Show("Student details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllStudents();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please check again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ViewStudentDetails_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted. Confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DILMI-LAP\\MSSQLSERVER01; Initial Catalog=LMSDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM NewStudent WHERE studentId = "+rowid+"";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                ViewStudentDetails_Load(this, null);
            }
        }
    }
}
