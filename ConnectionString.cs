using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus_management_system
{
    public class ConnectionString
    {
        private static String Constring = "Data Source=DESKTOP-PQ222BO\\SQLEXPRESS;Initial Catalog=BMS;Integrated Security=True";
        public static string getConnectionString { get => Constring; }
    }
}
