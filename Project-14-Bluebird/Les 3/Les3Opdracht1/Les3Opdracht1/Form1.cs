using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les3Opdracht1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlle_Click(object sender, EventArgs e)
        {
            lbxOverzicht.DisplayMember = "KluisNr";
            lbxOverzicht.DataSource = Kluis.getAll();
            txtTotaleKluizen.Text = lbxOverzicht.Items.Count.ToString();
        }

        private void btnBeschikbaar_Click(object sender, EventArgs e)
        {
            lbxOverzicht.DisplayMember = "KluisNr";
            lbxOverzicht.DataSource = Kluis.getAvailable();
            txtTotaleKluizen.Text = lbxOverzicht.Items.Count.ToString();
        }

        private void btnGereserveerd_Click(object sender, EventArgs e)
        {
                lbxOverzicht.DisplayMember = "KluisNr";
                lbxOverzicht.DataSource = Kluis.getOccupied();
                txtTotaleKluizen.Text = lbxOverzicht.Items.Count.ToString();
        }

        private void btnInvoer_Click(object sender, EventArgs e)
        {
            Invoer frm = new Invoer();
            this.Hide();
            frm.Show();
        }
    }
}
