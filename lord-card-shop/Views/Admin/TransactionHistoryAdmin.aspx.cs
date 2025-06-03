using lord_card_shop.Controller;
using lord_card_shop.Helper;
using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lord_card_shop.Views.Admin
{
    public partial class TransactionHistoryAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!MiddlewareHelper.CheckLogin() || !MiddlewareHelper.CheckAdmin())
            {
                return;
            }

            if (!IsPostBack)
            {
                LoadAllTransactions();
            }
        }

        private void LoadAllTransactions()
        {
            DataTable dt = TransactionController.FetchAllTransactions();
            AdminTransactionGrid.DataSource = dt;
            AdminTransactionGrid.DataBind();
        }

        protected void AdminTransactionGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ViewDetails")
            {
                int transactionId = Convert.ToInt32(e.CommandArgument);
                Response.Redirect($"~/Views/Customer/TransactionDetail.aspx?tid={transactionId}");
            }
        }
    }
}