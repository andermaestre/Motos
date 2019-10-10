<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PaginaMotos._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            </div>
    </div>

    <div class="row">
        
    </div>

</asp:Content>
