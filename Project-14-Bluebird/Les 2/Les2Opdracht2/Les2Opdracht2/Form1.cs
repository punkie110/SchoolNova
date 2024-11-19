using JLes2Opdracht1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les2Opdracht2
{
   
    public partial class Form1 : Form
    {
        public string klasSelected;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvoer_Click(object sender, EventArgs e)
        {
            Invoer frm = new Invoer();
            this.Hide();
            frm.Show();
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            lbxOverzicht.DataSource = Student.getAll();
            lbxOverzicht.DisplayMember = "volledig";
            txtAantal.Text = lbxOverzicht.Items.Count.ToString();
        }

        private void rdbA01_CheckedChanged(object sender, EventArgs e)
        {
            klasSelected = "SBICOAO1";
            lbxOverzicht.DataSource = Student.select(klasSelected);
            lbxOverzicht.DisplayMember = "volledig";
            txtAantal.Text = lbxOverzicht.Items.Count.ToString();
        }

        private void rdbA02_CheckedChanged(object sender, EventArgs e)
        {
            klasSelected = "SBICOAO2";
            lbxOverzicht.DataSource = Student.select(klasSelected);
            lbxOverzicht.DisplayMember = "volledig";
            txtAantal.Text = lbxOverzicht.Items.Count.ToString();
        }

        private void rdbA03_CheckedChanged(object sender, EventArgs e)
        {
            klasSelected = "SBICOAO3";
            lbxOverzicht.DataSource = Student.select(klasSelected);
            lbxOverzicht.DisplayMember = "volledig";
            txtAantal.Text = lbxOverzicht.Items.Count.ToString();
        }
    }
}
