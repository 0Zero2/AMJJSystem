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
    public partial class frmDriverDashboard : Form
    {
        public frmDriverDashboard()
        {
            InitializeComponent();
        }

        private void DeliveryPickupBTN_Click(object sender, EventArgs e)
        {
            DrPickupInformation DrP = new DrPickupInformation();
            DrP.Show();
            this.Hide();
        }

        private void ReceiveBTN_Click(object sender, EventArgs e)
        {
            ReceivedInformation RdI = new ReceivedInformation();
            RdI.Show();
            this.Hide();
        }

        private void DrInfoBTN_Click(object sender, EventArgs e)
        {
            frmDr dr = new frmDr();
            dr.Show();
            this.Hide();
        }

        private void frmDriverDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToLongDateString();
            Time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
