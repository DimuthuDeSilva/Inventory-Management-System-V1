using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Supplier { get; set; }
        public string Category { get; set; }
    }
}
