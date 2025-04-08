using lord_card_shop.Factory;
using lord_card_shop.Model;
using System;
using System.Collections.Generic;
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
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static List<Cart> GetAllCarts()
        {
            return db.Carts.ToList();
        }
    }
}