using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lord_card_shop.Helper;
using lord_card_shop.Model;
using lord_card_shop.Repository;

namespace lord_card_shop.Handler
{
    public class ProfileHandler
    {
        public static string UsernameIsTaken(string username)
        {
            string currentUsername = SessionHelper.GetCurrentUser().UserName;
            var user = UserRepository.GetUserByUsername(username);
            if (user != null && user.UserName != currentUsername) return "Username is taken";
            return null;
        }

        public static string ValidateOldPassword(string oldPassword)
        {
            var currentUser = SessionHelper.GetCurrentUser();
            if (oldPassword != currentUser.UserPassword && UserRepository.GetUser(currentUser.UserID, oldPassword) == null)
                return "The old password you entered does not match your current password.";
            return null;
        }

        public static bool ValidateUpdateUser(string username, string email, string dob, string oldPassword, string newPassword, string confirmPassword, bool maleChecked, bool femaleChecked, out string errorMessage)
        {
            errorMessage = UsernameIsTaken(username) ?? RegisterValidateHelper.ValidateUsername(username) ?? RegisterValidateHelper.ValidateEmail(email) ?? RegisterValidateHelper.ValidateDOB(dob) ?? RegisterValidateHelper.ValidateGender(maleChecked, femaleChecked);

            if (string.IsNullOrEmpty(newPassword))
                errorMessage = ValidateOldPassword(oldPassword) ?? RegisterValidateHelper.ValidatePassword(newPassword) ?? RegisterValidateHelper.ValidateConfirmPassword(newPassword, confirmPassword);

            if (errorMessage != null) return false;

            return true;
        }

        public static bool UpdateUser(string username, string email, string dob, string oldPassword, string newPassword, bool maleChecked)
        {
            DateTime dobParsed = DateTime.Parse(dob);
            var userid = SessionHelper.GetCurrentUser();

            try
            {
                UserRepository.UpdateUser(userid.UserID, email, oldPassword, newPassword, username, maleChecked ? "Male" : "Female", dobParsed);
                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}