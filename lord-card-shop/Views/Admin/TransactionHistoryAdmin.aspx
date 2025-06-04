<%@ Page Title="Admin Transaction History" Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryAdmin.aspx.cs" Inherits="lord_card_shop.Views.Admin.TransactionHistoryAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" />
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container py-4">
        <h2 class="mb-4 text-center">All Transactions</h2>

        <div class="d-flex justify-content-end mb-3">
            <asp:DropDownList ID="statusFilterDropdown" runat="server" AutoPostBack="true"
                OnSelectedIndexChanged="filterDropdown"
                CssClass="form-select w-auto">
                <asp:ListItem Text="All" Value="All" />
                <asp:ListItem Text="Unhandled" Value="Unhandled" />
                <asp:ListItem Text="Handled" Value="Handled" />
            </asp:DropDownList>
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
