<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="CotizacionProducto.aspx.cs" Inherits="CapaPresentacion.CotizacionProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     ID :<asp:TextBox ID="txtID" runat="server"></asp:TextBox><br /><br />
    Nombre : <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br /><br />
    Marca :<asp:TextBox ID="txtMarca" runat="server"></asp:TextBox><br /><br />
    Precio: <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox><br /><br />
    Stock :<asp:TextBox ID="txtStock" runat="server"></asp:TextBox><br /><br />
    Minimarket : <asp:DropDownList ID="DDLMini" runat="server"></asp:DropDownList><br /><br />
    Cotizar X Stock : <asp:TextBox ID="txtCotizarxstock" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    Precio Calculado : <asp:TextBox ID="txtTotal" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Button ID="btnCotizar" runat="server" Text="Cotizar" OnClick="btnCotizar_Click" /><br /><br />
    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
     <br />
     <br />
     <br />
     <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver a pagina anterior" />
     <br />
</asp:Content>
