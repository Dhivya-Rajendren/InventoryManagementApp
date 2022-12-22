using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InventoryManagementApp.Models;


namespace InventoryManagementApp
{
    public partial class ProductList : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            InventoryRepository inventoryRepository = new InventoryRepository();
            List<Product> products = inventoryRepository.GetProducts();
            gvProducts.DataSource = products;
            gvProducts.DataBind();

           

        }

        protected void btnNewProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewProduct.aspx");
        }
    }
}