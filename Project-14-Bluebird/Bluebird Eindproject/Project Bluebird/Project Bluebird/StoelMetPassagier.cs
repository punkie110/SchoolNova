using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Bluebird
{
    public class StoelMetPassagier
    {
        public int StoelNr { get; set; }
        public string StoelNaam { get; set; }
        public string PassagierNaam { get; set; }

        public int PassagierNummer { get; set; }
     
        //Totaal combineert de stoelnaam en passagiernaam.
        public string Totaal { get {  return StoelNaam + " " + PassagierNaam ; } }

        //een Get all funcite die alle stoelen met passagiers ophaalt uit de database.
        public static List<StoelMetPassagier> GetAll()
        {
            List<StoelMetPassagier> list = new List<StoelMetPassagier>();
            OleDbDataReader dbread = null;
            Globaal.Connection.Open();
            string sql = "SELECT Stoel.Stoelnr, Stoel.Stoelnaam, Passagier.Naam, Passagier.Passagiernr FROM (Stoel LEFT JOIN Reservering ON Stoel.Stoelnr = Reservering.Stoelid) LEFT JOIN Passagier ON Passagier.Passagiernr = Reservering.Passagierid";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                StoelMetPassagier stoelMetPassagier = new StoelMetPassagier();
                stoelMetPassagier.StoelNr = (int)dbread["Stoelnr"];
                stoelMetPassagier.StoelNaam = (string)dbread["Stoelnaam"];
                stoelMetPassagier.PassagierNummer = dbread["Passagiernr"] != DBNull.Value ? (int)dbread["Passagiernr"] : 0;
                if (dbread["Naam"] != DBNull.Value)
                {
                    stoelMetPassagier.PassagierNaam = (string)dbread["Naam"];
                }
                else
                {
                    stoelMetPassagier.PassagierNaam = "Vrij";
                }
                list.Add(stoelMetPassagier);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }

        //een getbyklasse functie die alle stoelen met passagiers ophaalt uit de database waarvan de klasse overeenkomt.
        public static List<StoelMetPassagier> GetByKlasse(int klasse)
        {
            List<StoelMetPassagier> list = new List<StoelMetPassagier>();
            OleDbDataReader dbread = null;
            Globaal.Connection.Open();
            string sql = "SELECT Stoel.Stoelnr, Stoel.Stoelnaam, Passagier.Naam, Passagier.Passagiernr FROM (Stoel LEFT JOIN Reservering ON Stoel.Stoelnr = Reservering.Stoelid) LEFT JOIN Passagier ON Passagier.Passagiernr = Reservering.Passagierid WHERE Stoel.Klasse = @Klasse";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbcom.Parameters.AddWithValue("@Klasse", klasse);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                StoelMetPassagier stoelMetPassagier = new StoelMetPassagier();
                stoelMetPassagier.StoelNr = (int)dbread["Stoelnr"];
                stoelMetPassagier.StoelNaam = (string)dbread["Stoelnaam"];
                stoelMetPassagier.PassagierNummer = dbread["Passagiernr"] != DBNull.Value ? (int)dbread["Passagiernr"] : 0;
                if (dbread["Naam"] != DBNull.Value)
                {
                    stoelMetPassagier.PassagierNaam = (string)dbread["Naam"];
                }
                else
                {
                    stoelMetPassagier.PassagierNaam = "Vrij";
                }
                list.Add(stoelMetPassagier);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }

        //een getbyId functie die alle stoelen met passagiers ophaalt uit de database waarvan de ID overeenkomt.
        public static StoelMetPassagier GetById(int id)
        {
            StoelMetPassagier stoelMetPassagier = new StoelMetPassagier();
            OleDbDataReader dbread = null;
            Globaal.Connection.Open();
            string sql = "SELECT Stoel.Stoelnr, Stoel.Stoelnaam, Passagier.Naam, Passagier.Passagiernr FROM (Stoel LEFT JOIN Reservering ON Stoel.Stoelnr = Reservering.Stoelid) LEFT JOIN Passagier ON Passagier.Passagiernr = Reservering.Passagierid WHERE Reservering.Passagierid = @id";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbcom.Parameters.AddWithValue("@id", id);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                stoelMetPassagier.StoelNr = (int)dbread["Stoelnr"];
                stoelMetPassagier.StoelNaam = (string)dbread["Stoelnaam"];
                stoelMetPassagier.PassagierNummer = dbread["Passagiernr"] != DBNull.Value ? (int)dbread["Passagiernr"] : 0;
                if (dbread["Naam"] != DBNull.Value)
                {
                    stoelMetPassagier.PassagierNaam = (string)dbread["Naam"];
                }
                else
                {
                    stoelMetPassagier.PassagierNaam = "Vrij";
                }
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return stoelMetPassagier;
        }
    }

  
}
