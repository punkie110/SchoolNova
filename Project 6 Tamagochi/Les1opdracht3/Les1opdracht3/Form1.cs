using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les1opdracht3
{
    public partial class Form1 : Form
    {
        int getal = 3;
        bool printGetal  = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            printGetal = true;
            if(printGetal)
            {
                MessageBox.Show("" + getal);
            }
        }
    }
}
