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
    public partial class frmDelivery : Form
    {
        public frmDelivery()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G0J1RVI\\SQLEXPRESS;Initial Catalog=DB_Delivery;Integrated Security=True");
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
            cmd.Parameters.AddWithValue("@Date_and_Time", DateTime.Parse(DateAndTime.Text));
            cmd.Parameters.AddWithValue("@Name_of_Item", NameItemBox.Text);
            cmd.Parameters.AddWithValue("@Quantity", TxtQuantity.Text);
            cmd.Parameters.AddWithValue("@Size", SizeBox.Text);
            cmd.Parameters.AddWithValue("@Weight", WeightBox.Text);
            cmd.Parameters.AddWithValue("@Remarks", TxtRemarks.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            BindData();
            MessageBox.Show("Successfully Created");
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE TBL_Delivery SET Name = @Name_of_Driver, PN = @Plate_Number, Locs = @Address, PhoneNum = @Phone_Number_of_Driver, NameofClientComp = @Name_of_Client_Company, NameofClient = @Name_of_Client, PhoneofClient = @Phone_Number_of_Client, Datetime = @Date_and_Time, ItmName =  @Name_of_Item, Quanty = @Quantity, size = @Size, weight = @Weight, remarks = @Remarks) ", con);
            cmd.Parameters.AddWithValue("@Name_of_Driver", TxtDriver.Text);
            cmd.Parameters.AddWithValue("@Plate_Number", TxtPlate.Text);
            cmd.Parameters.AddWithValue("@Address", TxtAddress.Text);
            cmd.Parameters.AddWithValue("@Phone_Number_of_Driver", TxtDriverPhonenumber.Text);
            cmd.Parameters.AddWithValue("@Name_of_Client_Company", TxtCompany.Text);
            cmd.Parameters.AddWithValue("@Name_of_Client", TxtContact.Text);
            cmd.Parameters.AddWithValue("@Phone_Number_of_Client", TxtCompanynumber.Text);
            cmd.Parameters.AddWithValue("@Date_and_Time", DateTime.Parse(DateAndTime.Text));
            cmd.Parameters.AddWithValue("@Name_of_Item", NameItemBox.Text);
            cmd.Parameters.AddWithValue("@Quantity", TxtQuantity.Text);
            cmd.Parameters.AddWithValue("@Size", SizeBox.Text);
            cmd.Parameters.AddWithValue("@Weight", WeightBox.Text);
            cmd.Parameters.AddWithValue("@Remarks", TxtRemarks.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated");

        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE TBL_Delivery WHERE Name = @Name_of_Driver, PN = @Plate_Number, Add = @Address, PhoneNum = @Phone_Number_of_Driver, NameofClientComp = @Name_of_Client_Company, NameofClient = @Name_of_Client, PhoneofClient = @Phone_Number_of_Client, Datetime = @Date_and_Time, ItmName =  @Name_of_Item, Quanty = @Quantity, size = @Size, weight = @Weight, remarks = @Remarks) ", con);
            cmd.Parameters.AddWithValue("@Name_of_Driver", TxtDriver.Text);
            cmd.Parameters.AddWithValue("@Plate_Number", TxtPlate.Text);
            cmd.Parameters.AddWithValue("@Address", TxtAddress.Text);
            cmd.Parameters.AddWithValue("@Phone_Number_of_Driver", TxtDriverPhonenumber.Text);
            cmd.Parameters.AddWithValue("@Name_of_Client_Company", TxtCompany.Text);
            cmd.Parameters.AddWithValue("@Name_of_Client", TxtContact.Text);
            cmd.Parameters.AddWithValue("@Phone_Number_of_Client", TxtCompanynumber.Text);
            cmd.Parameters.AddWithValue("@Date_and_Time", DateTime.Parse(DateAndTime.Text));
            cmd.Parameters.AddWithValue("@Name_of_Item", NameItemBox.Text);
            cmd.Parameters.AddWithValue("@Quantity", TxtQuantity.Text);
            cmd.Parameters.AddWithValue("@Size", SizeBox.Text);
            cmd.Parameters.AddWithValue("@Weight", WeightBox.Text);
            cmd.Parameters.AddWithValue("@Remarks", TxtRemarks.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");

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
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_Delivery WHERE Name = @Name_of_Driver) ", con);
            cmd.Parameters.AddWithValue("@Name_of_Driver", TxtDriver.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DeliveryTableView.DataSource = dt;

        }

        private void frmDelivery_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
