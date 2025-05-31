using System.Web.UI.WebControls;
using lord_card_shop.Model;
using System.Text.RegularExpressions;
using lord_card_shop.Helper;
using lord_card_shop.Handler;
using System;

namespace lord_card_shop.Views.User
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var user = SessionHelper.GetCurrentUser();

                if (user != null)
                {
                    // show current user's readonly data
                    UsernameBox.Text = user.UserName;
                    EmailBox.Text = user.UserEmail;
                    DOBBox.Text = user.UserDOB.ToString("yyyy-MM-dd");
                    if (user.UserGender == "Female") rbFemale.Checked = true;
                    else rbMale.Checked = true;
                    OldPassBox.Attributes["value"] = user.UserPassword;
                }
                else
                {
                    // middleware: to be moved
                    Response.Redirect("~/Views/Guest/Login.aspx");
                }
            }
        }
        private void SetProfileFieldsEditable(bool editable)
        {
            UsernameBox.ReadOnly = !editable;
            EmailBox.ReadOnly = !editable;
            DOBBox.ReadOnly = !editable;
            rbMale.Enabled = editable;
            rbFemale.Enabled = editable;
            OldPassBox.ReadOnly = !editable;
            NewPassBox.ReadOnly = !editable;
            ConfirmPassBox.ReadOnly = !editable;
        }

        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            if (ProfileBtn.Text == "Edit")
            {
                SetProfileFieldsEditable(true);
                OldPassBox.Attributes["value"] = "";
                ProfileBtn.Text = "Update";
            }
            else
            {
                string errorMessage;
                bool isValid = ProfileHandler.ValidateUpdateUser(
                    UsernameBox.Text.Trim(),
                    EmailBox.Text.Trim(),
                    DOBBox.Text.Trim(),
                    OldPassBox.Text,
                    NewPassBox.Text,
                    ConfirmPassBox.Text,
                    rbMale.Checked,
                    rbFemale.Checked,
                    out errorMessage
                 );

                if (!isValid)
                {
                    ErrorLbl.Text = errorMessage;
                    ErrorPanel.Visible = !string.IsNullOrEmpty(ErrorLbl.Text);
                }
                else
                {
                    ErrorLbl.Text = "";
                    ProfileHandler.UpdateUser(
                        UsernameBox.Text.Trim(),
                        EmailBox.Text.Trim(),
                        DOBBox.Text.Trim(),
                        OldPassBox.Text,
                        NewPassBox.Text,
                        rbMale.Checked
                    );
                    SetProfileFieldsEditable(false);
                    OldPassBox.Attributes["value"] = SessionHelper.GetCurrentUser().UserPassword;
                    ProfileBtn.Text = "Edit";
                }
            }
        }
    }
}