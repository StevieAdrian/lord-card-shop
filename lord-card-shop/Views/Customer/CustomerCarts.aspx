<%@ Page Title="Cart" Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="CustomerCarts.aspx.cs" Inherits="lord_card_shop.Views.Customer.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" />
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container py-4">
        <h2 class="mb-4 text-center">Your Cart</h2>

        <asp:Label ID="lblMessage" runat="server" ForeColor="Green" CssClass="mb-3" />


        <asp:GridView ID="CartsGridView" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered">
            <Columns>
                <asp:BoundField DataField="CardName" HeaderText="Card Name" />
                <asp:BoundField DataField="CardDesc" HeaderText="Description" />
                <asp:BoundField DataField="CardPrice" HeaderText="Price" DataFormatString="{0:N0}" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="TotalPrice" HeaderText="Total" DataFormatString="{0:N0}" />
            </Columns>
        </asp:GridView>

        <div class="mt-3 text-end">
            <asp:Button ID="CheckoutBtn" runat="server" Text="Checkout" CssClass="btn btn-success" OnClick="CheckoutBtn_Click" />
            <asp:Button ID="ClearCartBtn" runat="server" Text="Clear Cart" CssClass="btn btn-danger ms-2" OnClick="ClearCartBtn_Click" />
        </div>
    </div>
</asp:Content>
