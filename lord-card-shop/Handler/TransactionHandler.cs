using lord_card_shop.Factory;
using lord_card_shop.Model;
using lord_card_shop.Repository;
using System;
using System.Collections.Generic;
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


    }
}