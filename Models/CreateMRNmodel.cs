using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class CreateMRNmodel
    {
        public int MRNID { get; set; }
        public string Department { get; set; }
        public string RequestedBy { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int NumberOfUnits { get; set; }
        public string Status { get; set; }
        public string ApprovedBy { get; set; } // Nullable as it can be NULL in DB
        public string Notes { get; set; }      // Nullable as it can be NULL in DB
        public DateTime CreatedDate { get; set; } = DateTime.Now; // Default to current time
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int ReorderLevel { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalCost { get; set; }
        public int SupplierID { get; set; }
        public int WarehouseID { get; set; }
        public bool IsActive { get; set; }
    }
}
