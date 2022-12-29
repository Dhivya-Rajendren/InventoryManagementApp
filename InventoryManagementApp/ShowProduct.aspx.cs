using InventoryManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementApp
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBHelper db = new DBHelper();

            string id = Request.QueryString["id"];
            int productId = Convert.ToInt32(id);
            /*

            List<Product> products = db.GetAllProducts();
            Product product = null;

            for (int i = 0; i < products.Count; i++)
            {
                if(products[i].ProductId==productId)
                {
                    product = products[i];
                }
            }


       */     
            //Below code can be implemented as above as well. 
            Product product = db.GetAllProducts().Find(t => t.ProductId == productId);

            lblProductName.Text = product.ProductName;
            imgProduct.ImageUrl = product.ProductImageURL;
            lblCategory.Text = product.Category;

        }
    }
}