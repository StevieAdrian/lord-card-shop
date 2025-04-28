using lord_card_shop.Controller;
using lord_card_shop.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lord_card_shop.Views.Admin
{
    public partial class OrderQueue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!MiddlewareHelper.CheckLogin() || !MiddlewareHelper.CheckAdmin())
            {
                return;
            }

            if (!IsPostBack)
            {
                LoadUnhandledOrders();
            }
        }

        private void LoadUnhandledOrders()
        {
            DataTable dt = TransactionController.FetchStatus();
            OrderQueueGrid.DataSource = dt;
            OrderQueueGrid.DataBind();
        }

        protected void OrderQueueGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int transactionId = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "View")
            {
                Response.Redirect($"~/Views/Customer/TransactionDetail.aspx?tid={transactionId}");
            }
            else if (e.CommandName == "Handle")
            {
                TransactionController.UpdateHandled(transactionId);
                LoadUnhandledOrders();
            }
        }

        protected void OrderQueueGrid_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string status = DataBinder.Eval(e.Row.DataItem, "Status")?.ToString();

                Button handleBtn = (Button)e.Row.FindControl("HandleBtn");

                if (handleBtn != null && status == "Handled")
                {
                    handleBtn.Enabled = false;
                    handleBtn.Text = "Handled";
                    handleBtn.CssClass = "btn btn-outline-secondary btn-sm ms-2"; 
                }
            }
        }
    }
}