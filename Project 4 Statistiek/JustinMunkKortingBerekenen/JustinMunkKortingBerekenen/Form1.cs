using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustinMunkKortingBerekenen
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
      
        private void btnBereken_Click(object sender, EventArgs e)
        {
            double bedrag = double.Parse(txtBedrag.Text);
            double percentage = double.Parse(txtPercentage.Text);
            double rekenbaarPercentage = percentage / 100;
            if (percentage <= 100)
            {
                txtNieuwBedrag.Text = (rekenbaarPercentage * bedrag).ToString();
            }
            else
            {
                MessageBox.Show("Voer een geldig percentage in!");
            }
        }
    }
}
