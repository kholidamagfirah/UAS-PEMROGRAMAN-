using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_OOP_1204003
{
    class db
    {
        private string url = "Server=localhost;Database=UAS;Uid=root;Pwd=;";

        public MySqlConnection GetConn()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(url);
                return conn;
            }
            catch
            {
                throw new Exception("Database Error");
            }
        }





    }
}

