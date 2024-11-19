using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Opdracht             : 1.3 Spoor alle gebreken en fouten op & los deze op
//
//Software developer    : Yildiz Kurt
//Datum                 : 4 juli 2023

namespace NaamStudent___Les2Operatoren1
{
    public partial class frmYildizKurtOpdrachtOperatoren1 : Form
    {
        public frmYildizKurtOpdrachtOperatoren1()
        {
            InitializeComponent();
        }

        private void btnResultaat_Click(object sender, EventArgs e)
        {
            int getalA = int.Parse(txtGetal1.Text);
            int getalB = int.Parse(txtGetal2.Text);
            int totaal = 0;
            if (rdbOptellen.Checked)
            {
                totaal = getalA + getalB;

            }
            else if (rdbAftrekken.Checked)
            {
                totaal = getalA - getalB;

            }
            lbxResultaten.Items.Add(totaal);
        }

        private void rbnOptellen_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
