using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InventoryManagementApp.Models
{
    //ADO .Net 
    public class DBHelper
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;
        string conString;

        public DBHelper()
        {
            conString = "Server=Dhivya-pc\\Sqlexpress;Database=InventoryMgmtDB;integrated security=true";
            con = new SqlConnection(conString);
            con.Open();
        }

        public List<Product> GetAllProducts()
        {
            if(con.State==System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            com = new SqlCommand("Select * from tbl_products", con);
            //We are reading the data only 
            reader = com.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = reader.GetInt32(0);
                product.ProductName = reader.GetString(1);
                product.ProductCode = reader.GetString(2);
                product.Category = reader.GetString(3);
                product.ProductImageURL = reader.GetString(4);
                product.SellingPrice = reader.GetInt32(5);
                products.Add(product);
            }
            reader.Close();
            con.Close();
            return products;

        }

        public int AddNewProduct(Product product)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            string cmdText = "insert into tbl_Products values('" + product.ProductName + "','" + product.ProductCode + "','" + product.Category + "','"+product.ProductImageURL+"'," + product.SellingPrice + ")";
            com = new SqlCommand(cmdText, con);
            int rowsAffected = com.ExecuteNonQuery();
            con.Close();
            return rowsAffected;

        }

        public int DeleteProduct(int productId)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            com = new SqlCommand("Delete from tbl_products where productId=" + productId, con);
            int rowsDeleted = com.ExecuteNonQuery();
            con.Close();
            return rowsDeleted;

        }
   
    
    
    }
}




