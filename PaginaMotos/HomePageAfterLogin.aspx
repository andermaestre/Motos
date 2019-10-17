<%@ Page Title="Pagina kdd's" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomePageAfterLogin.aspx.cs" Inherits="PaginaMotos.HomePageAfterLogin" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="kdds">
        <h3>KDD's</h3>
        <asp:Button ID="Button1" runat="server" Text="+" />
        <asp:GridView ID="GridView1" runat="server" CssClass="MeetingsTable"></asp:GridView>
    </div>
    <br />
    <div></div>
    <br />
    <div class="calendar">
        <asp:Calendar ID="Calendar1" runat="server" CssClass="MeetingsTable"></asp:Calendar>
    </div>
</asp:Content>







