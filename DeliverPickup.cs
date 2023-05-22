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
using Microsoft.VisualBasic;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AMJJSystem
{
    public partial class frmDeliveryPickup : Form
    {
        public frmDeliveryPickup()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G0J1RVI\\SQLEXPRESS;Initial Catalog=DB_DeliveryPickup;Integrated Security=True");
        private void CreateBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_Delivery (Name_of_Driver,Plate_Number,Address,Phone_Number_of_Driver,Name_of_Client_Company,Name_of_Client,Phone_Number_of_Client,Date_and_Time,Name_of_Item,Quantity,Size,Weight,Remarks) VALUES (@Name_of_Driver,@Plate_Number,@Address,@Phone_Number_of_Driver,@Name_of_Client_Company,@Name_of_Client,@Phone_Number_of_Client,@Date_and_Time,@Name_of_Item,@Quantity,@Size,@Weight,@Remarks)", con);
            cmd.Parameters.AddWithValue("@Name_of_Driver", TxtDriver.Text);
            cmd.Parameters.AddWithValue("@Plate_Number", TxtPlate.Text);
            cmd.Parameters.AddWithValue("@Address", TxtAddress.Text);
            cmd.Parameters.AddWithValue("@Phone_Number_of_Driver", TxtDriverPhonenumber.Text);
            cmd.Parameters.AddWithValue("@Name_of_Client_Company", TxtCompany.Text);
            cmd.Parameters.AddWithValue("@Name_of_Client", TxtContact.Text);
            cmd.Parameters.AddWithValue("@Phone_Number_of_Client", TxtCompanynumber.Text);
            cmd.Parameters.AddWithValue("@Date_and_Time", DateAndTime.Value);
            cmd.Parameters.AddWithValue("@Name_of_Item", NameItemBox.Text);
            cmd.Parameters.AddWithValue("@Quantity", TxtQuantity.Text);
            cmd.Parameters.AddWithValue("@Size", SizeBox.Text);
            cmd.Parameters.AddWithValue("@Weight", WeightBox.Text);
            cmd.Parameters.AddWithValue("@Remarks", TxtRemarks.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            BindData();
            MessageBox.Show("Created Successfully");
        }
        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE TBL_Delivery SET Name_of_Driver = @Name_of_Driver, Plate_Number = @Plate_Number, Address = @Address, Phone_Number_of_Driver = @Phone_Number_of_Driver, Name_of_Client_Company = @Name_of_Client_Company, Name_of_Client = @Name_of_Client, Phone_Number_of_Client = @Phone_Number_of_Client, Date_and_Time = @Date_and_Time, Name_of_Item = @Name_of_Item, Quantity = @Quantity, Size = @Size, Weight = @Weight, Remarks = @Remarks WHERE Delivery_ID = @Delivery_ID";
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Delivery_ID", DeliveryTableView.Rows[DeliveryTableView.SelectedCells[0].ColumnIndex].Cells["Delivery_ID"].Value);
                    cmd.Parameters.AddWithValue("@Name_of_Driver", TxtDriver.Text);
                    cmd.Parameters.AddWithValue("@Plate_Number", TxtPlate.Text);
                    cmd.Parameters.AddWithValue("@Address", TxtAddress.Text);
                    cmd.Parameters.AddWithValue("@Phone_Number_of_Driver", TxtDriverPhonenumber.Text);
                    cmd.Parameters.AddWithValue("@Name_of_Client_Company", TxtCompany.Text);
                    cmd.Parameters.AddWithValue("@Name_of_Client", TxtContact.Text);
                    cmd.Parameters.AddWithValue("@Phone_Number_of_Client", TxtCompanynumber.Text);
                    cmd.Parameters.AddWithValue("@Date_and_Time", DateAndTime.Value);
                    cmd.Parameters.AddWithValue("@Name_of_Item", NameItemBox.Text);
                    cmd.Parameters.AddWithValue("@Quantity", TxtQuantity.Text);
                    cmd.Parameters.AddWithValue("@Size", SizeBox.Text);
                    cmd.Parameters.AddWithValue("@Weight", WeightBox.Text);
                    cmd.Parameters.AddWithValue("@Remarks", TxtRemarks.Text);
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
            string updateQuery = "DELETE FROM TBL_Delivery WHERE Delivery_ID = @Delivery_ID";
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Delivery_ID", DeliveryTableView.Rows[DeliveryTableView.SelectedCells[0].ColumnIndex].Cells["Delivery_ID"].Value);
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
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_Delivery", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DeliveryTableView.DataSource = dt;
        }
        private void ReadBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_Delivery", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DeliveryTableView.DataSource = dt;
            con.Close();
        }

        private void frmDelivery_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_Delivery", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DeliveryTableView.DataSource = dt;
            con.Close();
        }
        private void DeliveryTableView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DeliveryTableView.SelectedCells.Count > 0)
            {
                DeliveryTableView.CurrentRow.Selected = true;
                TxtDriver.Text = DeliveryTableView.Rows[e.RowIndex].Cells["Name_of_Driver"].FormattedValue.ToString();
                TxtPlate.Text = DeliveryTableView.Rows[e.RowIndex].Cells["Plate_Number"].FormattedValue.ToString();
                TxtAddress.Text = DeliveryTableView.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                TxtDriverPhonenumber.Text = DeliveryTableView.Rows[e.RowIndex].Cells["Phone_Number_of_Driver"].FormattedValue.ToString();
                TxtCompany.Text = DeliveryTableView.Rows[e.RowIndex].Cells["Name_of_Client_Company"].FormattedValue.ToString();
                TxtContact.Text = DeliveryTableView.Rows[e.RowIndex].Cells["Name_of_Client"].FormattedValue.ToString();
                TxtCompanynumber.Text = DeliveryTableView.Rows[e.RowIndex].Cells["Phone_Number_of_Client"].FormattedValue.ToString();
                DateAndTime.Value = DateTime.Parse(DeliveryTableView.Rows[e.RowIndex].Cells["Date_and_Time"].FormattedValue.ToString());
                NameItemBox.Text = DeliveryTableView.Rows[e.RowIndex].Cells["Name_of_Item"].FormattedValue.ToString();
                TxtQuantity.Text = DeliveryTableView.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString();
                SizeBox.Text = DeliveryTableView.Rows[e.RowIndex].Cells["Size"].FormattedValue.ToString();
                WeightBox.Text = DeliveryTableView.Rows[e.RowIndex].Cells["Weight"].FormattedValue.ToString();
                TxtRemarks.Text = DeliveryTableView.Rows[e.RowIndex].Cells["Remarks"].FormattedValue.ToString();
            }
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            frmDashboard Db = new frmDashboard();
            Db.Show();
            this.Hide();
        }
    }
}
