using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les1Opdracht2
{
    public partial class Invoer : Form
    {
        public Invoer()
        {
            InitializeComponent();
        }

        private void btnVoerIn_Click(object sender, EventArgs e)
        {

            Student.addStudent(txtVoornaam.Text,txtAchternaam.Text, int.Parse(txtStudentnr.Text),txtKlas.Text);
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
