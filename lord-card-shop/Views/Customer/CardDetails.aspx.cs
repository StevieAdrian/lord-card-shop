using lord_card_shop.Controller;
using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lord_card_shop.Views.Customer
{
    public partial class CardDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void LoadCardDetails(int cardId)
        {
            Card card = CardController.GetCardDetailById(cardId);
            if (card == null)
            {
                Response.Redirect("OrderCard.aspx");
                return;
            }

            CardNameLabel.Text = card.CardName;
            CardPriceLabel.Text = "Rp. " + card.CardPrice.ToString("N0");
            CardTypeLabel.Text = card.CardType;
            CardDescriptionLabel.Text = card.CardDesc;
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            
        }

    }
}