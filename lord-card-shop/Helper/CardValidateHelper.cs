using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Helper
{
    public class CardValidateHelper
    {
        public static string validateName(string cardName)
        {
            if (string.IsNullOrWhiteSpace(cardName)) return "Card name must be filled";
            if (cardName.Length < 5 || cardName.Length > 50) return "Card name's length must be between 5 and 50.";
            if (!isAlphaWithSpaces(cardName)) return "Card name's length must be alphabet characters and spaces only.";

            return null;
        }

        public static string validatePrice(string cardPrice)
        {
            if (!decimal.TryParse(cardPrice, out decimal price))
            {
                return "Price must be a valid number.";
            }
            if (price < 10000)
            {
                return "Price must be greater or equal than 10000.";
            }

            return null;
        }

        public static string validateDescription(string description) 
        {
            if (string.IsNullOrWhiteSpace(description)) return "Description must be filled.";

            return null;
        }

        public static string validateType(string type)
        {
            if (type.ToLower() != "spell" && type.ToLower() != "monster")
            {
                return "Type must be either spell or monster.";
            }

            return null;
        }

        public static string validateFoil(byte[] foil)
        {
            if (foil == null || foil.Length != 1) return "Foil must be selected.";
            if (foil[0] != 0 && foil[0] != 1) return "Foil must be either Yes/No.";

            return null;
        }

        private static bool isAlphaWithSpaces(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsLetter(c) && c != ' ') return false;
            }
            return true;
        }
    }
}