using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Opdracht             : 1.2 Spoor alle gebreken en fouten op en los deze op
//
//Software developer    : Yildiz Kurt
//Datum                 : 4 juli 2023

namespace YildizKurtLes1Boolean1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BUTTON_Click(object sender, EventArgs e)
        {
            {
                int getalA = int.Parse(txtGetalA.Text);
                int getalB = int.Parse(txtGetalB.Text);

                int getalC = int.Parse(txtGetalC.Text);
                int getalD = int.Parse(txtGetalD.Text);

                bool isGroter = false;
                bool isKleiner = false;

                if (getalA > getalB)
                {
                    isGroter = true;
                }
                if (getalC < getalD)
                {
                    isKleiner = true;
                }
                if (isGroter)
                {
                    txtResGroter.Text = "true";
                }
                else
                {
                    txtResGroter.Text = "false";
                }
                if (isKleiner)
                {
                    txtResKleiner.Text = "true";
                }
                else
                {
                    txtResKleiner.Text = "false";
                }
            }
        }

        private void hallo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
