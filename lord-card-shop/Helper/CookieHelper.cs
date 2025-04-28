using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Helper
{
    public class CookieHelper
    {
        private const string CookieName = "LoginCookie";
        private const string UserIdKey = "userid";
        private const int CookieExpirationDays = 7;
        public static void SetCookie(int userId)
        {
            var cookie = new HttpCookie(CookieName)
            {
                [UserIdKey] = userId.ToString(),
                Expires = DateTime.Now.AddDays(CookieExpirationDays)
            };

            HttpContext.Current.Response.Cookies.Add(cookie);
        }
        public static int? GetCookie()
        {
            var cookie = HttpContext.Current.Request.Cookies[CookieName];
            if (cookie == null) return null;

            if (int.TryParse(cookie[UserIdKey], out int userId))
            {
                return userId;
            }

            return null;
        }

        public static void ClearCookie()
        {
            var cookie = new HttpCookie(CookieName)
            {
                Expires = DateTime.Now.AddDays(-1)
            };

            HttpContext.Current.Response.Cookies.Add(cookie);
        }
    }
}