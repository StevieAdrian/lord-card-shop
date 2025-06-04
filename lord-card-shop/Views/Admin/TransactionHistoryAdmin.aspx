<%@ Page Title="Admin Transaction History" Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryAdmin.aspx.cs" Inherits="lord_card_shop.Views.Admin.TransactionHistoryAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" />
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container py-4">
        <h2 class="mb-4 text-center">All Transactions</h2>

        <div class="dropdown">
            <button class="btn btn-primary dropdown-toggle mb-3" type="button" data-bs-toggle="dropdown" aria-expanded="false">
            Filter
            </button>
            <ul class="dropdown-menu">
                <li><a class="dropdown-item" href="#">All</a></li>
                <li><a class="dropdown-item" href="#">Handled</a></li>
                <li><a class="dropdown-item" href="#">Unhandled</a></li>
            </ul>
        </div>

        <asp:GridView ID="AdminTransactionGrid" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered" OnRowCommand="AdminTransactionGrid_RowCommand">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" />
                <asp:BoundField DataField="CustomerID" HeaderText="Customer ID" />
                <asp:BoundField DataField="TransactionDate" HeaderText="Date" DataFormatString="{0:dd MMM yyyy HH:mm}" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
                <asp:BoundField DataField="TotalPrice" HeaderText="Total" DataFormatString="{0:N0}" />

                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="ViewBtn" runat="server" Text="View Details" CommandName="ViewDetails" CommandArgument='<%# Eval("TransactionID") %>' CssClass="btn btn-info btn-sm" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
