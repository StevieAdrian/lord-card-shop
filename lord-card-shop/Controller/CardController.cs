using lord_card_shop.Handler;
using lord_card_shop.Helper;
using lord_card_shop.Model;
using lord_card_shop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Controller
{
    public class CardController
    {
        public static string AddCard(string cardName, string cardPrice, string cardDesc, string cardType, byte[] isFoil)
        {

            var error = new List<string>
            {
                CardValidateHelper.validateName(cardName),
                CardValidateHelper.validatePrice(cardPrice),
                CardValidateHelper.validateDescription(cardDesc),
                CardValidateHelper.validateType(cardType),
                CardValidateHelper.validateFoil(isFoil)
            };

            for (int i = 0; i < error.Count; i++)
            {
                if (error[i] != null)
                {
                    return error[i];
                }
            }

            CardHandler.AddCard(cardName, decimal.Parse(cardPrice), cardDesc, cardType, isFoil);
            return null;
        }

        public static Card GetCardDetailById(int cardId)
        {
            return CardHandler.GetCardById(cardId);
        }

        public static List<Card> GetAllCards()
        {
            return CardHandler.GetAllCards();
        }

        public static void DeleteCard(int id)
        {
            CardHandler.DeleteCard(id);
        }

        public static string UpdateCard(int cardId, string name, string priceText, string desc, string type, byte[] foilBytes)
        {
            var errors = new List<string>
            {
                CardValidateHelper.validateName(name),
                CardValidateHelper.validatePrice(priceText),
                CardValidateHelper.validateDescription(desc),
                CardValidateHelper.validateType(type),
                CardValidateHelper.validateFoil(foilBytes)
            };

            foreach (var error in errors)
            {
                if (error != null) return error;
            }

            decimal price = decimal.Parse(priceText);
            CardHandler.UpdateCard(cardId, name, price, desc, type, foilBytes);
            return null;
        }

        public static List<Card> SearchCard(string keyword)
        {
            return CardRepository.GetCardsByName(keyword);
        }

    }
}