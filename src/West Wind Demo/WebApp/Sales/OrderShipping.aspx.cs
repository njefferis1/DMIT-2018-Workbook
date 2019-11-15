using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.Admin.Security;

namespace WebApp.Sales
{
    public partial class OrderShipping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsAuthenticated || !User.IsInRole(Settings.SupplierRole))
                Response.Redirect("~", true);
            if (!IsPostBack)
            {
                // load up the info on the supplier
                // TODO: Replace hard-coded supplier ID wth the users supplier ID
                SupplierInfo.Text = "Temp Supplier: ID 2";

            }
        }
    }
}