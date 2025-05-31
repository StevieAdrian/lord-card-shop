using lord_card_shop.Handler;
using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace lord_card_shop.Controller
{
    public class CartsController
    {
        public static string AddItemToCart(int cardId, int userId, int quantity)
        {
            return CartsHandler.AddToCart(cardId, userId, quantity);
        }

        public static DataTable FetchCart(int userId)
        {
            return CartsHandler.GetCartDisplayByUserId(userId);
        }
    }
}