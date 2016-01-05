<%@ Page Title="Login" Language="C#" MasterPageFile="~/Pages/LeagueOfLegends.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="IndividueleOpdrachtSE2.Pages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="css" runat="server">
    <link rel="stylesheet" href="/css/Login.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="CPHBody" runat="server">
    <form class="form-signin" runat="server">
        <h2 class="form-signin-heading">Inloggen</h2>
        <label for="inputEmail" class="sr-only">Email address</label>
        <asp:TextBox ID="txtInputUsername" runat="server" CssClass="form-control" placeholder ="Gebruikersnaam" required="" autofocus=""></asp:TextBox>
        <label for="inputPassword" class="sr-only">Password</label>
        <asp:TextBox ID="txtInputPassword" runat="server" CssClass="form-control" placeholder ="Wachtwoord" required="" autofocus=""></asp:TextBox>
        <asp:Button ID="bttnInloggen" runat="server" Text="Inloggen" CssClass="btn btn-lg btn-primary btn-block" type ="submit"/>
    </form>
</asp:Content>