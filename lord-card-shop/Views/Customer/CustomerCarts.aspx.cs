using lord_card_shop.Controller;
using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lord_card_shop.Views.Customer
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCart();
            }
        }

        protected void LoadCart()
        {
            int id = Convert.ToInt32(HttpContext.Current.Session["userid"]);
            DataTable cartData = CartsController.FetchCart(id);

            CartsGridView.DataSource = cartData;
            CartsGridView.DataBind();
        }

        protected void CheckoutBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Checkout.aspx");
        }
    }
}