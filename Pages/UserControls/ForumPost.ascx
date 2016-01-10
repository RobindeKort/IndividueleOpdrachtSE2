<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ForumPost.ascx.cs" Inherits="IndividueleOpdrachtSE2.Pages.UserControls.ForumPost" %>
<div class="col-xs-6 col-lg-12 forum-post">
    <h2 ID="titleLink" runat="server"></h2>
    <p><%= this.Discussion.DiscussionBody %></p>
</div>