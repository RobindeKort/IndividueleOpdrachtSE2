<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/LeagueOfLegends.Master" AutoEventWireup="true" CodeBehind="TeamPage.aspx.cs" Inherits="IndividueleOpdrachtSE2.Pages.TeamPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="css" runat="server">
    <link rel="stylesheet" href="/css/Teams.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="CPHBody" runat="server">
    <div class="jumbotron container">
        <h1 id="TeamName" runat="server"/>
        <h3>Members:</h3>
        <asp:PlaceHolder id="players" runat="server"/>
    </div>
    <div class="jumbotron container">
        <asp:PlaceHolder ID="matches" runat="server"/>
    </div>
</asp:Content>
