<%@ Page Title="Forum" Language="C#" MasterPageFile="~/Pages/LeagueOfLegends.Master" AutoEventWireup="true" CodeBehind="ForumPage.aspx.cs" Inherits="IndividueleOpdrachtSE2.Pages.ForumPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="css" runat="server">
    <link rel="stylesheet" href="/css/Forum.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="CPHBody" runat="server">
    <div class="container">
        <div class="row row-offcanvas row-offcanvas-right">
            <div class="col-xs-6 col-sm-3 sidebar-offcanvas" id="sidebar">
                <div class="list-group">
                    <!--<a href="#" class="list-group-item active">Link</a>-->
                    <asp:PlaceHolder ID="category" runat="server" />
                </div>
            </div><!--/.sidebar-offcanvas-->
            <div class="col-xs-12 col-sm-9">
                <div class="jumbotron">
                    <h1><%= this.Discussion.Title %></h1>
                    <p><%= this.Discussion.DiscussionBody %></p>
                </div>
                <asp:PlaceHolder ID="comments" runat="server" />
                <form runat="server">
                    <asp:TextBox id="tbxComment" rows="3" TextMode="multiline" runat="server" />
                    <asp:Button OnClick="submit" Text="Submit" runat="server" />
                </form>
            </div>
        </div>
    </div>
</asp:Content>
