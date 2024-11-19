using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Bluebird
{
     class Passagier
    {
        public string Naam { get; set; }

        //een Insert functie om een passagier toe te voegen aan de database.
        public void Insert()
        {
            Passagier passagier = new Passagier();
            try
            {
                Globaal.Connection.Open();
               // de insert into query die waardes toevoegd aan de database.

                    string sql = "INSERT INTO Passagier (Naam) VALUES (@Naam)";
                    OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
                    //er zijn hier parameters gemaakt voor extra beveiliging
                    //door de AddWithValue command geef je de parameters de waarde mee.
                    dbcom.Parameters.AddWithValue("@Naam", Naam);

                    dbcom.ExecuteNonQuery();
                    dbcom.Dispose();
                    Globaal.Connection.Close();
            }
            catch (Exception ex)
            {
                Globaal.Connection.Close();
            }
            return;
        }
        //een getlast functie om de laatst toegevoegde passagier op te halen uit de database.
        public static int getLast()
        {
            int passagierId = 0;

            OleDbDataReader dbread = null;
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();

            string sql = "SELECT last(Passagiernr) as id FROM Passagier";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                passagierId = (int)dbread["id"];
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return passagierId;
        }
        //een delete functie om de geselecteerde passagier uit de database te verwijderen.
        public static void delete(int id)
        {
            Globaal.Connection.Open();

            string sql = "DELETE FROM Passagier WHERE [Passagiernr] = @passagiernr";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            dbcom.Parameters.AddWithValue("@passagiernr", id);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            Globaal.Connection.Close();

        }
    }
}
