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
        private static LocalDatabaseEntities db = new LocalDatabaseEntities();
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

        public static Card GetCardById(int cardId)
        {
            return db.Cards.FirstOrDefault(c => c.CardID == cardId);
        }

        public static void DeleteCard(int id)
        {
            Card card = db.Cards.FirstOrDefault(c => c.CardID == id);
            if (card != null)
            {
                db.Cards.Remove(card);
                db.SaveChanges();
            }
        }

        public static void UpdateCard(int id, string name, decimal price, string desc, string type, byte[] foil)
        {
            Card card = db.Cards.FirstOrDefault(c => c.CardID == id);
            if (card != null)
            {
                card.CardName = name;
                card.CardPrice = price;
                card.CardDesc = desc;
                card.CardType = type;
                card.isFoil = foil;
                db.SaveChanges();
            }
        }

        public static List<Card> GetCardsByName(string keyword)
        {
            return db.Cards.Where(c => c.CardName.Contains(keyword)).ToList();
        }
    }
}