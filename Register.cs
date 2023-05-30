using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AMJJSystem
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-1968EC0O\\SQLEXPRESS;Initial Catalog=DBuser;Integrated Security=True");

        private void registerBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtFirstname.Text != "" && TxtLastname.Text != "" && TxtUsername.Text != "" && TxtPassword.Text != "")
                {
                    int v = check(TxtUsername.Text);
                    if (v != 1)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO TBL_Register (First_Name,Last_Name,Username,Password) VALUES (@First_Name,@Last_Name,@Username,@Password)", con);
                        cmd.Parameters.AddWithValue("@First_Name", TxtFirstname.Text);
                        cmd.Parameters.AddWithValue("@Last_Name", TxtLastname.Text);
                        cmd.Parameters.AddWithValue("@Username", TxtUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Register Succesfully!");
                        TxtFirstname.Text = "";
                        TxtLastname.Text = "";
                        TxtUsername.Text = "";
                        TxtPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("You are already registered");
                    }
                }
                else
                {
                    MessageBox.Show("Fill the blanks!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int check(string username)
        {
            con.Open();
            string query = "SELECT COUNT(*) FROM TBL_Register WHERE Username='" + username + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            int v = (int)cmd.ExecuteScalar();
            con.Close();
            return v;
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            TxtUsername.Clear();
            TxtPassword.Clear();
            TxtUsername.Focus();
        }

        private void showCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showCheckBox.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }
        private void DriverLabel_Click(object sender, EventArgs e)
        {
            frmAdmin Driver = new frmAdmin();
            Driver.Show();
            this.Hide();
        }
    }
}
