using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustinMunkDoWhileLusOpdracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultaat_Click(object sender, EventArgs e)
        {
            if(rdbPlus.Checked)
            {
                int resultaat = int.Parse(txtGetal1.Text) + int.Parse(txtGetal2.Text);

                txtResultaat.Text = txtGetal1.Text + "+" + txtGetal2.Text + "=" + resultaat;
            }
            else if(rdbMin.Checked) 
            {
                int resultaat = int.Parse(txtGetal1.Text) - int.Parse(txtGetal2.Text);
                txtResultaat.Text = txtGetal1.Text + "-" + txtGetal2.Text + "=" + resultaat;
            }
        }
    }
}
