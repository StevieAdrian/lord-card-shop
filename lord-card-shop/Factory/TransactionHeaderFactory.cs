using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader CreateNewTransactionHeader(DateTime transactionDate, int customerId, string status)
        {
            TransactionHeader transactionHeader = new TransactionHeader();
            transactionHeader.TransactionDate = transactionDate;
            transactionHeader.CustomerID = customerId;
            transactionHeader.Status = status;

            return transactionHeader;
        }
    }
}