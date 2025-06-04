<%@ Page Title="Order Queue" Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="OrderQueue.aspx.cs" Inherits="lord_card_shop.Views.Admin.OrderQueue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" />
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container py-4">
        <h2 class="mb-4 text-center">Unhandled Orders</h2>

        <asp:GridView ID="OrderQueueGrid" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered" OnRowCommand="OrderQueueGrid_RowCommand" OnRowDataBound="OrderQueueGrid_RowDataBound">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" />
                <asp:BoundField DataField="CustomerID" HeaderText="Customer ID" />
                <asp:BoundField DataField="TransactionDate" HeaderText="Date" DataFormatString="{0:dd MMM yyyy HH:mm}" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
                <asp:BoundField DataField="TotalPrice" HeaderText="Total" DataFormatString="{0:N0}" />

                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Button ID="ViewBtn" runat="server" Text="View" CommandName="View" CommandArgument='<%# Eval("TransactionID") %>' CssClass="btn btn-outline-info btn-sm" />
                        <asp:Button ID="HandleBtn" runat="server" Text="Mark as Handled" CommandName="Handle" CommandArgument='<%# Eval("TransactionID") %>' CssClass="btn btn-outline-success btn-sm ms-2" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
