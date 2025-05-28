using lord_card_shop.Handler;
using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lord_card_shop.Views.Guest
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["Username"] != null)
            //{
            //    // Kalau sudah login, redirect ke halaman lain misalnya homepage
            //    Response.Redirect("Default.aspx");
            //}

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            string errorMessage;
            bool success = RegisterHandler.RegisterUser(
               txtUsername.Text.Trim(),
               txtEmail.Text.Trim(),
               txtPassword.Text,
               txtConfirmPassword.Text,
               rbMale.Checked,
               rbFemale.Checked,
               out errorMessage
           );

            if (!success)
            {
                ErrorLbl.Text = errorMessage;
            }
            else
            {
                Response.Redirect("~/Views/Guest/Login.aspx");
            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}