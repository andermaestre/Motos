<%@ Page Title="Login" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.cs" Inherits="PaginaMotos.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Login.css" rel="stylesheet" />
        <div class="login1">
            <div class="duo">
                <asp:Label class="login" runat="server" Text="Usuario"></asp:Label>

                <asp:TextBox CssClass="login" runat="server" ID="tbUser"></asp:TextBox>
            </div>
            <div class="duo">
                <asp:Label CssClass="login" runat="server" Text="Contraseña"></asp:Label>

                <asp:TextBox CssClass="login" runat="server" ID="tbPass"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            </div>
        </div>
    </asp:Content>
            
