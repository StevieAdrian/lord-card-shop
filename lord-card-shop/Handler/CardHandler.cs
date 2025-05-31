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

        public static List<Card> GetAllCards()
        {
            return CardRepository.GetAllCards();
        }

        public static void DeleteCard(int id)
        {
            CardRepository.DeleteCard(id);
        }

        public static void UpdateCard(int id, string name, decimal price, string desc, string type, byte[] foil)
        {
            CardRepository.UpdateCard(id, name, price, desc, type, foil);
        }
    }
}