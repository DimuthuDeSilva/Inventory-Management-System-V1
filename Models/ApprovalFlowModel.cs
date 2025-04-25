using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class ApprovalFlowModel
    {
        public int ApprovalFlowID { get; set; }
        public string FunctionName { get; set; }
        public int Level { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
    }
}
