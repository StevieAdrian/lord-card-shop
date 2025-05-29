using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using lord_card_shop.Controller;

namespace lord_card_shop.Views.Customer
{
    public partial class OrderCard : System.Web.UI.Page
    {
        // OrderCardController Controller = new OrderCardController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CardListView.DataSource = Controller.ViewCardList();
                CardListView.DataBind();
            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            //alur: passing card id buat masukin card ke user cart

            // Tampilkan notifikasi
            NotifPanel.Visible = true;
            NotifLabel.Text = "Card has been added to your cart!";
        }

        protected void DetailBtn_Click(object sender, EventArgs e)
        {
            //alur: passing card id to card details, and then go to card detail page

            //Response.Redirect("~/Views/Customer/CardDetails.aspx");
        }
    }
}