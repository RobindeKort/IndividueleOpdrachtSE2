<%@ Page Title="Home" Language="C#" MasterPageFile="~/Pages/LeagueOfLegends.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="IndividueleOpdrachtSE2.Pages.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="css" runat="server">
    <link rel="stylesheet" href="/css/Index.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="CPHBody" runat="server">
    <div class="container jumbotron">
        <!--Laat de ingelogde gebruiker zien-->
        <asp:PlaceHolder ID="name" runat="server"/>
    </div>
    <br/>
    <div class="container jumbotron">
        <form runat="server">
            <!--Een ListBox die alle normale gebruikers laat zien-->
            <asp:ListBox id="lbxUsers" Width="33%" Rows="10" runat="server" CssClass="listbox"/>
            <!--Een ListBox die alle Players laat zien-->
            <asp:ListBox id="lbxPlayers" Width="33%" Rows="10" runat="server" CssClass="listbox"/>
            <!--Een ListBox die alle Employees laat zien-->
            <asp:ListBox id="lbxEmployees" Width="33%" Rows="10" runat="server" CssClass="listbox"/>
        </form>
    </div>
</asp:Content>