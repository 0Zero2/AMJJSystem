﻿using System;
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
    public partial class frmDr : Form
    {
        public frmDr()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G0J1RVI\\SQLEXPRESS;Initial Catalog=DB_ClientCompany;Integrated Security=True");
        private void Driver_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_ClientCompany", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DriverInfoTableView.DataSource = dt;
            con.Close();
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            frmDriverDashboard Db = new frmDriverDashboard();
            Db.Show();
            this.Hide();
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TBL_ClientCompany WHERE Name_of_Company LIKE '" + TxtSearch.Text + "%'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DriverInfoTableView.DataSource = dt;
            con.Close();
        }
    }
}
