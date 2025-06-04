<%@ Page Title="Card Details" Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="CardDetails.aspx.cs" Inherits="lord_card_shop.Views.Customer.CardDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container py-4">
        <div class="card mx-auto" style="max-width: 500px;">
            <div class="card-body">
                <h2 class="card-title text-center">Card Details</h2>
                <hr />

                <div class="mb-3">
                    <strong>Name:</strong>
                    <asp:Label ID="CardNameLabel" runat="server" CssClass="form-control-plaintext" />
                </div>

                <div class="mb-3">
                    <strong>Price:</strong>
                    <asp:Label ID="CardPriceLabel" runat="server" CssClass="form-control-plaintext" />
                </div>

                <div class="mb-3">
                    <strong>Type:</strong>
                    <asp:Label ID="CardTypeLabel" runat="server" CssClass="form-control-plaintext" />
                </div>

                <div class="mb-3">
                    <strong>Description:</strong>
                    <asp:Label ID="CardDescriptionLabel" runat="server" CssClass="form-control-plaintext" />
                </div>

                <div class="text-end">
                    <asp:Button ID="BackBtn" runat="server" Text="Back" CssClass="btn btn-secondary" OnClick="BackBtn_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
