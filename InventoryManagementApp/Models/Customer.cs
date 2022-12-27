using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementApp.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}