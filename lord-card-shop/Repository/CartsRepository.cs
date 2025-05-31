using lord_card_shop.Factory;
using lord_card_shop.Helper;
using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace lord_card_shop.Repository
{
    public class CartsRepository
    {
        private static LocalDatabaseEntities db = new LocalDatabaseEntities();

        public static void AddCart(int cardId, int userId, int quantity)
        {
            Cart cart = CartsFactory.CreateNewCarts(cardId, userId, quantity);
            var cardExists = db.Cards.Any(c => c.CardID == cardId);
            var userExists = db.Users.Any(u => u.UserID == userId);

            if (!cardExists || !userExists)
            {
                throw new Exception("Invalid CardID or UserID.");
            }
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static List<Cart> GetAllCarts()
        {
            return db.Carts.ToList();
        }

        public static List<Cart> GetCartsById(int id)
        {
            return db.Carts.Where(c => c.UserID == id).ToList();
        }

        public static bool UpdateCart(Cart newCart)
        {
            var cart = db.Carts.Find(newCart.CartID);
            if (cart != null)
            {
                cart.Quantity = newCart.Quantity;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static DataTable GetCartDataByUserId(int userId)
        {
            var query = from cart in db.Carts
                        join card in db.Cards on cart.CardID equals card.CardID
                        where cart.UserID == userId
                        select new
                        {
                            card.CardID,
                            card.CardName,
                            card.CardDesc,
                            card.CardPrice,
                            cart.Quantity,
                            TotalPrice = card.CardPrice * cart.Quantity
                        };

            var list = query.ToList();
            return DataTableHelper.ToDataTable(list);
        }

        public static void ClearCart(int userId)
        {
            var carts = db.Carts.Where(c => c.UserID == userId).ToList();
            db.Carts.RemoveRange(carts);
            db.SaveChanges();
        }
    }
}