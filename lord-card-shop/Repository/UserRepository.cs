using lord_card_shop.Factory;
using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Repository
{
    public class UserRepository
    {
        public static LocalDatabaseEntities db = new LocalDatabaseEntities();
        public static void AddUser(string userName, string userEmail, string userPassword, string userGender, DateTime userDOB, string userRole)
        {
            User user = UserFactory.CreateNewUser(userName, userEmail, userPassword, userGender, userDOB, userRole);
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static List<User> GetAllUsers()
        {
            return db.Users.ToList();
        }
    }
}