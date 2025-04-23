using lord_card_shop.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lord_card_shop.Views.Admin
{
    public partial class EditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                var card = CardController.GetCardDetailById(id);

                if (card != null)
                {
                    hfCardID.Value = card.CardID.ToString();
                    txtName.Text = card.CardName;
                    txtPrice.Text = card.CardPrice.ToString();
                    txtDescription.Text = card.CardDesc;
                    ddlType.SelectedValue = card.CardType;
                    ddlFoil.SelectedValue = (card.isFoil[0] == 1) ? "yes" : "no";
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(hfCardID.Value);
            string name = txtName.Text.Trim();
            string priceText = txtPrice.Text.Trim();
            string desc = txtDescription.Text.Trim();
            string type = ddlType.SelectedValue;
            string foil = ddlFoil.SelectedValue;

            byte[] foilBytes = foil == "yes" ? new byte[] { 1 } : new byte[] { 0 };

            string result = CardController.UpdateCard(id, name, priceText, desc, type, foilBytes);
            if (result != null)
            {
                lblError.Text = result;
                ErrorPanel.Visible = true;
                return;
            }

            Response.Redirect("~/Views/Admin/ManageCard.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/ManageCard.aspx");
        }
    }
}