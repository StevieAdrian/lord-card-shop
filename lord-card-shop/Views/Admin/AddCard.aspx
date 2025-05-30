<%@ Page Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="AddCard.aspx.cs" Inherits="lord_card_shop.Views.Admin.AddCard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div style="font-family: Arial; max-width: 500px; padding: 20px; border: 1px solid #ccc; border-radius: 5px; margin: 0 auto 40px auto;">
        <h2 style="font-size: 30px; margin-top: 0; margin-bottom: 10px; color: black;">Add Card</h2>

            <div style="margin-bottom: 15px;">
                <label for="txtName">Name:</label><br />
                <asp:TextBox ID="txtName" runat="server" Width="100%" />
            </div>

            <div style="margin-bottom: 15px;">
                <label for="txtPrice">Price:</label><br />
                <asp:TextBox ID="txtPrice" runat="server" Width="100%" />
            </div>

            <div style="margin-bottom: 15px;">
                <label for="txtDescription">Description:</label><br />
                <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Rows="4" Width="100%" />
            </div>

            <div style="margin-bottom: 15px;">
                <label for="ddlType">Type:</label><br />
                <asp:DropDownList ID="ddlType" runat="server" Width="100%">
                    <asp:ListItem Text="-- Select Type --" Value="" />
                    <asp:ListItem Text="Spell" Value="Spell" />
                    <asp:ListItem Text="Monster" Value="Monster" />
                </asp:DropDownList>
            </div>

            <div style="margin-bottom: 20px;">
                <label for="ddlFoil">Foil:</label><br />
                <asp:DropDownList ID="ddlFoil" runat="server" Width="100%">
                    <asp:ListItem Text="-- Select --" Value="" />
                    <asp:ListItem Text="yes" Value="yes" />
                    <asp:ListItem Text="no" Value="no" />
                </asp:DropDownList>
            </div>

            <div style="margin-bottom: 20px;">
                <asp:Button ID="btnInsert" runat="server" Text="Insert" 
                    style="padding: 8px 16px; background-color: #007bff; color: white; border: none; cursor: pointer;" />
            </div>

            <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="false"></asp:Label>
            </div>
    </div>
</asp:Content>
