using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class ApprovePO
    {
        public int POID { get; set; }
        public string PONumber { get; set; }
        public int SupplierID { get; set; }
        public int NumberOfUnits { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public string Status { get; set; }
        public decimal TotalAmount { get; set; }
        public int CreatedBy { get; set; }
        public int? ApprovedBy { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        //public List<POItem> Items { get; set; } = new List<POItem>();
    }
}
