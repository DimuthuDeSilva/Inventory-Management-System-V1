using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class ConfirmMRNmodel
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
    }
}
