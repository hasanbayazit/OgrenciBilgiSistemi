using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace OBS
{
    internal class SQLConnect
    {
        public SqlConnection connect()
        {
            SqlConnection conn = new SqlConnection("Server=servername;Database=db;User Id=user;Password=pwd");
            conn.Open();
            return conn;
        }
    }
}
