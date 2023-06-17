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
using System.Linq.Expressions;

namespace AMJJSystem
{
    public partial class frmDeliveryPickup : Form
    {
        public frmDeliveryPickup()
        {
            InitializeComponent();
            fillCombox();
            fillComboProduct();

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G0J1RVI\\SQLEXPRESS;Initial Catalog=DB_RPDC;Integrated Security=True");
        string selectedDeliveryID = "";
        private void CreateBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_DeliveryPickup (Name_of_Driver,Plate_Number,Address,Phone_Number_of_Driver,Name_of_Client_Company,Name_of_Client,Phone_Number_of_Client,Date_and_Time,Name_of_Item,Quantity,Size,Weight,Remarks,Status) VALUES (@Name_of_Driver,@Plate_Number,@Address,@Phone_Number_of_Driver,@Name_of_Client_Company,@Name_of_Client,@Phone_Number_of_Client,@Date_and_Time,@Name_of_Item,@Quantity,@Size,@Weight,@Remarks,@Status)", con);
            cmd.Parameters.AddWithValue("@Name_of_Driver", DriverComboBox.Text);
            cmd.Parameters.AddWithValue("@Plate_Number", TxtPlate.Text);
            cmd.Parameters.AddWithValue("@Address", TxtAddress.Text);
            cmd.Parameters.AddWithValue("@Phone_Number_of_Driver", TxtDriverPhonenumber.Text);
            cmd.Parameters.AddWithValue("@Name_of_Client_Company", ClientCompComboBox.Text);
            cmd.Parameters.AddWithValue("@Name_of_Client", TxtContact.Text);
            cmd.Parameters.AddWithValue("@Phone_Number_of_Client", TxtCompanynumber.Text);
            cmd.Parameters.AddWithValue("@Date_and_Time", DateAndTime.Value);
            cmd.Parameters.AddWithValue("@Name_of_Item", NameItemBox.Text);
            cmd.Parameters.AddWithValue("@Quantity", TxtQuantity.Text);
            cmd.Parameters.AddWithValue("@Size", SizeBox.Text);
            cmd.Parameters.AddWithValue("@Weight", WeightBox.Text);
            cmd.Parameters.AddWithValue("@Remarks", TxtRemarks.Text);
            //cmd.Parameters.AddWithValue("@Status", );
            cmd.ExecuteNonQuery();
            con.Close();
            BindData();
            MessageBox.Show("Created Successfully");
        }
        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE TBL_DeliveryPickup SET Name_of_Driver = @Name_of_Driver, Plate_Number = @Plate_Number, Address = @Address, Phone_Number_of_Driver = @Phone_Number_of_Driver, Name_of_Client_Company = @Name_of_Client_Company, Name_of_Client = @Name_of_Client, Phone_Number_of_Client = @Phone_Number_of_Client, Date_and_Time = @Date_and_Time, Name_of_Item = @Name_of_Item, Quantity = @Quantity, Size = @Size, Weight = @Weight, Remarks = @Remarks WHERE Delivery_ID = @Delivery_ID";
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Delivery_ID", selectedDeliveryID);
                    cmd.Parameters.AddWithValue("@Name_of_Driver", DriverComboBox.Text);
                    cmd.Parameters.AddWithValue("@Plate_Number", TxtPlate.Text);
                    cmd.Parameters.AddWithValue("@Address", TxtAddress.Text);
                    cmd.Parameters.AddWithValue("@Phone_Number_of_Driver", TxtDriverPhonenumber.Text);
                    cmd.Parameters.AddWithValue("@Name_of_Client_Company", ClientCompComboBox.Text);
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
            string updateQuery = "DELETE FROM TBL_DeliveryPickup WHERE Delivery_ID = @Delivery_ID";
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Delivery_ID", selectedDeliveryID);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_DeliveryPickup", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DeliveryTableView.DataSource = dt;
        }
        public void fillCombox()
        {
            string sql = "SELECT * FROM TBL_ClientCompany";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string nameofcompany = myreader.GetString(1);
                    ClientCompComboBox.Items.Add(nameofcompany);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillComboProduct()
        {
            string sql = "SELECT * FROM TBL_Products";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string nameofProduct = myreader.GetString(1);
                    NameItemBox.Items.Add(nameofProduct);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmDelivery_Load(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_DeliveryPickup", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DeliveryTableView.DataSource = dt;
            con.Close();

            DPlistView.View = View.Details;
            DPlistView.Columns.Add("Item", 150);
            DPlistView.Columns.Add("Quantity", 150);
            DPlistView.Columns.Add("Size", 150);
            DPlistView.Columns.Add("Weight", 150);
        }
        private void DeliveryTableView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DeliveryTableView.SelectedCells.Count > 0)
            {
                DeliveryTableView.CurrentRow.Selected = true;
                selectedDeliveryID = DeliveryTableView.Rows[e.RowIndex].Cells["Delivery_ID"].FormattedValue.ToString();
                DriverComboBox.Text = DeliveryTableView.Rows[e.RowIndex].Cells["Name_of_Driver"].FormattedValue.ToString();
                TxtPlate.Text = DeliveryTableView.Rows[e.RowIndex].Cells["Plate_Number"].FormattedValue.ToString();
                TxtAddress.Text = DeliveryTableView.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                TxtDriverPhonenumber.Text = DeliveryTableView.Rows[e.RowIndex].Cells["Phone_Number_of_Driver"].FormattedValue.ToString();
                ClientCompComboBox.Text = DeliveryTableView.Rows[e.RowIndex].Cells["Name_of_Client_Company"].FormattedValue.ToString();
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
            frmUserDashboard Db = new frmUserDashboard();
            Db.Show();
            this.Hide();
        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_DeliveryPickup", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DeliveryTableView.DataSource = dt;
            con.Close();
        }

        private void ClientCompComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = ClientCompComboBox.GetItemText(ClientCompComboBox.SelectedItem);
            string sql = "SELECT * FROM TBL_ClientCompany WHERE Name_of_Company = '" + value + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            DriverComboBox.Items.Clear();
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string CompNum = myreader.GetInt32(2).ToString();
                    string ContPer = myreader.GetString(3);
                    string PhNum = myreader.GetInt32(4).ToString();
                    string Driver = myreader.GetString(5);
                    string DcontNum = myreader.GetInt32(6).ToString();
                    string PlNum = myreader.GetString(7);
                    TxtContact.Text = ContPer;
                    TxtCompanynumber.Text = CompNum;
                    TxtDriverPhonenumber.Text = DcontNum;
                    TxtPlate.Text = PlNum;
                    DriverComboBox.Items.Add(Driver);
                    DriverComboBox.SelectedIndex = 0;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            add(NameItemBox.SelectedItem.ToString(), TxtQuantity.Text, SizeBox.SelectedItem.ToString(), WeightBox.SelectedItem.ToString());
        }

        private void add(String item, String quantity, String size, String weight)
        {
            string[] row = { item, quantity, size, weight };
            ListViewItem items = new ListViewItem(row);

            DPlistView.Items.Add(items);
        }

        private void NameItemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = NameItemBox.GetItemText(NameItemBox.SelectedItem);
            string sql = "SELECT * FROM TBL_Products WHERE Item_Name = '" + value + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            SizeBox.Items.Clear();
            WeightBox.Items.Clear();
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string Volume = myreader.GetString(2);
                    string Weight = myreader.GetString(3);
                    SizeBox.Items.Add(Volume);
                    SizeBox.SelectedIndex = 0;
                    WeightBox.Items.Add(Weight);
                    WeightBox.SelectedIndex = 0;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
