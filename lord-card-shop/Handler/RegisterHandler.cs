using lord_card_shop.Helper;
using lord_card_shop.Model;
using lord_card_shop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Handler
{
    public class RegisterHandler
    {
        private static LocalDatabaseEntities db = new LocalDatabaseEntities();

        public static bool RegisterUser(string username, string email, string password, string confirmPassword, bool maleChecked, bool femaleChecked, out string errorMessage)
        {
            errorMessage = RegisterValidateHelper.ValidateUsername(username) ?? RegisterValidateHelper.ValidateEmail(email) ?? RegisterValidateHelper.ValidatePassword(password) ?? RegisterValidateHelper.ValidateConfirmPassword(password, confirmPassword) ?? RegisterValidateHelper.ValidateGender(maleChecked, femaleChecked);

            if (errorMessage != null) return false;

            try
            {
                UserRepository.AddUser(username, email, password, maleChecked ? "Male" : "Female", DateTime.MinValue, "Customer");

                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}