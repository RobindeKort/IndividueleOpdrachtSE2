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
                    <a href="#" class="list-group-item">Categorie 1</a>
                    <a href="#" class="list-group-item">Categorie 2</a>
                    <a href="#" class="list-group-item">Categorie 3</a>
                    <a href="#" class="list-group-item">Categorie 4</a>
                    <a href="#" class="list-group-item">Categorie 5</a>
                    <a href="#" class="list-group-item">Categorie 6</a>
                    <a href="#" class="list-group-item">Categorie 7</a>
                    <a href="#" class="list-group-item">Categorie 8</a>
                    <a href="#" class="list-group-item">Categorie 9</a>
                </div>
            </div><!--/.sidebar-offcanvas-->
            <div class="col-xs-12 col-sm-9">
                <div class="jumbotron">
                    <h1>Titel</h1>
                    <p>Inhoud</p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
