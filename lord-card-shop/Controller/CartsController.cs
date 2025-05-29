using lord_card_shop.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Controller
{
    public class CartsController
    {
        public static string AddItemToCart(int userId, int cardId, int quantity)
        {
            return CartsHandler.AddToCart(userId, cardId, quantity);
        }

    }
}