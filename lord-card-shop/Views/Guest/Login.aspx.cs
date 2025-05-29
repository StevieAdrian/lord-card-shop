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
        private LocalDatabaseEntities db = new LocalDatabaseEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Request.Cookies["LoginCookie"] != null)
                {
                    string username = Request.Cookies["LoginCookie"]["Username"];
                    Session["Username"] = username;
                    Response.Redirect("Home.aspx");
                }
            }

        }
        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameInput.Text.Trim();
            string password = PasswordInput.Text.Trim();

            // Validasi username: Cek ke database Users
            var user = db.Users.FirstOrDefault(u => u.UserName == username);

            // Validasi password
            if (user.UserPassword == password || user != null)
            {
                Session["Username"] = username;

                if (RememberCheck.Checked)
                {
                    HttpCookie cookie = new HttpCookie("LoginCookie");
                    cookie["Username"] = username;
                    cookie.Expires = DateTime.Now.AddDays(3);
                    Response.Cookies.Add(cookie);
                }

                Response.Redirect("Home.aspx");
            }
            else
            {
                ErrorLbl.Text = "Invalid username or password.";
                ErrorPanel.Visible = !string.IsNullOrEmpty(ErrorLbl.Text);
            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}