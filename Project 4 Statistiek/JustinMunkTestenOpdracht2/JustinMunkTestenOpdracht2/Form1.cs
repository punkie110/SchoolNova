using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustinMunkTestenOpdracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultaat_Click(object sender, EventArgs e)
        {
            try
            {


                if (int.Parse(txtGroterDan1.Text) > int.Parse(txtGroterDan2.Text))
                {
                    txtGroterDanTrueFalse.Text = "true";
                }
                else
                {
                    txtGroterDanTrueFalse.Text = "false";
                }
                if (int.Parse(txtKleinerDan1.Text) < int.Parse(txtKleinerDan2.Text))
                {
                    txtKleinerDanTrueFalse.Text = "true";
                }
                else
                {
                    txtKleinerDanTrueFalse.Text = "false";
                }
                if (int.Parse(txtAnd1.Text) == int.Parse(txtAnd2.Text))
                {
                    txtAndTrueFalse.Text = "true";
                }
                else
                {
                    txtAndTrueFalse.Text = "false";
                }
                if (int.Parse(txtOr1.Text) != int.Parse(txtOr2.Text))
                {
                    txtOrTrueFalse.Text = "true";
                }
                else
                {
                    txtOrTrueFalse.Text = "false";
                }
            }
            catch
            {
                MessageBox.Show("Er is een fout opgetreden");
            }
        }
    }
}
