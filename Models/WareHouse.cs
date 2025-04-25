using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class WareHouse
    {
        public int WarehouseID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public int ManagerID { get; set; }
        public string ContactPhone { get; set; }
        public bool IsActive { get; set; }
    }
}
