﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JLes2Opdracht1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbxKlas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            lbxOverzicht.DisplayMember = "volledig";
            lbxOverzicht.DataSource = Student.getAll();
            txtAantal.Text = lbxOverzicht.Items.Count.ToString();
        }

        private void btnInvoer_Click(object sender, EventArgs e)
        {
            Invoer frm = new Invoer();
            this.Hide();
            frm.Show();
        }

        private void txtAantal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAantalStudenten_Click(object sender, EventArgs e)
        {

        }

        private void lbxOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}