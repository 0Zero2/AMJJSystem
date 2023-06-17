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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace AMJJSystem
{
    public partial class frmReceive : Form
    {
        public frmReceive()
        {
            InitializeComponent();
            FillComboBox();
            fillComboProduct();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G0J1RVI\\SQLEXPRESS;Initial Catalog=DB_RPDC;Integrated Security=True");
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_Receive", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ReceiveDataGridView.DataSource = dt;
        }
        void FillComboBox()
        {
            string sql = "select * from TBL_ClientCompany";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string nameofcompany = myreader.GetString(1);
                    NccComboBox.Items.Add(nameofcompany);
                }
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
                    ItemComboBox.Items.Add(nameofProduct);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void add(String item, String quantity, String size, String weight)
        {
            string[] row = { item, quantity, size, weight };
            ListViewItem items = new ListViewItem(row);

            ItemReceivedListView.Items.Add(items);
        }
        private void HomeBTN_Click(object sender, EventArgs e)
        {
            frmUserDashboard Db = new frmUserDashboard();
            Db.Show();
            this.Hide();
        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_Receive (Receive_From,Received_By,PhoneNumber,Name_of_Client,Phone_Number,Date_and_Time,Item_Name,Quantity,Size,Weight,Remarks) VALUES (@Receive_From,@Received_By,PhoneNumber,@Name_of_Client,@Phone_Number,@Date_and_Time,@Item_Name,@Quantity,@Size,@Weight,@Remarks)", con);
            cmd.Parameters.AddWithValue("@Receive_From", RfComboBox.Text);
            cmd.Parameters.AddWithValue("@Received_By", TxtRby.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", TxtRbyPn.Text);
            cmd.Parameters.AddWithValue("@Name_of_Client", NccComboBox.Text);
            cmd.Parameters.AddWithValue("@Phone_Number", TxtNccPn.Text);
            cmd.Parameters.AddWithValue("@Date_and_Time", DateTimePicker.Text);
            cmd.Parameters.AddWithValue("@Item_Name", ItemComboBox.Text);
            cmd.Parameters.AddWithValue("@Quantity", TxtQuantity.Text);
            cmd.Parameters.AddWithValue("@Size", SizeComboBox.Text);
            cmd.Parameters.AddWithValue("@Weight", WeightComboBox.Text);
            cmd.Parameters.AddWithValue("@Remarks", TxtRemarks.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            BindData();
            MessageBox.Show("Created Successfully");

        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_Receive", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReceiveDataGridView.DataSource = dt;
            con.Close();
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE TBL_Receive SET Received_By = @Received_By, PhoneNumber = @PhoneNumber, Name_of_Client = @Name_of_Client, Phone_Number = @Phone_Number, Date_and_Time = @Date_and_Time, Item_Name = @Item_Name, Quantity = @Quantity, Size = @Size, Weight = @Weight, Remarks = @Remarks  WHERE Receive_From = @Receive_From";
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Receive_From", RfComboBox.Text);
                    cmd.Parameters.AddWithValue("@Received_By", TxtRby.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", TxtRbyPn.Text);
                    cmd.Parameters.AddWithValue("@Name_of_Client", NccComboBox.Text);
                    cmd.Parameters.AddWithValue("@Phone_Number", TxtNccPn.Text);
                    cmd.Parameters.AddWithValue("@Date_and_Time", DateTimePicker.Text);
                    cmd.Parameters.AddWithValue("@Item_Name", ItemComboBox.Text);
                    cmd.Parameters.AddWithValue("@Quantity", TxtQuantity.Text);
                    cmd.Parameters.AddWithValue("@Size", SizeComboBox.Text);
                    cmd.Parameters.AddWithValue("@Weight", WeightComboBox.Text);
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
            string updateQuery = "DELETE FROM TBL_Receive WHERE Receive_From = @Receive_From";
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Receive_From", RfComboBox.Text);
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

        private void AddBTN_Click(object sender, EventArgs e)
        {
            add(ItemComboBox.SelectedItem.ToString(), TxtQuantity.Text, SizeComboBox.SelectedItem.ToString(), WeightComboBox.SelectedItem.ToString());
        }
        private void frmReceive_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_Receive", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ReceiveDataGridView.DataSource = dt;
            con.Close();

            ItemReceivedListView.View = View.Details;
            ItemReceivedListView.Columns.Add("Item", 150);
            ItemReceivedListView.Columns.Add("Quantity", 150);
            ItemReceivedListView.Columns.Add("Size", 150);
            ItemReceivedListView.Columns.Add("Weight", 150);

        }
    }
}
