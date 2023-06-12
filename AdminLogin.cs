using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMJJSystem
{
    public partial class frmDriver : Form
    {
        public frmDriver()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G0J1RVI\\SQLEXPRESS;Initial Catalog=DBLogin;Integrated Security=True");
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text != "" && TxtPassword.Text != "")
            {

                string query = "SELECT COUNT(*) FROM TBL_Register WHERE Username='" + TxtUsername.Text + "' AND Password='" + TxtPassword.Text + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int v = (int)cmd.ExecuteScalar();

                if (v != 1)
                {
                    MessageBox.Show("Error username or password, Error!");
                }
                else
                {
                    frmDriverDashboard DD = new frmDriverDashboard();
                    MessageBox.Show("Welcome to AMJJ SYSTEM!");
                    TxtUsername.Text = "";
                    TxtPassword.Text = "";
                    DD.Show();
                    this.Hide();

                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Fill it the blanks!");
            }
        }
    }
}
