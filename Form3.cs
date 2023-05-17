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
        private void DeliveryBTN_Click(object sender, EventArgs e)
        {
            frmDelivery Dr = new frmDelivery();
            Dr.Show();
            this.Hide();
        }

        private void ReceiveBTN_Click(object sender, EventArgs e)
        {
            frmReceive receive = new frmReceive();
            receive.Show();
            this.Hide();
        }

        private void PickupBTN_Click(object sender, EventArgs e)
        {
            frmPickup Pu = new frmPickup();
            Pu.Show();
            this.Hide();
        }
    }
}
