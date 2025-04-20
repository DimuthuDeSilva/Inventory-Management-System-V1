using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Data
{
    public class SqlHelper
    {
        static string strConnection;


        public static string connectionstring()
        {
            strConnection = $"server={GetServerDBDetails.ServerName};user=root;database=inventory_management_system;password={GetServerDBDetails.ServerPassword};";
            return strConnection;
        }
    }
}
