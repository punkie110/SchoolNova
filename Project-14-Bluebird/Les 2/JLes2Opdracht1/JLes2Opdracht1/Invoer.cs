using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JLes2Opdracht1
{
    public partial class Invoer : Form
    {
        public Invoer()
        {
            InitializeComponent();
        }
        private void Invoer_Load(object sender, EventArgs e)
        {
            
            cbxKlas.Items.Clear();
            foreach (Klas klas in Klas.getAll())
            {
     
                cbxKlas.Items.Add(klas.Klascode);
            }
          

        }
        private void btnInvoer_Click(object sender, EventArgs e)
        {
            Student.addStudent(txtVoornaam.Text, txtAchternaam.Text, int.Parse(txtStudentnr.Text), (string)cbxKlas.SelectedItem);
                Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void cbxKlas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentnr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVoornaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAchternaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAchternaam_Click(object sender, EventArgs e)
        {

        }

        private void lblVoornaam_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentNummer_Click(object sender, EventArgs e)
        {

        }

        private void lblKlas_Click(object sender, EventArgs e)
        {

        }
    }
}
