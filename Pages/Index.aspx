<%@ Page Title="Home" Language="C#" MasterPageFile="~/Pages/LeagueOfLegends.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="IndividueleOpdrachtSE2.Pages.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="css" runat="server">
    <link rel="stylesheet" href="/css/Index.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="CPHBody" runat="server">
    <div class="container jumbotron">
        <asp:PlaceHolder ID="name" runat="server"/>
    </div>
</asp:Content>