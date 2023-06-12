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
    public partial class DrPickupInformation : Form
    {
        public DrPickupInformation()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G0J1RVI\\SQLEXPRESS;Initial Catalog=DB_DeliveryPickup;Integrated Security=True");
        private void DrPickupInformation_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_Delivery", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            DriverInfoTableView.DataSource = dt;
        }
        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Name_of_Client_Company LIKE '%{0}%'");
            }
        }
    }
}
