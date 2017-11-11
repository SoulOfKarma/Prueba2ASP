<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="EditarPrecio.aspx.cs" Inherits="CapaPresentacion.EditarPrecio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     ID :<asp:TextBox ID="txtID" runat="server"></asp:TextBox><br /><br />
    Nombre : <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br /><br />
    Marca :<asp:TextBox ID="txtMarca" runat="server"></asp:TextBox><br /><br />
    Precio: <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox><br /><br />
    Stock :<asp:TextBox ID="txtStock" runat="server"></asp:TextBox><br /><br />
    Minimarket : <asp:DropDownList ID="DDLMini" runat="server"></asp:DropDownList><br /><br />
    <asp:Button ID="btnModificar" runat="server" Text="Modificar Precio" OnClick="btnModificar_Click" />
     <br />
     <br />
     <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver a pagina anterior" />
</asp:Content>
