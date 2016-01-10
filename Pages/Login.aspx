<%@ Page Title="Login" Language="C#" MasterPageFile="~/Pages/LeagueOfLegends.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="IndividueleOpdrachtSE2.Pages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="css" runat="server">
    <link rel="stylesheet" href="/css/Login.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="CPHBody" runat="server">
    <form class="form-signin" runat="server">
        <h2 class="form-signin-heading">Log In</h2>
        <label for="inputEmail" class="sr-only">Username</label>
        <asp:TextBox ID="tbxInputUsername" runat="server" CssClass="form-control" placeholder ="Username" required="" autofocus="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbxInputUsername" ErrorMessage="Please Enter Your Username" ForeColor="Red"/>
        <label for="inputPassword" class="sr-only">Password</label>
        <asp:TextBox ID="tbxInputPassword" runat="server" CssClass="form-control" placeholder ="Password" required="" autofocus="" TextMode="password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbxInputPassword" ErrorMessage="Please Enter Your Password" ForeColor="Red"/>
        <asp:Button ID="btnInloggen" runat="server" Text="Log In" CssClass="btn btn-lg btn-primary btn-block" type="submit" OnClick="btnInloggen_Click"/>
        <asp:Label ID="errorLabel" runat="server"></asp:Label>
    </form>
</asp:Content>