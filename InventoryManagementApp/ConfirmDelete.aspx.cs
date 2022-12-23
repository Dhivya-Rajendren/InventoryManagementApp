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
        protected void Page_Load(object sender, EventArgs e)
        {

            InventoryRepository repo = new InventoryRepository();
            string productId = Request.QueryString["productId"];
            int id = int.Parse(productId);
            Product p = repo.GetProducts().Find(t => t.ProductId == id);
            lblProductName.Text = p.ProductName;
            lblPrice.Text = p.SellingPrice.ToString();


        }
    }
}