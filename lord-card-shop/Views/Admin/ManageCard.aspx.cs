using lord_card_shop.Controller;
using lord_card_shop.Helper;
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
            if (!MiddlewareHelper.CheckLogin() || !MiddlewareHelper.CheckAdmin())
            {
                return; 
            }

            if (!IsPostBack)
            {

                string keyword = Request.QueryString["keyword"];

                if (!string.IsNullOrEmpty(keyword))
                {
                    gvCards.DataSource = CardController.SearchCard(keyword);
                }
                else
                {
                    gvCards.DataSource = CardController.GetAllCards();
                }
                gvCards.DataBind();
            }
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
                gvCards.DataSource = CardController.GetAllCards();
                gvCards.DataBind();
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/AddCard.aspx");
        }
    }
}