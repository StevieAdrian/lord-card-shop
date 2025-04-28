using lord_card_shop.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lord_card_shop.Views.User
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!MiddlewareHelper.CheckLogin())
            {
                return;
            }

            if (!IsPostBack)
            {
                username.Text = HttpContext.Current.Session["username"]?.ToString();
            }
        }

    }
}