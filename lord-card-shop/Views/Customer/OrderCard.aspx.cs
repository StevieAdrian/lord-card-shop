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
        OrderCardController Controller = new OrderCardController();
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
            LinkButton btn = (LinkButton)sender;
            ListViewItem item = (ListViewItem)btn.NamingContainer;

            HiddenField id = (HiddenField)item.FindControl("CardID");

            //Response.Redirect("~/Views/Customer/CardDetails.aspx");
            if (id != null && int.TryParse(id.Value, out int cardId))
            {
                Response.Redirect("CardDetails.aspx?id=" + cardId);
            }
        }

        protected void CartBtn_Click(object sender, EventArgs e)
        {
            //alur: passing card id to card details, and then go to card detail page
            LinkButton btn = (LinkButton)sender;
            ListViewItem item = (ListViewItem)btn.NamingContainer;

            HiddenField res = (HiddenField)item.FindControl("CardID");
           /* int tes = Convert.ToInt32(hfCardId.Value);
            System.Diagnostics.Debug.WriteLine("debug 1: " + tes);
            */

            if (res != null)
            {
                int cardId = Convert.ToInt32(res.Value);
                int userId = Convert.ToInt32(Session["userid"]);
                int quantity = 1;

                string result = CartsController.AddItemToCart(cardId, userId, quantity);

                Response.Write("<script>alert('" + result + "');</script>");
            }
            else
            {
                Response.Redirect("~/Views/Login.aspx");
            }
            //Response.Redirect("~/Views/Customer/CardDetails.aspx");
        }

        protected void CardListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //alur: passing card id to card details, and then go to card detail page

            //Response.Redirect("~/Views/Customer/CardDetails.aspx");
        }

        
    }
}