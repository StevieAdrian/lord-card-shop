using lord_card_shop.Handler;
using lord_card_shop.Repository;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static DataTable FetchHistory(int userId)
        {
            return TransactionHeaderRepository.GetTransactionById(userId);
        }
    }
}