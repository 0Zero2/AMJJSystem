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
        string selectedReceiveID = "";
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
                    NccComboBox.Items.Add(nameofcompany);
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
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_Receive (Receive_From,Received_By,Company_Number,Name_of_Client,Client_Phone_Number,Date_and_Time,Item_Name,Quantity,Size,Weight,Remarks) VALUES (@Receive_From,@Received_By,@Company_Number,@Name_of_Client,@Client_Phone_Number,@Date_and_Time,@Item_Name,@Quantity,@Size,@Weight,@Remarks)", con);
            cmd.Parameters.AddWithValue("@Receive_From", RfComboBox.Text);
            cmd.Parameters.AddWithValue("@Received_By", TxtRby.Text);
            cmd.Parameters.AddWithValue("@Company_Number", TxtRbyPn.Text);
            cmd.Parameters.AddWithValue("@Name_of_Client", NccComboBox.Text);
            cmd.Parameters.AddWithValue("@Client_Phone_Number", TxtNccPn.Text);
            cmd.Parameters.AddWithValue("@Date_and_Time", DateTimePicker.Value);
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
            string updateQuery = "UPDATE TBL_Receive SET Received_By = @Received_By, Company_Number = @Company_Number, Name_of_Client = @Name_of_Client, Client_Phone_Number = @Client_Phone_Number, Date_and_Time = @Date_and_Time, Item_Name = @Item_Name, Quantity = @Quantity, Size = @Size, Weight = @Weight, Remarks = @Remarks  WHERE Receive_ID = @Receive_ID";
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Receive_ID", selectedReceiveID);
                    cmd.Parameters.AddWithValue("@Receive_From", RfComboBox.Text);
                    cmd.Parameters.AddWithValue("@Received_By", TxtRby.Text);
                    cmd.Parameters.AddWithValue("@Company_Number", TxtRbyPn.Text);
                    cmd.Parameters.AddWithValue("@Name_of_Client", NccComboBox.Text);
                    cmd.Parameters.AddWithValue("@Client_Phone_Number", TxtNccPn.Text);
                    cmd.Parameters.AddWithValue("@Date_and_Time", DateTimePicker.Value);
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
            string updateQuery = "DELETE FROM TBL_Receive WHERE Receive_ID = @Receive_ID";
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Receive_ID", selectedReceiveID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Deleted Successfully");
                }
                con.Close();
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

        private void NccComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = NccComboBox.GetItemText(NccComboBox.SelectedItem);
            string sql = "SELECT * FROM TBL_ClientCompany WHERE Name_of_Company = '" + value + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            RfComboBox.Items.Clear();
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string CompNum = myreader.GetInt32(2).ToString();
                    string Receivedfrom = myreader.GetString(3);
                    TxtNccPn.Text = CompNum;
                    RfComboBox.Items.Add(Receivedfrom);
                    RfComboBox.SelectedIndex = 0;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = ItemComboBox.GetItemText(ItemComboBox.SelectedItem);
            string sql = "SELECT * FROM TBL_Products WHERE Item_Name = '" + value + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            SizeComboBox.Items.Clear();
            WeightComboBox.Items.Clear();

            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string Volume = myreader.GetString(2);
                    String Weight = myreader.GetString(3);
                    SizeComboBox.Items.Add(Volume);
                    SizeComboBox.SelectedIndex = 0;
                    WeightComboBox.Items.Add(Weight);
                    WeightComboBox.SelectedIndex = 0;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ReceiveDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ReceiveDataGridView.SelectedCells.Count > 0)
            {
                ReceiveDataGridView.CurrentRow.Selected = true;
                selectedReceiveID = ReceiveDataGridView.Rows[e.RowIndex].Cells["Receive_ID"].FormattedValue.ToString();
                RfComboBox.Text = ReceiveDataGridView.Rows[e.RowIndex].Cells["Receive_From"].FormattedValue.ToString();
                NccComboBox.Text = ReceiveDataGridView.Rows[e.RowIndex].Cells["Name_of_Client"].FormattedValue.ToString();
                TxtNccPn.Text = ReceiveDataGridView.Rows[e.RowIndex].Cells["Company_Number"].FormattedValue.ToString();
                TxtRby.Text = ReceiveDataGridView.Rows[e.RowIndex].Cells["Received_By"].FormattedValue.ToString();
                TxtRbyPn.Text = ReceiveDataGridView.Rows[e.RowIndex].Cells["Client_Phone_Number"].FormattedValue.ToString();
                DateTimePicker.Value = DateTime.Parse(ReceiveDataGridView.Rows[e.RowIndex].Cells["Date_and_Time"].FormattedValue.ToString());
                ItemComboBox.Text = ReceiveDataGridView.Rows[e.RowIndex].Cells["Item_Name"].FormattedValue.ToString();
                TxtQuantity.Text = ReceiveDataGridView.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString();
                SizeComboBox.Text = ReceiveDataGridView.Rows[e.RowIndex].Cells["Size"].FormattedValue.ToString();
                WeightComboBox.Text = ReceiveDataGridView.Rows[e.RowIndex].Cells["Weight"].FormattedValue.ToString();
                TxtRemarks.Text = ReceiveDataGridView.Rows[e.RowIndex].Cells["Remarks"].FormattedValue.ToString();
            }

        }
    }
}
