<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="OrderCard.aspx.cs" Inherits="lord_card_shop.Views.Customer.OrderCard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="ContentNotif" ContentPlaceHolderID="NotificationPlaceholder" runat="server">
    <asp:Panel ID="NotifPanel" runat="server" CssClass="alert alert-success text-center" Visible="false">
        <asp:Label ID="NotifLabel" runat="server" Text=""></asp:Label>
    </asp:Panel>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="heading_container text-center">
        <h2>Cards</h2>
        <hr />
    </div>

    <div class="container mt-4">
        <asp:ListView ID="CardListView" runat="server" OnSelectedIndexChanged="CardListView_SelectedIndexChanged">
            <ItemTemplate>
                <div class="col-md-4 mb-4">
                    <div class="card h-100" style="width: 18rem;">
                        <div class="card-body">
                            <asp:HiddenField ID="CardID" runat="server" Value='<%# Eval("CardID") %>' />
                            <h5 class="card-title"><%# Eval("CardName") %></h5>
                            <p class="card-text text-success"><%# Eval("CardPrice") %></p>
                        </div>
                        <div id="QuantityDiv" runat="server" visible="true" style="display:inline-block; justify-content: center; align-content: center; text-align: center;">
                            <asp:Label ID="QuantityLbl" runat="server"><small>Quantity</small></asp:Label> <br />
                            <asp:Button ID="DownBtn" runat="server" Text="-" OnClick="DownBtn_Click" />
                            <asp:TextBox CssClass="text-center" ID="QuantityBox" Text="1" runat="server"></asp:TextBox>
                            <asp:Button ID="UpBtn" runat="server" Text="+" OnClick="UpBtn_Click" />
                        </div>

                        <div style="display: flex; margin-top: 1rem; width: 100%; justify-content:space-around; padding: 10px">
                            <asp:LinkButton CssClass="btn btn-dark"  ID="LinkButton1" runat="server" OnClick="DetailBtn_Click" >View Details</asp:LinkButton>
                            <asp:LinkButton CssClass="btn btn-warning" ID="LinkButton2"  runat="server" OnClick="CartBtn_Click" >Add Cart</asp:LinkButton>
                        </div>
                        
                        <br />
                    </div>

                    <br />
                    <br />
                </div>
            </ItemTemplate>

            <LayoutTemplate>
                <div class="row">
                    <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                </div>
            </LayoutTemplate>
        </asp:ListView>
    </div>
</asp:Content>
