using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class StockOutModel
    {
        public int StockOutID { get; set; }
        public int MRNID { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int? IssuedQuantity { get; set; }
        public DateTime IssuedDate { get; set; } = DateTime.Now;
        public string IssuedBy { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public string Department { get; set; }
        public string RequestedBy { get; set; }
        public int NumberOfUnits { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
