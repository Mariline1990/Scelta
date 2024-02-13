using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Scelta
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["ASPNET_COOKIE"] != null)
            {

               

            }
            else
            {
                Response.Redirect("Default");

            }
        }
    }
}