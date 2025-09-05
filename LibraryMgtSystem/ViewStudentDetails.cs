using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            }
            else
            {
                label1.Visible = true;
                Image image = Image.FromFile("D://LibraryManagementSystem//LibraryMgtSystem//Icons/search.gif");
                pictureBox1.Image = image;
            }
        }

        private void ViewStudentDetails_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
