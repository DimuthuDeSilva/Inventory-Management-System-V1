using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class CreateGRNmodel
    {
        public int GRNID { get; set; }
        public string PONumber { get; set; }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public decimal UnitPrice { get; set; }
        public int NumberOfUnits { get; set; }
        public decimal TotalCost { get; set; }
        public int CreatedBy { get; set; } // New property
        public DateTime DateOfDelivery { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Pending";
        public int? ConfirmedBy { get; set; }
        public string Notes { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
