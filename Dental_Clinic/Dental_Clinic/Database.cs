using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Clinic
{
    public class Database
    {
        public static SqlConnection GetConnection()
        {
            string connString =
                ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            return new SqlConnection(connString);
        }
    }
}
