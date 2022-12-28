using InventoryManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementApp
{
    public partial class ConfirmDelete : System.Web.UI.Page
    {
        int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            //      InventoryRepository repo = new InventoryRepository();
            DBHelper dbHelper = new DBHelper();
            string productId = Request.QueryString["productId"];
             id = int.Parse(productId);

            Product p = dbHelper.GetAllProducts().Find(t => t.ProductId == id);
            lblProductName.Text = p.ProductName;
            lblPrice.Text = p.SellingPrice.ToString();


        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductList.aspx");
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            DBHelper dBHelper = new DBHelper();
            dBHelper.DeleteProduct(id);
            Response.Redirect("ProductList.aspx");
        }
    }
}