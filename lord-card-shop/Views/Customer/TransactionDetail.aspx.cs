using System;
using System.Data;
using System.Web;
using System.Web.Util;
using lord_card_shop.Controller;
using lord_card_shop.Helper;
using lord_card_shop.Model;

namespace lord_card_shop.Views.Customer
{
    public partial class TransactionDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!MiddlewareHelper.CheckLogin() || !MiddlewareHelper.CheckCustomer())
            {
                return;
            }

            if (!IsPostBack)
            {
                int transactionId = GetTransactionIdFromQuery();
                if (transactionId > 0)
                {
                    LoadTransactionDetail(transactionId);
                }
                else
                {
                    Response.Redirect("TransactionHistory.aspx");
                }
            }
        }

        private int GetTransactionIdFromQuery()
        {
            string rawId = Request.QueryString["tid"];
            return int.TryParse(rawId, out int id) ? id : 0;
        }

        private void LoadTransactionDetail(int id)
        {
            DataTable dt = TransactionController.FetchDetail(id);

            DetailGridView.DataSource = dt;
            DetailGridView.DataBind();

            DataTable headerDt = TransactionController.GetTransactionInfo(id);
            if (headerDt.Rows.Count > 0)
            {
                DataRow row = headerDt.Rows[0];
                TransactionIdLabel.Text = row["TransactionID"].ToString();
                TransactionDateLabel.Text = Convert.ToDateTime(row["TransactionDate"]).ToString("dd MMM yyyy HH:mm");
                TransactionStatusLabel.Text = row["Status"].ToString();
                GrandTotalLabel.Text = "Rp. " + Convert.ToDecimal(row["TotalPrice"]).ToString("N0");
            }
        }
        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionHistory.aspx");
        }
    }
}
