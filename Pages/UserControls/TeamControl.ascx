<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TeamControl.ascx.cs" Inherits="IndividueleOpdrachtSE2.Pages.UserControls.TeamControl" %>
<!--Laat de teamnaam, de teamcaptain en een bijbehorende link zien-->
<div class="col-xs-6 col-lg-12 team">
    <h3 ID="teamLink" runat="server"/>
    <%= "Captain: " + this.Team.TeamCaptain.SummonerName %>
</div>