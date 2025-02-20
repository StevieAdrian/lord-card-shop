using lord_card_shop.Factory;
using lord_card_shop.Helper;
using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static DataTable GetTransactionDetailsByTransactionId(int transactionId)
        {
            var query = from td in db.TransactionDetails
                        where td.TransactionID == transactionId
                        select new
                        {
                            td.Card.CardName,
                            td.Card.CardDesc,
                            td.Card.CardPrice,
                            td.Quantity,
                            Subtotal = td.Quantity * td.Card.CardPrice
                        };

            return DataTableHelper.ToDataTable(query.ToList());
        }

    }
}