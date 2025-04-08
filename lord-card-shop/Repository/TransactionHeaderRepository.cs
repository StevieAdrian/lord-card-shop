using lord_card_shop.Factory;
using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Repository
{
    public class TransactionHeaderRepository
    {
        private static LocalDatabaseEntities db = new LocalDatabaseEntities();

        public static void AddTransactionHeader(DateTime transactionDate, int customerId, string status)
        {
            TransactionHeader th = TransactionHeaderFactory.CreateNewTransactionHeader(transactionDate, customerId, status);
            db.TransactionHeaders.Add(th);
            db.SaveChanges();
        }

        public static List<TransactionHeader> GetAllTransactionHeaders()
        {
            return db.TransactionHeaders.ToList();
        }
    }
}