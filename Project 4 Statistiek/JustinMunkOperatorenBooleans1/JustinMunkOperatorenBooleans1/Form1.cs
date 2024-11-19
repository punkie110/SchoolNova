using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustinMunkOperatorenBooleans1
{
    public partial class Form1 : Form
    {
        bool voldoende;
       

        public Form1()
        {
            
            InitializeComponent();
        }
        //ik heb gelijk geoefend met booleans ook al kon deze opdracht zonder booleans
        private void btnResultaat_Click(object sender, EventArgs e)
        {
            int cijfer = int.Parse(txtCijfer.Text);
            if (cijfer >= 5.5)
            {
                voldoende = true;
               
            }
            else if (cijfer < 5.5)
            {
                voldoende = false;
            }
            if (voldoende)
            {
                txtOutput.Text = "voldoende";
            }
            else if (!voldoende)
            {
                txtOutput.Text = "onvoldoende";
            }
        }
    }
}
