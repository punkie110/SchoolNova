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
    public partial class ToevoegenBehandeling : Form
    {
        private int klantId;
        public ToevoegenBehandeling(int klantId)
        {
            InitializeComponent();
            this.klantId = klantId;
        }
        private void voegBehandelingToe()
        {
            int selectedItem = ((Behandeling)clbBehandelingen.SelectedItem).Id;
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();
            //de insert into query die waardes toevoegd aan de database.
            string sql = "INSERT INTO behandelregel (klantid,behandelingscode)" +
                " VALUES (@klantId, @behandelingsCode)";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            //er zijn hier parameters gemaakt voor extra beveiliging
            //door de AddWithValue command geef je de parameters de waarde mee.
            dbcom.Parameters.AddWithValue("@klantid", klantId);
            dbcom.Parameters.AddWithValue("@behandelingsCode", selectedItem);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            Globaal.Connection.Close();
            MessageBox.Show("Ingevoerd");
            TonenKlantgegevens frm = new TonenKlantgegevens();
            this.Close();
            frm.Show();

        }
        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            voegBehandelingToe();
        }
        private void ToonBehandelingen()
        {
            foreach (Behandeling behandeling in Behandeling.GetAll())
            {
                clbBehandelingen.Items.Add(behandeling);
            }
        }
        private void ToevoegenBehandeling_Load(object sender, EventArgs e)
        {
            ToonBehandelingen();
        }
    }
}
