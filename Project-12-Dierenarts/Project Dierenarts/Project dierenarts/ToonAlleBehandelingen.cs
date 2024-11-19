using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_dierenarts
{
    public partial class ToonAlleBehandelingen : Form
    {
        public ToonAlleBehandelingen()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            TonenKlantgegevens frm = new TonenKlantgegevens();
            this.Close();
            frm.Show();
        }

        private void ToonAlleBehandelingen_Load(object sender, EventArgs e)
        {
            {
                foreach (Behandeling behandeling in Behandeling.GetAll())
                {
                    lbxAlleBehandelingen.Items.Add(behandeling);
                }
            }
        }
    }
}
