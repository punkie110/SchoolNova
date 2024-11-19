using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les4opdracht1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeenReservering_Click(object sender, EventArgs e)
        {
            lbxOverzicht.DisplayMember = "Totaal";
            lbxOverzicht.DataSource = Reservering.getAvailable();
            txtTotaal.Text = lbxOverzicht.Items.Count.ToString();
        }

        private void btnReservering_Click(object sender, EventArgs e)
        {
            lbxOverzicht.DisplayMember = "Totaal";
            lbxOverzicht.DataSource = Reservering.getOccupied();
            txtTotaal.Text = lbxOverzicht.Items.Count.ToString();
        }
    }
}
