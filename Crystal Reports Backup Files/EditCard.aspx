<%@ Page Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="EditCard.aspx.cs" Inherits="lord_card_shop.Views.Admin.EditCard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container py-lg-3">
        <div class="card my-5">
            <div class="card-body">
                <h2 class="card-title">Edit Card</h2>
                <hr />

                <asp:Panel ID="ErrorPanel" runat="server" Visible="false">
                    <div class="alert alert-danger">
                        <asp:Label ID="lblError" runat="server" />
                    </div>
                </asp:Panel>

                <asp:HiddenField ID="hfCardID" runat="server" />

                <div class="mb-3">
                    <asp:Label ID="NameLbl" runat="server" Text="Name:" />
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control" />
                </div>

                <div class="mb-3">
                    <asp:Label ID="PriceLbl" runat="server" Text="Price:" />
                    <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" />
                </div>

                <div class="mb-3">
                    <asp:Label ID="DescLbl" runat="server" Text="Description:" />
                    <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="4" />
                </div>

                <div class="mb-3">
                    <asp:Label ID="TypeLbl" runat="server" Text="Type:" />
                    <asp:DropDownList ID="ddlType" runat="server" CssClass="form-select">
                        <asp:ListItem Text="Spell" Value="Spell" />
                        <asp:ListItem Text="Monster" Value="Monster" />
                    </asp:DropDownList>
                </div>

                <div class="mb-3">
                    <asp:Label ID="FoilLbl" runat="server" Text="Foil:" />
                    <asp:DropDownList ID="ddlFoil" runat="server" CssClass="form-select">
                        <asp:ListItem Text="Yes" Value="yes" />
                        <asp:ListItem Text="No" Value="no" />
                    </asp:DropDownList>
                </div>

                <div class="mb-3">
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-primary me-2" OnClick="btnUpdate_Click" />
                    <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="btn btn-secondary" OnClick="btnBack_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
