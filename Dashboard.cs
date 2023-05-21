using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMJJSystem
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        private void ReceiveBTN_Click(object sender, EventArgs e)
        {
            frmReceive receive = new frmReceive();
            receive.Show();
            this.Hide();
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToLongDateString();
            Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void DeliveryPickupBTN_Click(object sender, EventArgs e)
        {
            frmDelivery Dr = new frmDelivery();
            Dr.Show();
            this.Hide();
        }

        private void CompanyBTN_Click(object sender, EventArgs e)
        {

        }

        private void DriverBTN_Click(object sender, EventArgs e)
        {

        }

        private void ItemBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
