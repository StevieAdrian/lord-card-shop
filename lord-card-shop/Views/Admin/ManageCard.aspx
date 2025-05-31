<%@ Page Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="ManageCard.aspx.cs" Inherits="lord_card_shop.Views.Admin.ManageCard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container py-4">
        <h2>Manage Cards</h2>
        <asp:Button ID="btnAddNew" runat="server" Text="Add New Card" CssClass="btn btn-success mb-3" OnClick="btnAddNew_Click" />

        <asp:GridView ID="gvCards" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered"
                      OnRowCommand="gvCards_RowCommand">
            <Columns>
                <asp:BoundField DataField="CardID" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="CardName" HeaderText="Name" />
                <asp:BoundField DataField="CardPrice" HeaderText="Price" DataFormatString="{0:C}" />
                <asp:BoundField DataField="CardDesc" HeaderText="Description" />
                <asp:BoundField DataField="CardType" HeaderText="Type" />
                <asp:TemplateField HeaderText="Foil">
                    <ItemTemplate>
                        <%# ((byte[])Eval("isFoil"))[0] == 1 ? "Yes" : "No" %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Button runat="server" CommandName="EditCard" CommandArgument='<%# Eval("CardID") %>' Text="Edit" CssClass="btn btn-primary btn-sm" />
                        <asp:Button runat="server" CommandName="DeleteCard" CommandArgument='<%# Eval("CardID") %>' Text="Delete" CssClass="btn btn-danger btn-sm" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
