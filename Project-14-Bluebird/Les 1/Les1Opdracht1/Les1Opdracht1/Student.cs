using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les1Opdracht1
{
   class Student
    {
        public int Studentid { get; set; }
        public string Studentnummer { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Klascode { get; set; }
        public string volledig { get { return Studentnummer + " " + Voornaam + " " + Achternaam + " " + Klascode; } }

        public static List <Student> getAll()
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
                student.Studentnummer = dbread.GetValue(1).ToString();
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
    }
}
