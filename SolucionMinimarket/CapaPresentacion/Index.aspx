<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CapaPresentacion.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnLista" runat="server" Text="Lista Productos" OnClick="btnLista_Click" />
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
</asp:Content>
