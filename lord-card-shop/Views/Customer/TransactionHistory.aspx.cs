using lord_card_shop.Controller;
using lord_card_shop.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lord_card_shop.Views.Customer
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!MiddlewareHelper.CheckLogin() || !MiddlewareHelper.CheckCustomer())
            {
                return;
            }

            if (!IsPostBack)
            {
                LoadTransaction();
            }
        }

        private void LoadTransaction()
        {
            int userId = Convert.ToInt32(Session["userid"]);
            DataTable dt = TransactionController.FetchHistory(userId);

            HistoryGridView.DataSource = dt;
            HistoryGridView.DataBind();
        }

        protected void ViewDetailBtn_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;

            HiddenField id = (HiddenField)row.FindControl("TransactionIDHidden");

            if (id != null && int.TryParse(id.Value, out int transactionId))
            {
                Response.Redirect($"TransactionDetail.aspx?tid={transactionId}");
            }
        }
    }
}