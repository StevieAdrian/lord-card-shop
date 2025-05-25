<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="lord_card_shop.Views.Guest.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container py-lg-3">
        <div class="card my-5">
            <div class="card-body">
                <h2 class="card-title">Login</h2>
                <hr />
                
                <div class="mb-3">
                    <asp:Label ID="UsernameLbl" runat="server" Text="Username:" />
                    <asp:TextBox CssClass="form-control form-control-md" ID="UsernameInput" placeholder="Enter username" runat="server" />
                </div>

                <div class="mb-3">
                    <asp:Label ID="PasswordLbl" runat="server" Text="Password:" />
                    <asp:TextBox CssClass="form-control form-control-md" ID="PasswordInput" placeholder="Enter password" runat="server" TextMode="Password" />
                </div>

                <div class="mb-3">
                    <asp:CheckBox ID="RememberCheck" runat="server" Text="Remember Me" />
                </div>

                <div class="mb-3">
                    <asp:Label ID="ErrorLbl" runat="server" ForeColor="Red" />
                    <asp:Button class="btn btn-primary" ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" />
                </div>

                <div class="row-end text-end mb-3">
                    <p class="m-0">Don't have an account yet?</p>
                    <asp:Button CssClass="border-0 p-0 bg-white link-primary link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover" ID="RegisterBtn" runat="server" Text="Register here" OnClick="RegisterBtn_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
