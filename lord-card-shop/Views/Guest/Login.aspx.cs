using lord_card_shop.Controller;
using lord_card_shop.Helper;
using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lord_card_shop.Views.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                // tar tambah middleware
            }

        }
        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameInput.Text.Trim();
            string password = PasswordInput.Text.Trim();
            bool remember = RememberCheck.Checked;

            string res = AuthController.AuthenticateUser(username, password, remember);

            if (!string.IsNullOrEmpty(res))
            {
                ShowError(res);
                return;
            }

            RedirectUser();
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        private void RedirectUser()
        {
            string role = SessionHelper.GetCurrentUser()?.UserRole;

            if (role == "Admin")
            {
                Response.Redirect("~/Views/Admin/Home.aspx");
            }
            else if (role == "Customer")
            {
                Response.Redirect("~/Views/User/Home.aspx");
            }
            else
            {
                // bwt fallback manatau ada bug
                Response.Redirect("~/Views/Guest/Login.aspx");
            }
        }

        private void ShowError(string message)
        {
            ErrorPanel.Visible = true;
            ErrorLbl.Text = message;
        }
    }
}