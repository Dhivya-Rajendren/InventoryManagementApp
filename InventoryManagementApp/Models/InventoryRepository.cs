using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementApp.Models
{
    public class InventoryRepository
    {
     private static   List<Product> products = new List<Product>() {
        new Product(){ProductId=1,ProductName="TV",Category="Electronics",ProductCode="TV001",SellingPrice=25000,ProductImageURL=""},
        new Product(){ProductId=2,ProductName="Soft Toys",Category="Toys",ProductCode="TY001",SellingPrice=500,ProductImageURL=""},
        new Product(){ProductId=3,ProductName="Baby TriCycle",Category="Cycles",ProductCode="CY001",SellingPrice=2000,ProductImageURL=""},
        new Product(){ProductId=4,ProductName="Sony TV",Category="Electronics",ProductCode="TV002",SellingPrice=25000,ProductImageURL=""}
        };

        public List<Product> GetProducts()
        {
            return products;
        }

        public void CreateProduct(Product product)
        {
            // INserting the new data 
            //Add a product object to list of products
            products.Add(product);
        }
    }
}