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

        private void btnLaatst_Click(object sender, EventArgs e)
        {
            lbxOverzicht.Items.Clear();
            lbxOverzicht.Items.Add(Student.getLast());
            txtTotaal.Text = lbxOverzicht.Items.Count.ToString();
        }

        private void btnInvoer_Click(object sender, EventArgs e)
        {
            Invoer frm = new Invoer();
            this.Hide();
            frm.Show();
        }

        private void btnEerst_Click(object sender, EventArgs e)
        {
            lbxOverzicht.Items.Clear();
            lbxOverzicht.Items.Add(Student.getFirst());
            txtTotaal.Text = lbxOverzicht.Items.Count.ToString();
        }
    }
}
