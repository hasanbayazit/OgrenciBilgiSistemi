using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS
{
    internal class SQLConnect
    {
        public SqlConnection connect()
        {
            SqlConnection conn = new SqlConnection("server=localhost; Initial Catalog=OBS;Integrated Security=SSPI");
            conn.Open();
            return conn;
        }
    }
}
