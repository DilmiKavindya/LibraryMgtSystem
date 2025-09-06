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
    public partial class ViewStudentDetails : Form
    {
        public ViewStudentDetails()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtSearchEnrollment_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEnrollment.Text != "")
            {
                label1.Visible = false;
                Image image = Image.FromFile("D://LibraryManagementSystem//LibraryMgtSystem//Icons/search1.gif");
                pictureBox1.Image = image;

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
                Image image = Image.FromFile("D://LibraryManagementSystem//LibraryMgtSystem//Icons/search.gif");
                pictureBox1.Image = image;

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
    }
}
