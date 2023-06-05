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
    public partial class frmReceive : Form
    {
        public frmReceive()
        {
            InitializeComponent();
            FillComboBox();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCBSOSP\\SQLEXPRESS;Initial Catalog=DB_Receive;Integrated Security=True");
        private void CreateBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_Receive (Receive_From,Received_By,Plate_Number,Name_of_Client_Company,Phone_Number_of_Client,Date_and_Time,Name_of_Item,Quantity,Size,Weight,Remarks) VALUES (@Receive_From,@Received_By,@Plate_Number,@Name_of_Client_Company,@Phone_Number_of_Client,@Date_and_Time,@Phone_Number_of_Client,@Date_and_Time,@Name_of_Item,@Quantity,@Size,@Weight,@Remarks)", con);
            cmd.Parameters.AddWithValue("@Receive_From", ReceivefrmComboBox.Text);
            cmd.Parameters.AddWithValue("@Received_By", TxtReceiveby.Text);
            cmd.Parameters.AddWithValue("@Plate_Number", TxtPlate.Text);
            cmd.Parameters.AddWithValue("@Name_of_Client_Company", NameofClientComboBox.Text);
            cmd.Parameters.AddWithValue("@Phone_Number_of_Client", TxtClientPhone.Text);
            cmd.Parameters.AddWithValue("@Date_and_Time", DateAndTime.Text);
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
            string updateQuery = "UPDATE TBL_Receive SET Received_By = @Received_By, Plate_Number = @Plate_Number, Name_of_Client_Company = @Name_of_Client_Company, Phone_Number_of_Client = @Phone_Number_of_Client, Date_and_Time = @Date_and_Time, Name_of_Item = @Name_of_Item, Quantity = @Quantity, Size = @Size, Weight = @Weight, Remarks = @Remarks  WHERE Receive_From = @Receive_From";
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Receive_From", ReceivefrmComboBox.Text);
                    cmd.Parameters.AddWithValue("@Received_By", TxtReceiveby.Text);
                    cmd.Parameters.AddWithValue("@Plate_Number", TxtPlate.Text);
                    cmd.Parameters.AddWithValue("@Name_of_Client_Company", NameofClientComboBox.Text);
                    cmd.Parameters.AddWithValue("@Phone_Number_of_Client", TxtClientPhone.Text);
                    cmd.Parameters.AddWithValue("@Date_and_Time", DateAndTime.Text);
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
            string updateQuery = "DELETE FROM TBL_Receive WHERE Receive_From = @Receive_From";
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Receive_From", ReceivefrmComboBox.Text);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_Receive", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ReceiveTableView.DataSource = dt;

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
                    string sname = myreader.GetString(1);
                    NameofClientComboBox.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmReceive_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_Receive", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ReceiveTableView.DataSource = dt;
            con.Close();

            DPlistView.View = View.Details;

            DPlistView.Columns.Add("Item", 150);
            DPlistView.Columns.Add("Quantity", 150);
            DPlistView.Columns.Add("Size", 150);
            DPlistView.Columns.Add("Weight", 150);
        }
        private void ReceiveTableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ReceiveTableView.SelectedCells.Count > 0)
            {
                ReceiveTableView.CurrentRow.Selected = true;
                ReceivefrmComboBox.Text = ReceiveTableView.Rows[e.RowIndex].Cells["Receive_From"].FormattedValue.ToString();
                TxtReceiveby.Text = ReceiveTableView.Rows[e.RowIndex].Cells["Received_By"].FormattedValue.ToString();
                TxtPlate.Text = ReceiveTableView.Rows[e.RowIndex].Cells["Plate_Number"].FormattedValue.ToString();
                NameofClientComboBox.Text = ReceiveTableView.Rows[e.RowIndex].Cells["Name_of_Client_Company"].FormattedValue.ToString();
                TxtClientPhone.Text = ReceiveTableView.Rows[e.RowIndex].Cells["Phone_Number_of_Client"].FormattedValue.ToString();
                DateAndTime.Text = ReceiveTableView.Rows[e.RowIndex].Cells["Date_and_Time"].FormattedValue.ToString();
                NameItemBox.Text = ReceiveTableView.Rows[e.RowIndex].Cells["Name_of_Item"].FormattedValue.ToString();
                TxtQuantity.Text = ReceiveTableView.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString();
                SizeBox.Text = ReceiveTableView.Rows[e.RowIndex].Cells["Size"].FormattedValue.ToString();
                WeightBox.Text = ReceiveTableView.Rows[e.RowIndex].Cells["Weight"].FormattedValue.ToString();
                TxtRemarks.Text = ReceiveTableView.Rows[e.RowIndex].Cells["Remarks"].FormattedValue.ToString();
            }
        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_Receive", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReceiveTableView.DataSource = dt;
            con.Close();
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            frmDashboard Db = new frmDashboard();
            Db.Show();
            this.Hide();
        }

        private void NameofClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from TBL_ClientCompany where Name_of_Company = '" + NameofClientComboBox + "';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string drivername = myreader.GetString(0);
                    string phonenumber = myreader.GetInt32(1).ToString();
                    string platenumber = myreader.GetString(2);
                    string contactperson = myreader.GetString(3);
                    string contactnumber = myreader.GetInt32(4).ToString();
                    DriverComboBox.Text = drivername;
                    TxtDriverPhonenumber.Text = phonenumber;
                    TxtPlate.Text = platenumber;
                    TxtContact.Text = contactperson;
                    TxtCompanynumber.Text = contactnumber;
                }
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

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DPlistView.Items.Clear();
        }
    }
}













