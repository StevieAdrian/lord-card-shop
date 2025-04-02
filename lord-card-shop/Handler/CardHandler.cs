using lord_card_shop.Factory;
using lord_card_shop.Model;
using lord_card_shop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Handler
{
    public class CardHandler
    {
        public static void AddCard(string cardName, decimal cardPrice, string cardDesc, string cardType, byte[] isFoil)
        {
            try
            {
                CardRepository.AddCard(cardName, cardPrice, cardDesc, cardType, isFoil);
            }
            catch
            {
                throw;
            }
        }
        public static Card GetCardById(int cardId)
        {
            return CardRepository.GetCardById(cardId);
        }

    }
}