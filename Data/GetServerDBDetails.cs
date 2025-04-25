using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Data
{
    public class GetServerDBDetails
    {
        private static readonly string _serverName = "127.0.0.1";
        private static readonly string _serverPassword = "Bachelor@2320380";

        public static string ServerName => _serverName;
        public static string ServerPassword => _serverPassword;

    }
}
