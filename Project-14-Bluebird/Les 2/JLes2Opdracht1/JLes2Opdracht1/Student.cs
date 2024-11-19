using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JLes2Opdracht1
{
    class Student
    {
        public int Studentid { get; set; }
        public int Studentnummer { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Klascode { get; set; }
        public string volledig { get { return Studentnummer + " " + Voornaam + " " + Achternaam + " " + Klascode; } }

        public static List<Student> getAll()
        {
            List<Student> list = new List<Student>();
            OleDbDataReader dbread = null;
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();

            string sql = "SELECT * FROM Student";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                Student student = new Student();
                student.Studentid = (int)dbread.GetValue(0);
                student.Studentnummer = (int)dbread.GetValue(1);
                student.Voornaam = dbread.GetValue(2).ToString();
                student.Achternaam = dbread.GetValue(3).ToString();
                student.Klascode = dbread.GetValue(4).ToString();
                list.Add(student);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }
        public static void addStudent(string voornaam, string achternaam, int studentnummer, string klas)
        {
            try
            {
                Globaal.Connection.Open();
                //de insert into query die waardes toevoegd aan de database.
                string sql = "INSERT INTO Student (Studentnummer, Voornaam, " +
                  "Achternaam, Klascode) VALUES (@studentnummer, " +
                 "@voornaam, @achternaam, @klas)";
                OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
                //er zijn hier parameters gemaakt voor extra beveiliging
                //door de AddWithValue command geef je de parameters de waarde mee.
                dbcom.Parameters.AddWithValue("@studentnummer", studentnummer);
                dbcom.Parameters.AddWithValue("@voornaam", voornaam);
                dbcom.Parameters.AddWithValue("@achternaam", achternaam);
                dbcom.Parameters.AddWithValue("@klas", klas);

                dbcom.ExecuteNonQuery();
                dbcom.Dispose();
                Globaal.Connection.Close();
                MessageBox.Show("Ingevoerd");

            }
            catch (Exception ex)
            {
                Globaal.Connection.Close();
                return;
            }
        }
    
        }
}
