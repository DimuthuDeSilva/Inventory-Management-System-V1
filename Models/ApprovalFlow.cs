using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class ApprovalFlow
    {
        public int ApprovalFlowID { get; set; }
        public string FlowName { get; set; }
        public int FirstApproverID { get; set; }
        public int? SecondApproverID { get; set; }
        public decimal AmountThreshold { get; set; }
    }
}
