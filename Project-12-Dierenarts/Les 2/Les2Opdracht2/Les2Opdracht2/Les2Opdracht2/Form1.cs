﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Les2Opdracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void OverzichtRecepten()
        {
            OleDbConnection conn = new OleDbConnection();
            Globaal.Connection.Open();
            string sql = "SELECT * FROM Recept";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            OleDbDataReader dbread = null;
            dbread = dbcom.ExecuteReader();
            while(dbread.Read())
            {
                lbxOverzicht.Items.Add(dbread.GetValue(1).ToString()
                   + " " + dbread.GetValue(2).ToString()
                   + " " + dbread.GetValue(3).ToString());
            }
            dbread.Close();
            Globaal.Connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OverzichtRecepten();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            
        }

        private void lbxOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            string geselecteerdeItem = lbxOverzicht.SelectedItem.ToString();
        }
    }
}
