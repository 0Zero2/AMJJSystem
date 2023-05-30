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
    public partial class frmClientCompany : Form
    {
        public frmClientCompany()
        {
            InitializeComponent();
        }

        private void ClientCompany_Load(object sender, EventArgs e)
        {

        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            frmDashboard Db = new frmDashboard();
            Db.Show();
            this.Hide();
        }
    }
}
