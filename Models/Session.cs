using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    //public static class Session
    //{
    //    public static int UserID { get; set; }
    //    public static string Username { get; set; }
    //    public static string Fullname { get; set; }
    //    public static string Role { get; set; }
    //    public static int Status { get; set; }
    //}

    public static class Session
    {
        public static User CurrentUser { get; set; }

        // You can add more session properties as needed
        public static string Username => CurrentUser?.Username;
        public static string Role => CurrentUser?.Role;
        public static int UserID => CurrentUser?.UserID ?? 0;
        public static string FullName => CurrentUser?.FullName;
    }
}
