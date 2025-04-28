using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lord_card_shop.Helper
{
    public class MiddlewareHelper
    {
        public static bool CheckLogin()
        {
            var currentUser = SessionHelper.GetCurrentUser();

            if (currentUser == null)
            {
                HttpContext.Current.Response.Redirect("~/Views/Guest/Login.aspx");
                return false;
            }

            return true;
        }

        public static bool CheckAdmin()
        {
            var currentUser = SessionHelper.GetCurrentUser();

            if (currentUser == null || currentUser.UserRole != "Admin")
            {
                HttpContext.Current.Response.Write("<script>alert('Kamu bukan admin!');window.location = '/Views/User/Home.aspx';</script>");


                return false;
            }

            return true;
        }

        public static bool CheckCustomer()
        {
            var currentUser = SessionHelper.GetCurrentUser();

            if (currentUser == null || currentUser.UserRole != "Customer")
            {
                HttpContext.Current.Response.Write("<script>alert('Kamu bukan customer!');window.location = '/Views/User/Home.aspx';</script>");

                return false;
            }

            return true;
        }

    }
}