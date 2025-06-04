using lord_card_shop.Handler;
using lord_card_shop.Model;
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
        public static DataTable FetchAllTransactions()
        {
            return TransactionHeaderRepository.GetAllTransactions();
        }

        public static DataTable FetchHistory(int userId)
        {
            return TransactionHeaderRepository.GetTransactionByUserId(userId);
        }

        public static DataTable FetchDetail(int transactionId)
        {
            return TransactionDetailRepository.GetTransactionDetailsByTransactionId(transactionId);
        }

        public static DataTable GetTransactionInfo(int transactionId)
        {
            return TransactionHeaderRepository.GetTransactionByTrId(transactionId);
        }

        public static DataTable FetchStatus()
        {
            return TransactionHeaderRepository.GetStatus();
        }

        public static void UpdateHandled(int transactionId)
        {
            TransactionHeaderRepository.UpdateTransaction(transactionId, "Handled");
        }

        public static DataTable FetchByStatus(string status)
        {
            return TransactionHeaderRepository.GetByStatus(status);
        }
    }
}