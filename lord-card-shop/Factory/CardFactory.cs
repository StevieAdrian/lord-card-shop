using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Factory
{
    public class CardFactory
    {
        public static Card CreateNewCard(string cardName, decimal cardPrice, string cardDesc, string cardType, byte[] isFoil)
        {
            Card card = new Card();
            card.CardName = cardName;
            card.CardPrice = cardPrice;
            card.CardDesc = cardDesc;
            card.CardType = cardType;
            card.isFoil = isFoil;

            return card;
        }
    }
}