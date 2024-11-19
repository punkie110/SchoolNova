using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Bluebird
{
     class Globaal
    {
        //een nieuwe database connectie.
        public static OleDbConnection Connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
                    data source = ..\\..\\..\\BluebirdAirlines.accdb ; Persist Security Info=False;");
    }
}
