using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail CreateNewTransactionDetail(int transactionId, int cardId, int quantity)
        {
            TransactionDetail transactionDetail = new TransactionDetail();
            transactionDetail.TransactionID = transactionId;
            transactionDetail.CardID = cardId;
            transactionDetail.Quantity = quantity;

            return transactionDetail;
        }
    }
}