using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using lord_card_shop.Model;
using lord_card_shop.Handler;
using lord_card_shop.Repository;

namespace lord_card_shop.Controller
{
    internal class OrderCardController
    {
        private CardsHandler Handler = new CardsHandler();
        public List<Card> ViewCardList()
        {
            return Handler.GetCards();
        }

        public List<Card> SearchCard(string keyword)
        {
            return CardRepository.GetCardsByName(keyword);
        }
    }
}