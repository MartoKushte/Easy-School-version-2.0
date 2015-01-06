﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ESIS;
using ESIS.appointment;

namespace ESIS.appointment
{
    public partial class appointdash : Form
    {
        public appointdash()
        {
            InitializeComponent();
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void appointdash_Load(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //Display query
                string Query = "select * from schoolfees.appointment;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);


                // MyConn2.Open﴾﴿;
                //For offline connection we weill use MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                grid1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                // MyConn2.Close﴾﴿;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        private void crappnt_Click(object sender, EventArgs e)
        {
           
        }

        private void addNewAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            appoint_create ac = new appoint_create();
            ac.Show();
        }
    }
}
