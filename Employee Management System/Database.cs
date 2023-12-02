using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Employee_Management_System
{
    public class Database
    {
        public static string? GetConnectionString()
        {
            ConnectionStringSettings? settings = ConfigurationManager.ConnectionStrings["LocalSQLServer"];

            return settings?.ConnectionString;

        }
    }
}
