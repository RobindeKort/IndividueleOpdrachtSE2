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
          <div class="col-xs-6 col-lg-12">
              <form runat="server">
                  <asp:TextBox ID="tbxDiscussionTitle" runat="server" placeholder="Title"/>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbxDiscussionTitle" ErrorMessage="Please Enter A Title" ForeColor="Red"/>
                  <br/>
                  <asp:TextBox ID="tbxDiscussionLink" runat="server" placeholder="Link"/>
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbxDiscussionLink" Display="Dynamic"
                                                  ValidationExpression="^\s*((?:https?://)?(?:[\w-]+\.)+[\w-]+)(/[\w ./?%&=-]*)?\s*$" ErrorMessage="Please Enter A Valid URL" ForeColor="Red"/>
                  <br/>
                  <asp:TextBox ID="tbxDiscussion" runat="server" rows="5" TextMode="multiline" placeholder="Body"/>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbxDiscussion" ErrorMessage="Please Enter Some Text" ForeColor="Red"/>
                  <br/>
                  <asp:DropDownList ID="ddlCategory" runat="server"/>
                  <asp:Button ID="btnDiscussion" runat="server" Text="Submit" OnClick="btnDiscussion_Click"/>
              </form>
          </div>
        </div><!--/.col-xs-12.col-sm-9-->

      </div><!--/row-->
    </div>
</asp:Content>