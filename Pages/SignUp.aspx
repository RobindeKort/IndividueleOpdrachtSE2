<%@ Page Title="Sign Up" Language="C#" MasterPageFile="~/Pages/LeagueOfLegends.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="IndividueleOpdrachtSE2.Pages.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="css" runat="server">
    <link rel="stylesheet" href="/css/SignUp.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="CPHBody" runat="server">
    <!--Een form om een gebruiker mee aan te maken, waarbij er met
        FieldValidators wordt gecontroleerd of de velden ingevuld zijn-->
    <form class="form-signin" runat="server">
        <!--Titel-->
        <h2 class="form-signin-heading">Log In</h2>
        <!--Username Textbox en RequiredFieldValidator-->
        <label for="inputEmail" class="sr-only">Username</label>
        <asp:TextBox ID="tbxInputUsername" runat="server" CssClass="form-control" placeholder="Username" autofocus="true"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbxInputUsername" ErrorMessage="Please Enter Your Username" ForeColor="Red"/>
        <!--Password Textbox en RequiredFieldValidator-->
        <label for="inputPassword" class="sr-only">Password</label>
        <asp:TextBox ID="tbxInputPassword" runat="server" CssClass="form-control" placeholder="Password" autofocus="" TextMode="password"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbxInputPassword" ErrorMessage="Please Enter Your Password" ForeColor="Red"/>
        <!--Email Textbox, RequiredFieldValidator en RegularExpressionValidator-->
        <asp:TextBox ID="tbxInputEmail" runat="server" CssClass="form-control" placeholder="Email" autofocus=""/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbxInputEmail" ErrorMessage="Please Enter Your Email" ForeColor="Red"/>
        <br/>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbxInputEmail" Display="Dynamic"
                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Please Enter A Valid Email Address" ForeColor="Red"/>
        <!--Region DropDownList-->
        <asp:DropDownList ID="ddlRegion" runat="server" CssClass="form-control" AutoPostBack="false" autofocus=""/>
        <!--Day Textbox-->
        <asp:TextBox ID="tbxDay" runat="server" CssClass="form-control date" placeholder="dd" autofocus=""/>
        <!--Month Textbox-->
        <asp:TextBox ID="tbxMonth" runat="server" CssClass="form-control date" placeholder="mm" autofocus=""/>
        <!--Year Textbox-->
        <asp:TextBox ID="tbxYear" runat="server" CssClass="form-control date" placeholder="yyyy" autofocus=""/>
        <!--Error label om alle errors bij de geboortedatum op een plek te tonen-->
        <asp:Label ID="errorLabel" runat="server" CssClass="errorLabel" ForeColor="Red"/>
        <br/>
        <!--NewsLetter CheckBox-->
        <asp:CheckBox ID="cbxNews" runat="server"/>
        <asp:Label ID="cbxLabel" runat="server" Text="Newsletter"/>
        <!--Submit button-->
        <asp:Button ID="btnSignup" runat="server" Text="Sign Up" CssClass="btn btn-lg btn-primary btn-block" type="submit" OnClick="btnSignup_Click"/>
    </form>
</asp:Content>

