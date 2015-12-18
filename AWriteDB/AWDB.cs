using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class AWDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Server=tcp:ykpfrfv5g2.database.windows.net,1433;Database=awrite;User ID=paz@ykpfrfv5g2;Password=7S6%5ch1;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
