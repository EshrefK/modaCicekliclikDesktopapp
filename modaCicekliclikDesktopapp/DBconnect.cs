using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace modaCicekliclikDesktopapp
{
    internal class DBconnect
    {
        private readonly string connectionString;

        public DBconnect()
        {
            connectionString = "server=localhost;user" +
            "id=root;password=password;database=moda_cicekcilik;port=3306";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
