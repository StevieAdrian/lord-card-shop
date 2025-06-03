using lord_card_shop.Controller;
using lord_card_shop.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lord_card_shop.Views
{
    public partial class Website : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Cek dan ganti username label sesuai situasi user
            if (Session["username"] != null)
            {
                navUsernameLbl.Text = "Hello, " + Session["username"].ToString() + "!";
            }
            else
            {
                navUsernameLbl.Text = "Hello, Guest!";
            }

            HideNavbar();

            // Cek dan aktifkan link sesuai halaman
            string role = Session["role"] as string;
            ShowNavbar(role);
            
            string currentPage = System.IO.Path.GetFileName(Request.Url.AbsolutePath).ToLower();

            if (currentPage == "home.aspx")
                navHomeBtn.CssClass += " active";
            else if (currentPage == "ordercard.aspx") 
                navOrderBtn.CssClass += " active";
            else if (currentPage == "cart.aspx") 
                navCartBtn.CssClass += " active";
            else if (currentPage == "history.aspx")
                navHistoryBtn.CssClass += " active";
            else if (currentPage == "managecard.aspx")
                navManageBtn.CssClass += " active";
            else if (currentPage == "viewtransaction.aspx")
                navViewBtn.CssClass += " active";
            else if (currentPage == "transactionreport.aspx")
                navReportBtn.CssClass += " active";
            else if (currentPage == "orderqueue.aspx")
                navQueueBtn.CssClass += " active";
             else if (currentPage == "profile.aspx")
                navProfileBtn.CssClass = "p-2 active";
        }

        private void HideNavbar()
        {
            var allNavbars = new List<WebControl>
            {
                navHomeBtn, navLogoutBtn, navProfileBtn, navSearchBar, navSearchBtn,
                navOrderBtn, navCartBtn, navHistoryBtn, navManageBtn, navViewBtn,
                navReportBtn, navQueueBtn
            };

            foreach (var nav in allNavbars) nav.Visible = false;
        }

        private void ShowNavbar(string role)
        {
            var showAll = new List<WebControl>
            {
                navHomeBtn, navLogoutBtn, navProfileBtn, navSearchBar, navSearchBtn
            };

            if (!string.IsNullOrEmpty(role))
            {
                foreach (var nav in showAll) nav.Visible = true;

                if (role == "Admin")
                {
                    var adminNav = new List<WebControl>
                    {
                        navManageBtn, navViewBtn, navReportBtn, navQueueBtn
                    };

                    foreach (var nav in adminNav) nav.Visible = true;
                }
                else if (role == "Customer")
                {
                    var customerNav = new List<WebControl>
                    {
                        navOrderBtn, navCartBtn, navHistoryBtn
                    };

                    foreach (var nav in customerNav) nav.Visible = true;
                }
            }
        }

        protected void NavSearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        protected void navProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/User/Profile.aspx");
        }

        protected void navLogoutBtn_Click(object sender, EventArgs e)
        {
            SessionHelper.ClearUserSession();

            Response.Redirect("~/Views/Guest/Login.aspx"); 
        }

        protected void navSearchBar_TextChanged(object sender, EventArgs e)
        {
            string keyword = navSearchBar.Text.Trim();

            Debug.WriteLine("test bos");

            if (string.IsNullOrEmpty(keyword))
            {
                return;
            }

            string role = Session["role"]?.ToString();

            if (role == "Customer") Response.Redirect("~/Views/Customer/OrderCard.aspx?keyword=" + HttpUtility.UrlEncode(keyword));
            else if (role == "Admin") Response.Redirect("~/Views/Admin/ManageCard.aspx?keyword=" + HttpUtility.UrlEncode(keyword));

            return;
        }
    }
}