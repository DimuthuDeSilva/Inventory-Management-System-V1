using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_Management_System.Data;
using MySql.Data.MySqlClient;

namespace Inventory_Management_System.Models
{
    public class StockInModel
    {
        public int StockInID { get; set; }
        public int MRRID { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int ReceivedQuantity { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string ReceivedBy { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public string Department { get; set; }
        public string RequestedBy { get; set; }
        public int NumberOfUnits { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}

