using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace lord_card_shop.Helper
{
    public class SessionHelper
    {
        public static void Session(User user)
        {
            if (user == null) return;

            HttpSessionState session = HttpContext.Current.Session;
            session["CurrentUser"] = user;
            session["CurrentUserID"] = user.UserID;
            session["CurrentUsername"] = user.UserName;
            session["CurrentUserRole"] = user.UserRole;
            session.Timeout = 120;
        }

        public static User GetCurrentUser()
        {
            return HttpContext.Current.Session["CurrentUser"] as User;
        }

        public static bool IsUserLoggedIn()
        {
            return HttpContext.Current.Session["CurrentUser"] != null;
        }

        public static void ClearUserSession()
        {
            HttpContext.Current.Session.Clear();
        }
    }
}