using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.Data;

namespace AMJJSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-1968EC0O\\SQLEXPRESS;Initial Catalog=DBuser;Integrated Security=True");
        private void loginBTN_Click(object sender, EventArgs e)
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
                    frmDashboard Db = new frmDashboard();
                    MessageBox.Show("Welcome to AMJJ SYSTEM!");
                    TxtUsername.Text = "";
                    TxtPassword.Text = "";
                    Db.Show();
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("Fill it the blanks!");
            }
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            TxtUsername.Clear();
            TxtPassword.Clear();
            TxtUsername.Focus();
        }

        private void showCheckbox_CheckedChanged(object sender, EventArgs e)
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

        private void createLabel_Click(object sender, EventArgs e)
        {
            frmRegister Register = new frmRegister();
            Register.Show();
            this.Hide();
        }
    }
}
