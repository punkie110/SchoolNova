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

namespace Project_dierenarts
{
    
    public partial class TonenBehandelingen : Form
    {
        private int klantId;

        public TonenBehandelingen(int klantId)
        {
            this.klantId = klantId;

            InitializeComponent();
        }
        //een button die de gebruiker terug laat gaan naar de lijst met klantgegevens
        private void btnTerug_Click(object sender, EventArgs e)
        {
            TonenKlantgegevens frm = new TonenKlantgegevens();
            this.Close();
            frm.Show();
        }
        public void lijstBehandelingen(int klantId)
        {
                lbxBehandelingen.DataSource = Behandeling.GetByKlantId(klantId);
        }
        //toont de behandelingen 
        private void TonenBehandelingen_Load(object sender, EventArgs e)
        {
            lijstBehandelingen(klantId);
        }
    
    }
}
