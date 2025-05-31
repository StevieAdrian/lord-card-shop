using lord_card_shop.Factory;
using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace lord_card_shop.Repository
{
    public class UserRepository
    {
        private static LocalDatabaseEntities db = new LocalDatabaseEntities();
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

        public static User GetUser(int userId, string password)
        {
            var user = db.Users.FirstOrDefault(u => u.UserID == userId && u.UserPassword == password);
            if (user == null)
            {
                Debug.WriteLine(user);
            }

            Debug.WriteLine("tes");
            return user;

        }
        public static User GetUser(string username, string password)
        {
            return db.Users.FirstOrDefault(u => u.UserName == username && u.UserPassword == password);
        }

        public static void UpdateUser(int userId, string userEmail, string userOldPassword, string userNewPassword, string userName, string userGender, DateTime userDOB)
        {
            User user = GetUser(userId, userOldPassword);
            if (user == null)
            {
                throw new Exception("User tidak ditemukan atau password lama salah.");
            }
            user.UserName = userName;
            user.UserEmail = userEmail;
            user.UserDOB = userDOB;
            user.UserGender = userGender;
            user.UserPassword = userNewPassword;
            db.SaveChanges();
        }

        public static User GetUserByUsername(string username)
        {
            return db.Users.FirstOrDefault(u => u.UserName == username);
        }

    }
}