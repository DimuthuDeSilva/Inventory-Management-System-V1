using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class CreatePaymentModel
    {
        public int PaymentID { get; set; }
        public string PaymentReference { get; set; }
        public int POID { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Status { get; set; } = "Payment Processed";
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public string ProcessedBy { get; set; }
        public string Notes { get; set; }      
        public int GRNID { get; set; }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string ItemName { get; set; }
        public decimal UnitPrice { get; set; }
        public int NumberOfUnits { get; set; }
        public int ItemID { get; set; }
        public decimal TotalCost { get; set; }
        public int CreatedBy { get; set; } // New property
        public DateTime DateOfDelivery { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int ConfirmedBy { get; set; }
        public DateTime OrderDate { get; set; }
    }
}

