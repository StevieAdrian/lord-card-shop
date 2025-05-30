using lord_card_shop.Model;
using lord_card_shop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Handler
{
    public class LoginHandler
    {
        public static User GetUser(string username, string password)
        {
            return UserRepository.GetUser(username, password);
        }
    }
}