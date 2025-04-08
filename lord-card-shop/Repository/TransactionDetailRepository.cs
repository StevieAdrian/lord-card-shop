using lord_card_shop.Factory;
using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Repository
{
    public class TransactionDetailRepository
    {
        private static LocalDatabaseEntities db = new LocalDatabaseEntities();

        public static void AddTransactionDetail(int transactionId, int cardId, int quantity)
        {
            TransactionDetail td = TransactionDetailFactory.CreateNewTransactionDetail(transactionId, cardId, quantity); 
            db.TransactionDetails.Add(td);
            db.SaveChanges();
        }

        public static List<TransactionDetail> GetAllTransactionDetails()
        {
            return db.TransactionDetails.ToList();
        }
    }
}