using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string Category { get; set; }

        public string ProductImageURL { get; set; }

        public double SellingPrice { get; set; }

    }
}