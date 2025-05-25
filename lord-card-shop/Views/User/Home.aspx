<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="lord_card_shop.Views.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="hero w-100 text-center px-3" style="min-height: 85vh;">
        <asp:Image class="img-fluid" ImageUrl="~/Attributes/images/collection_2.jpg" runat="server" style="width: 80vw;"/>
        <h1 class="py-2">Hello User, Welcome to Lord Card Shop!</h1>
        <h3 class="py-2">Lord Card Shop is the best place to collect your favorite cards. </h3>
        <p class="lead py-2">Find your legendary cards here. Discover rare and powerful cards to complete your ultimate collection. Unleash your deck with style, power, passion and grab the rarest, strongest, and coolest cards only for you!</p>
    </section>
</asp:Content>
