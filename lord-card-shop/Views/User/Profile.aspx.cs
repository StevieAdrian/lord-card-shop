using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using lord_card_shop.Model;
using System.Text.RegularExpressions;

namespace lord_card_shop.Views.User
{
    public partial class Profile : System.Web.UI.Page
    {
        LocalDatabaseEntities db = new LocalDatabaseEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            // show user's current profile data
            //if (!IsPostBack)
            //{
            //    // get username by user cookie/session
            //    HttpCookie userCookie = Request.Cookies["UserInfo"];

            //    if (userCookie != null && userCookie["Username"] != null)
            //    {
            //        string username = userCookie["Username"];
            //        var user = db.Users.FirstOrDefault(u => u.UserName == username);
            //        if (user != null)
            //        {
            //            // get data from db, then show data readonly to viewpage
            //            UsernameBox.Text = user.UserName;
            //            EmailBox.Text = user.UserEmail;
            //            if (user.UserGender == "Female")
            //            {
            //                rbFemale.Checked = true;
            //            }
            //            else
            //            {
            //                rbMale.Checked = true;
            //            }
            //            OldPassBox.Attributes["value"] = user.UserPassword; // retain password on load
            //        }
            //    }
            //    else
            //    {
            //        // redirect to login if cookie missing
            //        Response.Redirect("~/Views/Guest/Login.aspx");
            //    }
            //}
        }

        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            //if(ProfileBtn.Text == "Edit")
            //{
            //    // enable editing fields
            //    UsernameBox.ReadOnly = false;
            //    EmailBox.ReadOnly = false;
            //    rbMale.Enabled = true;
            //    rbFemale.Enabled = true;
            //    OldPassBox.ReadOnly = false;
            //    NewPassBox.ReadOnly = false;
            //    ConfirmPassBox.ReadOnly = false;

            //    // reset old password text box
            //    OldPassBox.Text = "";
            //    NewPassBox.Text = "";
            //    ConfirmPassBox.Text = "";

            //    // change button text
            //    ProfileBtn.Text = "Update";
            //}
            //else
            //{
            //    // Clear error labels
            //    UsernameErrorLbl.Text = "";
            //    EmailErrorLbl.Text = "";
            //    PasswordErrorLbl.Text = "";
            //    GenderErrorLbl.Text = "";

            //    HttpCookie userCookie = Request.Cookies["UserInfo"];
            //    string currentUsername = userCookie?["Username"];
            //    var currentUser = db.Users.FirstOrDefault(u => u.UserName == currentUsername);
            //    if (currentUser == null)
            //    {
            //        Response.Redirect("~/Views/Guest/Login.aspx");
            //        return;
            //    }

            //    // validasi: Username
            //    var usernameTaken = db.Users.FirstOrDefault(u => u.UserName == UsernameBox.Text);
            //    if (usernameTaken != null)
            //    {
            //        UsernameErrorLbl.Text = "Username is taken.";
            //        return;
            //    }
            //    if (UsernameBox.Text.Length < 5 || UsernameBox.Text.Length > 30 || !Regex.IsMatch(UsernameBox.Text.Trim(), @"^[A-Za-z ]+$"))
            //    {
            //        UsernameErrorLbl.Text = "Username must be 5–30 characters long and contain only letters and spaces.";
            //        return;
            //    }

            //    // validasi: Email
            //    if (!EmailBox.Text.Contains("@"))
            //    {
            //        EmailErrorLbl.Text = "Please enter a valid email address.";
            //        return;
            //    }

            //    // validasi: Gender
            //    if (!rbMale.Checked && !rbFemale.Checked)
            //    {
            //        GenderErrorLbl.Text = "Gender must be chosen.";
            //        return;
            //    }

            //    // validasi: Password
            //    if (!string.IsNullOrWhiteSpace(NewPassBox.Text))
            //    {
            //        if (!Regex.IsMatch(NewPassBox.Text.Trim(), @"^[a-zA-Z0-9]{8,}$"))
            //        {
            //            PasswordErrorLbl.Text = "Password must be at least 8 characters and alphanumeric only.";
            //            return;
            //        }

            //        if (NewPassBox.Text != ConfirmPassBox.Text)
            //        {
            //            PasswordErrorLbl.Text = "Passwords do not match.";
            //            return;
            //        }

            //        currentUser.UserPassword = NewPassBox.Text.Trim();
            //    }

            //    // update ke database

            //    UsernameErrorLbl.Text = "";
            //    EmailErrorLbl.Text = "";

            //    // Disable editing
            //    UsernameBox.ReadOnly = true;
            //    EmailBox.ReadOnly = true;
            //    rbMale.Enabled = false;
            //    rbFemale.Enabled = false;
            //    OldPassBox.ReadOnly = true;
            //    NewPassBox.ReadOnly = true;
            //    ConfirmPassBox.ReadOnly = true;
            //    OldPassBox.Attributes["value"] = currentUser.UserPassword;
            //    ProfileBtn.Text = "Edit";
            //}

        }
    }
}