using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Scelta
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["ASPNET_COOKIE"] !=null) {


            }
            else
            {
                Response.Redirect("Default");

            }


        }



        protected void Button1_(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("ASPNET_COOKIE");
            cookie.Values["username"] = UserName.Text;
            cookie.Values["Password"] = Password.Text;
            cookie.Expires = DateTime.Now.AddDays(5);
            Response.Cookies.Add(cookie);
            Response.Redirect("About");
        }
    }
}