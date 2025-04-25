using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class CreateMRreturnModel
    {
        public int MRRID { get; set; }
        public string Department { get; set; }
        public string RequestedBy { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int NumberOfUnits { get; set; }
        public string Status { get; set; } = "Pending";
        public string ApprovedBy { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
    public class ItemstoCreateMRR
    {
        public int ItemID { get; set; }
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
