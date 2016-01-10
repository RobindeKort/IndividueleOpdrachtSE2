<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TeamMatch.ascx.cs" Inherits="IndividueleOpdrachtSE2.Pages.UserControls.TeamMatch" %>
<!--Laat de twee teams van de meegegeven 'Match' zien-->
<div>
    <h3><asp:Label id="blueTeam" runat="server" CssClass="match"/></h3>
    <h4 class="match">VS</h4>
    <h3><asp:Label id="purpleTeam" runat="server"/></h3>
</div>
<!--Laat de start- en eindtijd van de meegegeven 'Match' zien-->
<h5><b id="duration" runat="server"/></h5>