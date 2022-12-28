using InventoryManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementApp
{
    public partial class NewProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateProduct_Click(object sender, EventArgs e)
        {
            //   InventoryRepository repo = new InventoryRepository();
            DBHelper repo = new DBHelper();
            Product product = new Product();
          
            product.ProductName = txtProductName.Text;
            product.Category = txtCategory.Text;
            product.ProductCode = txtProductCode.Text;
            product.SellingPrice=double.Parse(txtPrice.Text);
            product.ProductImageURL = "images/" + fuProductImage.FileName;
            repo.AddNewProduct(product);
            Response.Redirect("ProductList.aspx");
        }
    }
}