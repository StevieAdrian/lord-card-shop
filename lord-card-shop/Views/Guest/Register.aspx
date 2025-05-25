<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="lord_card_shop.Views.Guest.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container py-lg-3">
        <div class="card my-5">
            <div class="card-body">
                <h2 class="card-title">Register</h2>
                <hr />
                
                <div class="mb-3">
                    <asp:Label Text="Username:" runat="server" />
                    <asp:TextBox CssClass="form-control form-control-md" ID="txtUsername" placeholder="Enter username" runat="server" />
                    <asp:Label ID="UsernameErrorLbl" runat="server" ForeColor="Red"></asp:Label>
                </div>

                <div class="mb-3">
                    <asp:Label Text="Email:" runat="server" />
                    <asp:TextBox CssClass="form-control form-control-md" ID="txtEmail" placeholder="user@example.com" runat="server" />
                    <asp:Label ID="EmailErrorLbl" runat="server" ForeColor="Red"></asp:Label>
                </div>

                <div class="mb-3">
                    <asp:Label Text="Password:" runat="server" />
                    <asp:TextBox CssClass="form-control form-control-md" ID="txtPassword" placeholder="Enter password" runat="server" TextMode="Password" />
                    <asp:Label ID="PasswordErrorLbl" runat="server" ForeColor="Red"></asp:Label>
                </div>

                <div class="mb-3">
                    <asp:Label Text="Confirm Password:" runat="server" />
                    <asp:TextBox CssClass="form-control form-control-md" ID="txtConfirmPassword" placeholder="Enter confirm password" runat="server" TextMode="Password" />
                    <asp:Label ID="ConfirmErrorLbl" runat="server" ForeColor="Red"></asp:Label>
                </div>

                <div class="mb-3">
                    <asp:Label Text="Gender:" runat="server" /> <br />
                    <asp:RadioButton CssClass="me-3" ID="rbMale" runat="server" GroupName="Gender" Text="Male" />
                    <asp:RadioButton ID="rbFemale" runat="server" GroupName="Gender" Text="Female" />
                    <asp:Label ID="GenderErrorLbl" runat="server" ForeColor="Red"></asp:Label>
                </div>
                
                <div class="mb-3">
                    <asp:HiddenField ID="hfRole" runat="server" Value="Customer" />
                </div>

                <div class="mb-3">
                    <asp:Label ID="ErrorLbl" runat="server" ForeColor="Red"></asp:Label>
                    <asp:Button class="btn btn-primary" ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click" />
                </div>

                <div class="row-end text-end mb-3">
                    <p class="m-0">Already have an account?</p>
                    <asp:Button CssClass="align-content-end border-0 p-0 bg-white link-primary link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover" ID="LoginBtn" runat="server" Text="Login here" OnClick="LoginBtn_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>