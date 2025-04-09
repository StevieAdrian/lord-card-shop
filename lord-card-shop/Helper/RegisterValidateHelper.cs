using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Helper
{
    public class RegisterValidateHelper
    {
        public static string ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) return "Username is required.";
            if (username.Length < 5 || username.Length > 30) return "Username length must be between 5 and 30.";
            if (!isAlphaWithSpaces(username)) return "Username must be alphabet characters and spaces only.";

            return null;
        }
        public static string ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return "Email is required.";
            if (!email.Contains("@")) return "Email must contain '@'.";
            return null;
        }

        public static string ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password)) return "Password is required.";
            if (password.Length < 8) return "Password length must be at least 8 characters.";
            if (!isAlphaNumeric(password)) return "Password must be alphanumeric.";
            return null;
        }

        public static string ValidateConfirmPassword(string password, string confirmPassword)
        {
            if (confirmPassword != password) return "Confirmation password must be the same as password.";
            return null;
        }

        public static string ValidateGender(bool maleChecked, bool femaleChecked)
        {
            if (!maleChecked && !femaleChecked) return "Gender must be chosen.";
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

        private static bool isAlphaNumeric(string s)
        {
            bool isDigit = false;
            bool isAlpha = false;

            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    isDigit = true;
                }
                if (char.IsLetter(c))
                {
                    isAlpha = true;
                }

                if (isAlpha && isDigit)
                {
                    return true;
                }
            }

            return false;
        }
    }
}