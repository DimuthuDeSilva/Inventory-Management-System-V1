using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class ConfirmMRreturnModel
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
}
