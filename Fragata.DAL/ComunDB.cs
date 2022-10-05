using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Fragata.DAL
{
    public class ComunDB
    {
        //CONEXION DE ODALIS
        public const string _connectionOdalis = @"Data Source=LAPTOP-GN8FSSCR;Initial Catalog=FragataGiftDatabase;Integrated Security=True";

        //CONEXION JOSSE

        public const string _connectionJosse2 = @"Data Source=LAPTOP-9O9LN3PN;Initial Catalog=FragataGiftDatabase;Integrated Security=True";

        public const string _cA = @"Data Source=DESKTOP-OTBV91F;Initial Catalog=FragataGiftDatabase;Integrated Security=True";
        
        public static IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionOdalis); //ACA SE PONEN LA CONEXION DE SU PC
           
        }
        
    }
}
