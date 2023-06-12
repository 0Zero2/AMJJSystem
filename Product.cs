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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G0J1RVI\\SQLEXPRESS;Initial Catalog=DB_Products;Integrated Security=True");
        string selectedItemID = "";
        private void HomeBTN_Click(object sender, EventArgs e)
        {
            frmUserDashboard Db = new frmUserDashboard();
            Db.Show();
            this.Hide();
        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_Products (Name_of_Item, Size, Weight) VALUES (@Name_of_Item, @Size, @Weight)", con);
            cmd.Parameters.AddWithValue("@Name_of_Item", TxtNameOfItem.Text);
            cmd.Parameters.AddWithValue("@Size", TxtSize.Text);
            cmd.Parameters.AddWithValue("@Weight", TxtWeight.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            BindData();
            MessageBox.Show("Created Successfully");
        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_Products", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CompProductTableView.DataSource = dt;
            con.Close();
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE TBL_Products SET Name_of_Item = @Name_of_Item, Size = @Size, Weight = @Weight WHERE Item_ID = @Item_ID";
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Item_ID", selectedItemID);
                    cmd.Parameters.AddWithValue("@Name_of_Item", TxtNameOfItem.Text);
                    cmd.Parameters.AddWithValue("@Size", TxtSize.Text);
                    cmd.Parameters.AddWithValue("@Weight", TxtWeight.Text);
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
            string updateQuery = "DELETE FROM TBL_Products WHERE Item_ID = @Item_ID";
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Company_ID", selectedItemID);
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

        private void CompProductTableView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CompProductTableView.SelectedCells.Count > 0)
            {
                CompProductTableView.CurrentRow.Selected = true;
                selectedItemID = CompProductTableView.Rows[e.RowIndex].Cells["Item_ID"].FormattedValue.ToString();
                TxtNameOfItem.Text = CompProductTableView.Rows[e.RowIndex].Cells["Name_of_Item"].FormattedValue.ToString();
                TxtSize.Text = CompProductTableView.Rows[e.RowIndex].Cells["Size"].FormattedValue.ToString();
                TxtWeight.Text = CompProductTableView.Rows[e.RowIndex].Cells["Weight"].FormattedValue.ToString();
            }
        }
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_Products", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CompProductTableView.DataSource = dt;
        }
    }
}
