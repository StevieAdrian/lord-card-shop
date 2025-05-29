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
                        <img class="card-img-top" src='<%# Eval("ImageUrl") %>' alt="Card image" />
                        <div class="card-body">
                            <asp:HiddenField ID="CardID" runat="server" Value='<%# Eval("CardID") %>' />
                            <h5 class="card-title"><%# Eval("CardName") %></h5>
                            <p class="card-text text-success"><%# Eval("CardPrice") %></p>
                        </div>
                        <asp:LinkButton CssClass="btn btn-outline-warning" ID="CartBtn"  runat="server" OnClick="CartBtn_Click" >Add Cart</asp:LinkButton>
                        <asp:LinkButton CssClass="btn btn-outline-dark" ID="DetailBtn" runat="server" OnClick="DetailBtn_Click" >View Details</asp:LinkButton>
                    </div>
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
