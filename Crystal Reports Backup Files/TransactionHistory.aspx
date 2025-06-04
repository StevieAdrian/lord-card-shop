<%@ Page Title="Transaction History" Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="lord_card_shop.Views.Customer.TransactionHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" />
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container py-4">
        <h2 class="mb-4 text-center">Transaction History</h2>

        <asp:GridView ID="HistoryGridView" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" />
                <asp:BoundField DataField="TransactionDate" HeaderText="Date" DataFormatString="{0:dd MMM yyyy HH:mm}" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
                <asp:BoundField DataField="TotalPrice" HeaderText="Total" DataFormatString="{0:N0}" />

                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:HiddenField ID="TransactionIDHidden" runat="server" Value='<%# Eval("TransactionID") %>' />
                        <asp:LinkButton ID="ViewDetailBtn" runat="server" Text="View Details" CssClass="btn btn-info btn-sm" OnClick="ViewDetailBtn_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
