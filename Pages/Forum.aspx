<%@ Page Title="Forum" Language="C#" MasterPageFile="~/Pages/LeagueOfLegends.Master" AutoEventWireup="true" CodeBehind="Forum.aspx.cs" Inherits="IndividueleOpdrachtSE2.Pages.Forum" %>

<%@ Register Src="~/Pages/UserControls/ForumPost.ascx" TagPrefix="uc1" TagName="ForumPost" %>
<%@ Register Src="~/Pages/UserControls/ForumCategory.ascx" TagPrefix="uc2" TagName="ForumCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="css" runat="server">
    <link rel="stylesheet" href="/css/Forum.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="CPHBody" runat="server">
    <div class="container">
      <div class="row row-offcanvas row-offcanvas-right">

        <div class="col-xs-6 col-sm-3 sidebar-offcanvas" id="sidebar">
          <div class="list-group">
            <!--</h1><a href="#" class="list-group-item active">Link</a>-->
              <asp:PlaceHolder ID="category" runat="server" />
          </div>
        </div><!--/.sidebar-offcanvas-->

        <div class="col-xs-12 col-sm-9">
          <div class="jumbotron">
            <h1>Forum</h1>
            <p>Dit is een Forum.</p>
          </div>
          <div class="row">
              <asp:PlaceHolder ID="discussion" runat="server" />
          </div><!--/row-->
        </div><!--/.col-xs-12.col-sm-9-->

      </div><!--/row-->
    </div>
</asp:Content>