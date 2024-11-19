using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustinMunkTestenOpdracht3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdvies_Click(object sender, EventArgs e)
        {
            try
            {
                int eersteWaarde = int.Parse(txtBeginwaarde.Text);
                int tweedeWaarde = int.Parse(txtEindwaarde.Text);
             if(rdbFor.Checked)
                {
                    lbxWaarden.Items.Clear();
                    lbxWaarden.Items.Add("for (int i = " + eersteWaarde + "; i < " + tweedeWaarde + "; i++)");
                    lbxWaarden.Items.Add("{");
                    lbxWaarden.Items.Add("}");
                }
             else if(rdbWhile.Checked)
                {
                    lbxWaarden.Items.Clear();
                    lbxWaarden.Items.Add("int i = " + eersteWaarde + ";");
                    lbxWaarden.Items.Add("while (i < " + tweedeWaarde + ")");
                    lbxWaarden.Items.Add("{");
                    lbxWaarden.Items.Add("i++;");
                    lbxWaarden.Items.Add("}");
                }
            }
            catch
            {
                MessageBox.Show("Voer een (geldige) waarde in.");
            }
        }
    }
}
