using lord_card_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lord_card_shop.Views.Guest
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["Username"] != null)
            //{
            //    // Kalau sudah login, redirect ke halaman lain misalnya homepage
            //    Response.Redirect("Default.aspx");
            //}

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string gender = rbMale.Checked ? "Male" : rbFemale.Checked ? "Female" : "";
            string role = hfRole.Value; // default "Customer"

            // Validasi Username: 5-30 karakter, alphabet + space saja
            if (!Regex.IsMatch(username, @"^[A-Za-z ]{5,30}$"))
            {
                ErrorLbl.Text = "Username harus 5-30 huruf dan spasi saja.";
                return;
            }

            // Validasi Email harus mengandung '@'
            if (!email.Contains("@"))
            {
                ErrorLbl.Text = "Email harus mengandung '@'.";
                return;
            }

            // Validasi Password minimal 8 karakter, alfanumerik
            if (password.Length < 8 || !Regex.IsMatch(password, @"^[a-zA-Z0-9]+$"))
            {
                ErrorLbl.Text = "Password minimal 8 karakter dan hanya alfanumerik.";
                return;
            }

            // Validasi Konfirmasi Password harus sama
            if (password != confirmPassword)
            {
                ErrorLbl.Text = "Password dan konfirmasi password harus sama.";
                return;
            }

            // Validasi Gender harus dipilih
            if (string.IsNullOrEmpty(gender))
            {
                ErrorLbl.Text = "Gender harus dipilih.";
                return;
            }

            // Jika lolos validasi, simpan user ke database atau session (contoh simpan session)
            Session["Username"] = username;
            Session["Role"] = role;
            Session["Gender"] = gender;
            Session["Email"] = email;

            ErrorLbl.ForeColor = System.Drawing.Color.Green;
            ErrorLbl.Text = "Registrasi berhasil! Silakan login.";

            // Redirect ke halaman login
            Response.Redirect("Login.aspx");
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}