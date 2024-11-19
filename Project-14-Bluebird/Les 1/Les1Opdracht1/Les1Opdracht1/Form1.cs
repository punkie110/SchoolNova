using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les1Opdracht1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            lbxOverzicht.DisplayMember = "volledig";
            lbxOverzicht.DataSource = Student.getAll();
            txtAantal.Text = lbxOverzicht.Items.Count.ToString();
        }
    }
}
