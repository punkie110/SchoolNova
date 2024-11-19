using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Bluebird
{
     class Reservering
    {
        public int Passagierid { get; set; }

        public int Stoelid { get; set; }

        //een Insert functie die een reservering toevoegd aan de database.
        public void Insert()
        {
            try
            {
                Globaal.Connection.Open();
                //de insert into query die waardes toevoegd aan de database.
                string sql = "INSERT INTO Reservering (Passagierid, Stoelid) " +
               " VALUES (@Passagierid, @Stoelid)";
                OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
                //er zijn hier parameters gemaakt voor extra beveiliging
                //door de AddWithValue command geef je de parameters de waarde mee.
                dbcom.Parameters.AddWithValue("@Passagierid", Passagierid);
                dbcom.Parameters.AddWithValue("@Stoelid", Stoelid);

                dbcom.ExecuteNonQuery();
                dbcom.Dispose();
                Globaal.Connection.Close();

            }
            catch (Exception ex)
            {
                Globaal.Connection.Close();
                return;
            }
        }

        //een check functie die checkt of er al een reservering is op de stoel. 
        public static bool check(int stoelid)
        {
            Globaal.Connection.Open();
            string checkSql = "SELECT COUNT(*) FROM Reservering WHERE Stoelid = @stoelid";
            OleDbCommand checkCommand = new OleDbCommand(checkSql, Globaal.Connection);
            checkCommand.Parameters.AddWithValue("@stoelid", stoelid);

            int count = (int)checkCommand.ExecuteScalar();

            if (count == 0)
            {
                Globaal.Connection.Close();
                return true;
            }
            Globaal.Connection.Close();
            return false;

        }
        //een delete functie die een reservering verwijderd uit de database.
        public static void delete(int id)
        {
            Globaal.Connection.Open();

            string sql = "DELETE FROM Reservering WHERE [Passagierid] = @passagierid";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            dbcom.Parameters.AddWithValue("@passagierid", id);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            Globaal.Connection.Close();

        }
    }
}
