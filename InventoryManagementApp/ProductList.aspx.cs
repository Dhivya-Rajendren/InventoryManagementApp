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
            if (!IsPostBack)
            {
                //   InventoryRepository inventoryRepository = new InventoryRepository();
                //    List<Product> products = inventoryRepository.GetProducts();

                DBHelper dbHelper = new DBHelper();
                
                gvProducts.DataSource = dbHelper.GetAllProducts();
                gvProducts.DataBind();
            }

           

        }

        protected void btnNewProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewProduct.aspx");
        }

        protected void gvProducts_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)gvProducts.Rows[e.RowIndex];

            Label lblProductId = row.FindControl("lblProductId") as Label;
            int productId = int.Parse(lblProductId.Text);
             Response.Redirect("ConfirmDelete.aspx?productId="+productId);
        }
    }
}