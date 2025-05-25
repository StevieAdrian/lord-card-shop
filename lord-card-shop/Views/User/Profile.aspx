<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="lord_card_shop.Views.User.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container py-lg-3">
        <div class="card my-5">
            <div class="card-body">
                <h2 class="card-title text-center">My Profile</span></h2>
                <hr />
            
                <div class="mb-3">
                    <asp:Label Text="Username:" runat="server" />
                    <asp:TextBox CssClass="form-control form-control-md" ID="UsernameBox" placeholder="Enter username" runat="server" ReadOnly="True" />
                    <asp:Label ID="UsernameErrorLbl" runat="server" ForeColor="Red"></asp:Label>
                </div>

                <div class="mb-3">
                    <asp:Label Text="Email:" runat="server" />
                    <asp:TextBox CssClass="form-control form-control-md" ID="EmailBox" placeholder="Enter email" runat="server" ReadOnly="True" />
                    <asp:Label ID="EmailErrorLbl" runat="server" ForeColor="Red"></asp:Label>
                </div>

                <div class="mb-3">
                    <asp:Label Text="Gender:" runat="server" /> <br />
                    <asp:RadioButton CssClass="me-3" ID="rbMale" runat="server" GroupName="Gender" Text="Male" Enabled="False" />
                    <asp:RadioButton ID="rbFemale" runat="server" GroupName="Gender" Text="Female" Enabled="False" />
                    <asp:Label ID="GenderErrorLbl" runat="server" ForeColor="Red"></asp:Label>
                </div>

                <hr />

                <div class="mb-3">
                    <asp:Label Text="Old Password:" runat="server" />
                    <asp:TextBox CssClass="form-control form-control-md" ID="OldPassBox" placeholder="Enter your old password" runat="server" TextMode="Password" ReadOnly="True" />
                </div>

                <div class="mb-3">
                    <asp:Label Text="New Password:" runat="server" />
                    <asp:TextBox CssClass="form-control form-control-md" ID="NewPassBox" placeholder="Enter your new password" runat="server" TextMode="Password" ReadOnly="True" />
                </div>

                <div class="mb-3">
                    <asp:Label Text="Confirm Password:" runat="server" />
                    <asp:TextBox CssClass="form-control form-control-md" ID="ConfirmPassBox" placeholder="Confirm your password" runat="server" TextMode="Password" ReadOnly="True" />
                    <asp:Label ID="PasswordErrorLbl" runat="server" ForeColor="Red"></asp:Label>
                </div>

                <div class="mb-3">
                    <asp:Button class="btn btn-primary" ID="ProfileBtn" runat="server" Text="Edit" OnClick="ProfileBtn_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
