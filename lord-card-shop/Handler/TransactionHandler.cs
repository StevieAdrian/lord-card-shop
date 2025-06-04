using lord_card_shop.Factory;
using lord_card_shop.Model;
using lord_card_shop.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;

namespace lord_card_shop.Handler
{
    public class TransactionHandler
    {
        public static string CheckoutProcess(int userId)
        {
            List<Cart> carts = CartsRepository.GetCartsById(userId);
            if (carts.Count == 0) return "Cart is empty.";

            string status = "Unhandled";

            int id = TransactionHeaderRepository.AddTransactionHeader(DateTime.Now, userId, status);
            System.Diagnostics.Debug.WriteLine("TransactionID: " + id);

            foreach (Cart cart in carts)
            {
                TransactionDetailRepository.AddTransactionDetail(id, cart.CardID, cart.Quantity);
                // System.Diagnostics.Debug.WriteLine($"CardID: {cart.CardID}, Qty: {cart.Quantity}");
            }

            CartsRepository.ClearCart(userId);

            return "success";
        }


        public static DataTable GetStatus(string status)
        {
            return TransactionHeaderRepository.GetByStatus(status);
        }


        public static DataTable GetByUserId(int userId)
        {
            return TransactionHeaderRepository.GetTransactionByUserId(userId);
        }

        public static DataTable GetTransactionDetailsById(int transactionId)
        {
            return TransactionDetailRepository.GetTransactionDetailsByTransactionId(transactionId);
        }

        public static DataTable GetTransactionDetailsByTrId(int transactionId)
        {
            return TransactionHeaderRepository.GetTransactionByTrId(transactionId);
        }

        public static DataTable GetStatus()
        {
            return TransactionHeaderRepository.GetStatus();
        }

        public static void UpdateTransaction(int transactionId, string text)
        {
            TransactionHeaderRepository.UpdateTransaction(transactionId, "Handled");
        }
    }
}