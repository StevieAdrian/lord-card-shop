<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Website.Master" AutoEventWireup="true" CodeBehind="TransactionReport.aspx.cs" Inherits="lord_card_shop.Views.Customer.TransactionReport" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NotificationPlaceholder" runat="server">
    <div>
        <CR:CrystalReportViewer ID="CrystalReportViewer" runat="server" AutoDataBind="true" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
