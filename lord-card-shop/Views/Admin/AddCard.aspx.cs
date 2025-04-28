using lord_card_shop.Controller;
using lord_card_shop.Helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lord_card_shop.Views.Admin
{
    public partial class AddCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!MiddlewareHelper.CheckLogin() || !MiddlewareHelper.CheckAdmin())
            {
                return;
            }

            if (!IsPostBack)
            {
                ErrorPanel.Visible = false;
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string priceText = txtPrice.Text.Trim();
            string desc = txtDescription.Text.Trim();
            string type = ddlType.SelectedValue;
            string foil = ddlFoil.SelectedValue;
            byte[] foilBytes = null;

            Debug.WriteLine("debug 1");

            if (foil.ToLower() == "yes") foilBytes = new byte[] { 1 };
            else if (foil.ToLower() == "no") foilBytes = new byte[] { 0 };
            //else
            //{
            //   Debug.WriteLine("debug 2");
            //}

            string result = CardController.AddCard(name, priceText, desc, type, foilBytes);
            if (result != null)
            {
                lblError.Text = result;
                ErrorPanel.Visible = true;
                return;
            }

            Response.Redirect("~/Views/Admin/ManageCard.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/ManageCard.aspx");
        }

    }
}