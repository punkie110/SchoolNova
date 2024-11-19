using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OefenopdrachtKaartjes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCijfer_Click(object sender, EventArgs e)
        {
            int score = int.Parse(txtScore.Text);
            int lWaarde = int.Parse(txtLwaarde.Text);
            int nWaarde = int.Parse(txtNwaarde.Text);
            int cijfer = (90 * score) / lWaarde + 10 * nWaarde;
            txtCSE.Text = cijfer.ToString();
        }
    }
}
