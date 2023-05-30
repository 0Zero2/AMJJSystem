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
    public partial class frmClientCompany : Form
    {
        public frmClientCompany()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G0J1RVI\\SQLEXPRESS;Initial Catalog=DB_ClientCompany;Integrated Security=True");
        string selectedCompanyID = "";
        private void ClientCompany_Load(object sender, EventArgs e)
        {

        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            frmDashboard Db = new frmDashboard();
            Db.Show();
            this.Hide();
        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_ClientCompany (Company_ID, Name_of_Company, Company_Number, Contact_Person, Phone_Number, Driver, Contact_Number, Plate_Number) VALUES (@Company_ID, @Name_of_Company, @Company_Number, @Contact_Person, @Phone_Number, @Driver, @Contact_Number, @Plate_Number)", con);
            cmd.Parameters.AddWithValue("@Company_ID", TxtCompanyID.Text);
            cmd.Parameters.AddWithValue("@Name_of_Company", TxtCompanyName.Text);
            cmd.Parameters.AddWithValue("@Company_Number", TxtCompanyNumber.Text);
            cmd.Parameters.AddWithValue("@Contact_Person", TxtContactPerson.Text);
            cmd.Parameters.AddWithValue("@Phone_Number", TxtPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@Driver", TxtDriver.Text);
            cmd.Parameters.AddWithValue("@Contact_Number", TxtContactNumber.Text);
            cmd.Parameters.AddWithValue("@Plate_Number", TxtPlateNumber.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            BindData();
            MessageBox.Show("Created Successfully");
        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_ClientCompany", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ClientCompTableView.DataSource = dt;
            con.Close();
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE TBL_ClientCompany SET Name_of_Company = @Name_of_Company, Company_Number = @Company_Number, Contact_Person = @Contact_Person, Phone_Number = @Phone_Number, Driver = @Driver, Contact_Number = @Contact_Number, Plate_Number = @Plate_Number WHERE Company_ID = @Company_ID";
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Company_ID", selectedCompanyID);
                    cmd.Parameters.AddWithValue("@Name_of_Company", TxtCompanyName.Text);
                    cmd.Parameters.AddWithValue("@Company_Number", TxtCompanyNumber.Text);
                    cmd.Parameters.AddWithValue("@Contact_Person", TxtContactPerson.Text);
                    cmd.Parameters.AddWithValue("@Phone_Number", TxtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Driver", TxtDriver.Text);
                    cmd.Parameters.AddWithValue("@Contact_Number", TxtContactNumber.Text);
                    cmd.Parameters.AddWithValue("@Plate_Number", TxtPlateNumber.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Updated Successfully");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            string updateQuery = "DELETE FROM TBL_ClientCompany WHERE Company_ID = @Company_ID";
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Company_ID", selectedCompanyID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Deleted Successfully");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ClientCompTableView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ClientCompTableView.SelectedCells.Count > 0)
            {
                ClientCompTableView.CurrentRow.Selected = true;
                selectedCompanyID = ClientCompTableView.Rows[e.RowIndex].Cells["Company_ID"].FormattedValue.ToString();
                TxtCompanyName.Text = ClientCompTableView.Rows[e.RowIndex].Cells["Name_of_Company"].FormattedValue.ToString();
                TxtCompanyNumber.Text = ClientCompTableView.Rows[e.RowIndex].Cells["Company_Number"].FormattedValue.ToString();
                TxtContactPerson.Text = ClientCompTableView.Rows[e.RowIndex].Cells["Contact_Person"].FormattedValue.ToString();
                TxtPhoneNumber.Text = ClientCompTableView.Rows[e.RowIndex].Cells["Phone_Number"].FormattedValue.ToString();
                TxtDriver.Text = ClientCompTableView.Rows[e.RowIndex].Cells["Driver"].FormattedValue.ToString();
                TxtContactNumber.Text = ClientCompTableView.Rows[e.RowIndex].Cells["Contact_Number"].FormattedValue.ToString();
                TxtPlateNumber.Text = ClientCompTableView.Rows[e.RowIndex].Cells["Plate_Number"].FormattedValue.ToString();

            }
        }
            void BindData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_Delivery", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ClientCompTableView.DataSource = dt;
        }
    }
}
