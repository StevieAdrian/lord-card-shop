using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Factory
{
    public class CartsFactory
    {
        public static Cart CreateNewCarts(int cardId, int userId, int quantity)
        {
            Cart cart = new Cart();
            cart.CartID = cardId;
            cart.UserID = userId;
            cart.Quantity = quantity;

            return cart;
        }
    }
}