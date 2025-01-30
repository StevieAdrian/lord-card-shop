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
    public class TransactionHeaderRepository
    {
        private static LocalDatabaseEntities db = new LocalDatabaseEntities();

        public static int AddTransactionHeader(DateTime transactionDate, int customerId, string status)
        {
            TransactionHeader th = TransactionHeaderFactory.CreateNewTransactionHeader(transactionDate, customerId, status);
            db.TransactionHeaders.Add(th);
            db.SaveChanges();
            return th.TransactionID;
        }

        public static int GetTransaction(int userId, DateTime date)
        {
            return db.TransactionHeaders
                     .Where(th => th.CustomerID == userId && th.TransactionDate == date)
                     .OrderByDescending(th => th.TransactionID)
                     .Select(th => th.TransactionID)
                     .FirstOrDefault();
        }

        public static DataTable GetTransactionById(int id)
        {
            var query = from th in db.TransactionHeaders
                        where th.CustomerID == id
                        select new
                        {
                            th.TransactionID,
                            th.TransactionDate,
                            th.Status,
                            TotalPrice = th.TransactionDetails.Sum(td => (decimal?)(td.Quantity * td.Card.CardPrice)) ?? 0
                        };

            return DataTableHelper.ToDataTable(query.ToList());
        }
    }
}