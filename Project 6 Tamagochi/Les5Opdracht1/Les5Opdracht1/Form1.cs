using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les5Opdracht1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            int score = int.Parse(txtScore.Text);
            if (score > 50 && score <= 100)
            {
                pictureBox1.Image = Properties.Resources.BramEureka;
                pictureBox1.Refresh();
            }
            else if (score > 0 && score <= 50)
            {
                pictureBox1.Image = Properties.Resources.BramAngy;
                pictureBox1.Refresh();
            }
            else { }
        }
    }
}


