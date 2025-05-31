using lord_card_shop.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lord_card_shop.Views.Admin
{
    public partial class ManageCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCards();
            }
        }

        private void LoadCards()
        {
            gvCards.DataSource = CardController.GetAllCards();
            gvCards.DataBind();
        }

        protected void gvCards_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int cardId = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "EditCard")
            {
                Response.Redirect($"~/Views/Admin/EditCard.aspx?id={cardId}");
            }
            else if (e.CommandName == "DeleteCard")
            {
                CardController.DeleteCard(cardId);
                LoadCards();
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/AddCard.aspx");
        }
    }
}