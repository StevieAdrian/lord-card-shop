<%@ Page Title="Checkout" Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="lord_card_shop.Views.Customer.Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" />
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container py-4">
        <h2 class="mb-4 text-center">Checkout</h2>

        <asp:GridView ID="CheckoutGridView" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered">
            <Columns>
                <asp:BoundField DataField="CardName" HeaderText="Card Name" />
                <asp:BoundField DataField="CardDesc" HeaderText="Description" />
                <asp:BoundField DataField="CardPrice" HeaderText="Price" DataFormatString="{0:N0}" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="TotalPrice" HeaderText="Total" DataFormatString="{0:N0}" />
            </Columns>
        </asp:GridView>

        <div class="mt-3 text-end">
            <asp:Button ID="ConfirmCheckoutBtn" runat="server" Text="Confirm Checkout" CssClass="btn btn-primary" OnClick="ConfirmCheckoutBtn_Click" />
        </div>
    </div>
</asp:Content>
