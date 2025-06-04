<%@ Page Title="Transaction Detail" Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="lord_card_shop.Views.Customer.TransactionDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" />
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container py-4">
        <h2 class="mb-4 text-center">Transaction Detail</h2>

        <div class="card mb-4">
            <div class="card-body">
                <h5 class="card-title">Transaction Information</h5>
                <p><strong>Transaction ID:</strong> <asp:Label ID="TransactionIdLabel" runat="server" /></p>
                <p><strong>Date:</strong> <asp:Label ID="TransactionDateLabel" runat="server" /></p>
                <p><strong>Status:</strong> <asp:Label ID="TransactionStatusLabel" runat="server" CssClass="badge bg-info text-dark" /></p>
                <p><strong>Grand Total:</strong> <asp:Label ID="GrandTotalLabel" runat="server" CssClass="text-success" /></p>
            </div>
        </div>

        <asp:GridView ID="DetailGridView" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered">
            <Columns>
                <asp:BoundField DataField="CardName" HeaderText="Card Name" />
                <asp:BoundField DataField="CardDesc" HeaderText="Description" />
                <asp:BoundField DataField="CardPrice" HeaderText="Price" DataFormatString="{0:N0}" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="Subtotal" HeaderText="Subtotal" DataFormatString="{0:N0}" />
            </Columns>
        </asp:GridView>

        <div class="text-end">
            <asp:Button ID="BackBtn" runat="server" CssClass="btn btn-secondary" Text="Back" OnClick="BackBtn_Click" />
        </div>
    </div>
</asp:Content>
