using lord_card_shop.Controller;
using lord_card_shop.Helper;
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
            if (!MiddlewareHelper.CheckLogin() || !MiddlewareHelper.CheckCustomer())
            {
                return;
            }

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

        protected void ClearCartBtn_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(HttpContext.Current.Session["userid"]);
            string result = CartsController.ClearCarts(userId);

            if (result == "Success!")
            {
                LoadCart();
                lblMessage.Text = "Your cart has been cleared!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "Failed to clear your cart. Please try again.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}