using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMJJSystem
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void ShowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowCheckBox.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;

            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtUsername.Clear();
            TxtPassword.Clear();
            TxtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmRegister Register = new frmRegister();
            Register.Show();
            this.Hide();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
