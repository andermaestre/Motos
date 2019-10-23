<%@ Page Title="Signin" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SignIn.aspx.cs" Inherits="PaginaMotos.SignIn" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Login.css" rel="stylesheet" />
        <div class="login1">
            <div class="duo">
                <asp:Label class="login" runat="server" Text="Usuario"></asp:Label>

                <asp:TextBox class="login" runat="server" ID="tbaNick"></asp:TextBox>
            </div>
            <div class="duo">

                
            </div>
        </div>
    <div class="login1">
            <div class="duo">
                <asp:Label class="login" runat="server" Text="Nombre"></asp:Label>

                <asp:TextBox class="login" runat="server" ID="tbaNombre"></asp:TextBox>
            </div>
            <div class="duo">
                <asp:Label class="login" runat="server" Text="Apellido"></asp:Label>

                <asp:TextBox class="login" runat="server" ID="tbaApellido"></asp:TextBox>
            </div>
        </div>
    <div class="login1">
            <div class="duo">
                <asp:Label class="login" runat="server" Text="Contraseña"></asp:Label>

                <asp:TextBox class="login" runat="server" ID="tbaPass"></asp:TextBox>
            </div>
            <div class="duo">
                <asp:Label class="login" runat="server" Text="Contraseña"></asp:Label>

                <asp:TextBox class="login" runat="server" ID="tbaPass2"></asp:TextBox>
            </div>
        </div>
    <div class="boton">


        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        

    </div>
    
</asp:Content>