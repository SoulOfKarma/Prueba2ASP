<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CapaPresentacion.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
    ID :<asp:TextBox ID="txtID" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RFVID" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtID"></asp:RequiredFieldValidator>
    <br />
    <br />
    Pass :<asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RFVPass" runat="server" ControlToValidate="txtPass" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Button ID="btnLogin" runat="server" Text="Ir" OnClick="btnLogin_Click" /><br /><br /><br />
    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver a pagina anterior" />
    <br />
</asp:Content>
