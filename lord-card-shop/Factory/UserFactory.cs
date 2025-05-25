using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Factory
{
    public class UserFactory
    {
        public static User CreateNewUser(string userName, string userEmail, string userPassword, string userGender, DateTime userDOB, string userRole)
        {
            User user = new User();
            user.UserName = userName;
            user.UserEmail = userEmail;
            user.UserPassword = userPassword;
            user.UserGender = userGender;
            user.UserDOB = userDOB;
            user.UserRole = userRole;

            return user;
        }
    }
}