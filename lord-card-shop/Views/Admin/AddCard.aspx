<%@ Page Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="AddCard.aspx.cs" Inherits="lord_card_shop.Views.Admin.AddCard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container py-lg-3">
        <div class="card my-5">
            <div class="card-body">
                <h2 class="card-title">Add Card</h2>
                <hr />

                <asp:Panel ID="ErrorPanel" runat="server" Visible="false">
                    <div class="alert alert-danger">
                        <asp:Label ID="lblError" runat="server" />
                    </div>
                </asp:Panel>

                <div class="mb-3">
                    <asp:Label ID="NameLbl" runat="server" Text="Name:" />
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control" placeholder="Enter card name" />
                </div>

                <div class="mb-3">
                    <asp:Label ID="PriceLbl" runat="server" Text="Price:" />
                    <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" placeholder="Enter card price" />
                </div>

                <div class="mb-3">
                    <asp:Label ID="DescLbl" runat="server" Text="Description:" />
                    <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="4" placeholder="Enter description" />
                </div>

                <div class="mb-3">
                    <asp:Label ID="TypeLbl" runat="server" Text="Type:" />
                    <asp:DropDownList ID="ddlType" runat="server" CssClass="form-select">
                        <asp:ListItem Text="-- Select Type --" Value="" />
                        <asp:ListItem Text="Spell" Value="Spell" />
                        <asp:ListItem Text="Monster" Value="Monster" />
                    </asp:DropDownList>
                </div>

                <div class="mb-3">
                    <asp:Label ID="FoilLbl" runat="server" Text="Foil:" />
                    <asp:DropDownList ID="ddlFoil" runat="server" CssClass="form-select">
                        <asp:ListItem Text="-- Select --" Value="" />
                        <asp:ListItem Text="Yes" Value="yes" Selected="True"/>
                        <asp:ListItem Text="No" Value="no" />
                    </asp:DropDownList>
                </div>

                <div class="mb-3">
                    <asp:Button ID="btnInsert" runat="server" Text="Insert" CssClass="btn btn-primary" OnClick="btnInsert_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
