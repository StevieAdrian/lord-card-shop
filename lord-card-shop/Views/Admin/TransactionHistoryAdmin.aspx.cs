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

        protected void AdminTransactionGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ViewDetails")
            {
                int transactionId = Convert.ToInt32(e.CommandArgument);
                Response.Redirect($"~/Views/Customer/TransactionDetail.aspx?tid={transactionId}");
            }
        }

        protected void filterDropdown(object sender, EventArgs e)
        {
            string status = statusFilterDropdown.SelectedValue;
            LoadAllTransactions(status);
        }

        private void LoadAllTransactions(string status = "All")
        {
            DataTable dt;

            if (status == "All") dt = TransactionController.FetchAllTransactions();
            else dt = TransactionController.FetchByStatus(status);

            AdminTransactionGrid.DataSource = dt;
            AdminTransactionGrid.DataBind();
        }
    }
}
