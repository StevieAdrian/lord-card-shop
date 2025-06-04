using lord_card_shop.Handler;
using lord_card_shop.Helper;
using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Controller
{
    public class AuthController
    {
        public static string AuthenticateUser(string username, string password, bool rememberMe)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return "Username and password must be filled!";
            }

            User user = LoginHandler.GetUser(username, password);

            if (user == null)
            {
                return "Invalid username or password!";
            }

            SessionHelper.Session(user);

            if (rememberMe)
            {
                CookieHelper.SetCookie(user.UserID);
            }

            return "";
        }

        public static bool TryUpdateUserProfile(
             string username,
             string email,
             string dob,
             string oldPassword,
             string newPassword,
             string confirmPassword,
             bool isMale,
             bool isFemale,
             out string errorMessage
         )
        {
            bool isValid = ProfileHandler.ValidateUpdateUser(
                username,
                email,
                dob,
                oldPassword,
                newPassword,
                confirmPassword,
                isMale,
                isFemale,
                out errorMessage
            );

            if (!isValid) return false;

            ProfileHandler.UpdateUser(
                username,
                email,
                dob,
                oldPassword,
                newPassword,
                isMale
            );

            return true;
        }
    }
}