using lord_card_shop.Handler;
using lord_card_shop.Helper;
using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Controller
{
    public class CardController
    {
        public static string AddCard(string cardName, decimal cardPrice, string cardDesc, string cardType, byte[] isFoil)
        {
            var error = new List<string>
            {
                CardValidateHelper.validateName(cardName),
                CardValidateHelper.validatePrice(cardPrice),
                CardValidateHelper.validateDescription(cardDesc),
                CardValidateHelper.validateType(cardType),
                // CardValidateHelper.validateFoil(isFoil) *tar uncomment tgg udh validasinya, biar gk lupa
            };

            for (int i = 0; i < error.Count; i++)
            {
                if (error[i] != null)
                {
                    return error[i];
                }
            }

            CardHandler.AddCard(cardName, cardPrice, cardDesc, cardType, isFoil);
            return null;
        }
    }
}