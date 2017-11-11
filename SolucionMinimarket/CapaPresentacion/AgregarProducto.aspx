<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="AgregarProducto.aspx.cs" Inherits="CapaPresentacion.AgregarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    ID :<asp:TextBox ID="txtID" runat="server"></asp:TextBox><br /><br />
    Nombre : <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br /><br />
    Marca :<asp:TextBox ID="txtMarca" runat="server"></asp:TextBox><br /><br />
    Precio: <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox><br /><br />
    Stock :<asp:TextBox ID="txtStock" runat="server"></asp:TextBox><br /><br />
    Minimarket : <asp:DropDownList ID="DDLMini" runat="server"></asp:DropDownList>
    <asp:Button ID="btnAgregar" runat="server" Text="Agregar Producto" OnClick="btnAgregar_Click" />
    <br />
    <br />
    <br />
    <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver a pagina anterior" />
</asp:Content>
