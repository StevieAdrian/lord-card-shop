using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            //if (Session["role"] == null || Session["role"].ToString() != "admin")
            //{
            //    Response.Redirect("~/Users/Home.aspx");
            //}
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string priceText = txtPrice.Text.Trim();
            string desc = txtDescription.Text.Trim();
            string type = ddlType.SelectedValue;
            string foil = ddlFoil.SelectedValue;

            // Validasi Name
            if (name.Length < 5 || name.Length > 50 || !Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                lblError.Text = "Name must be 5-50 alphabet characters only.";
                lblError.ForeColor = System.Drawing.Color.Red;
                lblError.Visible = true;
                return;
            }

            // Validasi Price
            if (!decimal.TryParse(priceText, out decimal price) || price < 10000)
            {
                lblError.Text = "Price must be a number >= 10000.";
                lblError.ForeColor = System.Drawing.Color.Red;
                lblError.Visible = true;
                return;
            }

            // Validasi Description
            if (string.IsNullOrWhiteSpace(desc))
            {
                lblError.Text = "Description must not be empty.";
                lblError.ForeColor = System.Drawing.Color.Red;
                lblError.Visible = true;
                return;
            }

            // Validasi Type
            if (type != "Spell" && type != "Monster")
            {
                lblError.Text = "Type must be Spell or Monster.";
                lblError.ForeColor = System.Drawing.Color.Red;
                lblError.Visible = true;
                return;
            }

            // Validasi Foil
            if (foil != "yes" && foil != "no")
            {
                lblError.Text = "Foil must be yes or no.";
                lblError.ForeColor = System.Drawing.Color.Red;
                lblError.Visible = true;
                return;
            }
        }
    }
}