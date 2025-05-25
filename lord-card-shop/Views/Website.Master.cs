using System;
using System.Collections.Generic;
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

            // Cek dan aktifkan link sesuai halaman
            string currentPage = System.IO.Path.GetFileName(Request.Url.AbsolutePath).ToLower();

            if (currentPage == "home.aspx")
                navHomeBtn.CssClass += " active";
            //else if (currentPage == "ordercard.aspx")/*/*
            //    navOrderBtn.CssClass += " active";
            //else if (currentPage == "cart.aspx")
            //    navCartBtn.CssClass += " active";
            //else if (currentPage == "history.aspx")
            //    navHistoryBtn.CssClass += " active";
            //else if (currentPage == "managecard.aspx")
            //    navManageBtn.CssClass += " active";
            //else if (currentPage == "viewtransaction.aspx")
            //    navViewBtn.CssClass += " active";
            //else if (currentPage == "transactionreport.aspx")
            //    navReportBtn.CssClass += " active";
            //else if (currentPage == "orderqueue.aspx")
            //    navQueueBtn.CssClass += " active";
            else if (currentPage == "profile.aspx")
                navProfileBtn.CssClass += " active";
        }

        protected void navSearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        protected void navProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/User/Profile.aspx");
        }
    }
}