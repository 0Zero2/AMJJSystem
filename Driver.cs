﻿using System;
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
    public partial class frmDriver : Form
    {
        public frmDriver()
        {
            InitializeComponent();
        }

        private void Driver_Load(object sender, EventArgs e)
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
