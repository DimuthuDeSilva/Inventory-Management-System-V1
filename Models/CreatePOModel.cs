using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class CreatePOModel
    {
        public int POID { get; set; }
        public string PONumber { get; set; }
        public int SupplierID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount { get; set; }
        public int CreatedBy { get; set; }
        public int? ApprovedBy { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int NumberOfUnits { get; set; }
        //public List<POItem> Items { get; set; } = new List<POItem>();
    }

    //public class POItem
    //{
    //    public int POItemID { get; set; }
    //    public int POID { get; set; }
    //    public int ItemID { get; set; }
    //    public int Quantity { get; set; }
    //    public decimal UnitPrice { get; set; }
    //    public decimal TotalCost { get; set; }
    //    public int WarehouseID { get; set; }
    //    public bool IsActive { get; set; } = true;
    //}
}
