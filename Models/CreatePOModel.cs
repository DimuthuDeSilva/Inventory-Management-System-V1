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
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
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
       
    }
}
