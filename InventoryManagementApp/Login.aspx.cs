using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string userName = "Dhivya-CK";
            string pwd = "pass-1";

            if(Login1.UserName.Equals(userName) && Login1.Password.Equals(pwd))
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnNewReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewUser.aspx");
        }
    }
}