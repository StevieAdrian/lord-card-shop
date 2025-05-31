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
            session["user"] = user;
            session["userid"] = user.UserID;
            session["username"] = user.UserName;
            session["role"] = user.UserRole;
            session.Timeout = 120;
        }

        public static User GetCurrentUser()
        {
            return HttpContext.Current.Session["user"] as User;
        }

        public static bool IsUserLoggedIn()
        {
            return HttpContext.Current.Session["user"] != null;
        }

        public static void ClearUserSession()
        {
            HttpContext.Current.Session.Clear();
        }
    }
}