<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="EliminarActualizarProducto.aspx.cs" Inherits="CapaPresentacion.EliminarActualizarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
     ID :<asp:TextBox ID="txtID" runat="server"></asp:TextBox><br /><br />
    Nombre : <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br /><br />
    Marca :<asp:TextBox ID="txtMarca" runat="server"></asp:TextBox><br /><br />
    Precio: <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox><br /><br />
    Stock :<asp:TextBox ID="txtStock" runat="server"></asp:TextBox><br /><br />
    Minimarket : <asp:DropDownList ID="DDLMini" runat="server"></asp:DropDownList><br /><br />
    <asp:Button ID="btnConsultar" runat="server" Text="Consultar Producto" OnClick="btnConsultar_Click" /><br /><br />
    <asp:Button ID="btnModificar" runat="server" Text="Modificar Producto" OnClick="btnModificar_Click" /><br /><br />
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Producto" OnClick="btnEliminar_Click" />
    <br />
    <br />
    <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver a pagina anterior" />
    <br /><br />
    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label><br />
</asp:Content>
