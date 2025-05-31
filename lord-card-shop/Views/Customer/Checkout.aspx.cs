using lord_card_shop.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lord_card_shop.Views.Customer
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCheckoutCart();
            }
        }

        private void LoadCheckoutCart()
        {
            int id = Convert.ToInt32(HttpContext.Current.Session["userid"]);
            DataTable cartData = CartsController.FetchCart(id);

            CheckoutGridView.DataSource = cartData;
            CheckoutGridView.DataBind();
        }

        protected void ConfirmCheckoutBtn_Click(object sender, EventArgs s)
        {
            int userId = Convert.ToInt32(Session["userid"]);
            string result = TransactionController.Checkout(userId);

            if (result == "success")
            {
                Response.Redirect("TransactionHistory.aspx");
            }
            else
            {
                Response.Write("<script>alert('" + result + "');</script>");
            }
        }
    }
}