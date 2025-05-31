using lord_card_shop.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Controller
{
    public class TransactionController
    {
        public static string Checkout(int userId)
        {
            return TransactionHandler.CheckoutProcess(userId);
        }
    }
}