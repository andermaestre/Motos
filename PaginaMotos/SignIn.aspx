<%@ Page Title="Signin" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SignIn.aspx.cs" Inherits="PaginaMotos.SignIn" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Login.css" rel="stylesheet" />
        <div class="login1">
            <div class="duo">
                <asp:Label class="login" runat="server" Text="Usuario"></asp:Label>

                <asp:TextBox class="login" runat="server"></asp:TextBox>
            </div>
            <div class="duo">

                
            </div>
        </div>
    <div class="login1">
            <div class="duo">
                <asp:Label class="login" runat="server" Text="Nombre"></asp:Label>

                <asp:TextBox class="login" runat="server"></asp:TextBox>
            </div>
            <div class="duo">
                <asp:Label class="login" runat="server" Text="Apellido"></asp:Label>

                <asp:TextBox class="login" runat="server"></asp:TextBox>
            </div>
        </div>
    <div class="login1">
            <div class="duo">
                <asp:Label class="login" runat="server" Text="Contraseña"></asp:Label>

                <asp:TextBox class="login" runat="server"></asp:TextBox>
            </div>
            <div class="duo">
                <asp:Label class="login" runat="server" Text="Contraseña"></asp:Label>

                <asp:TextBox class="login" runat="server"></asp:TextBox>
            </div>
        </div>
    <div class="boton">


        <button type="button" class="btn btn-outline-success">Uneme al club</button>
        

    </div>
    
</asp:Content>