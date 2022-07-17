using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Table 
{ 
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "timetable";
            string username = "root";
            string password = "1337";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }

    }
}