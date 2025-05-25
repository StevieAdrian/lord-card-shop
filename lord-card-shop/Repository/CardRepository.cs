using lord_card_shop.Factory;
using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Repository
{
    public class CardRepository
    {
        public static LocalDatabaseEntities db = new LocalDatabaseEntities();
        public static void AddCard(string cardName, decimal cardPrice, string cardDesc, string cardType, byte[] isFoil)
        {
            Card card = CardFactory.CreateNewCard(cardName, cardPrice, cardDesc, cardType, isFoil);
            db.Cards.Add(card);
            db.SaveChanges();
        }

        public static List<Card> GetAllCards()
        {
            return db.Cards.ToList();
        }
    }
}