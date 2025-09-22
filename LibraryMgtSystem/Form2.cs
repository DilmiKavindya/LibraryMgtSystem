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
    public partial class Form2 : Form
    {
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

        }
    }
}
