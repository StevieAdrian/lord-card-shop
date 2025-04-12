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

            // Cek ke database Users
            var user = db.Users.FirstOrDefault(u => u.UserName == username);

            if (user == null)
            {
                // Jika user belum terdaftar, redirect ke Register
                Response.Redirect("Register.aspx");
                return;
            }

            // Validasi password
            if (user.UserPassword == password)
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
            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}