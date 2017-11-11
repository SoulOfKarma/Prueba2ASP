<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="ListaProductos.aspx.cs" Inherits="CapaPresentacion.ListaProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvProducto" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_producto" OnPageIndexChanging="gvProducto_PageIndexChanging1" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" AllowPaging="True" OnRowCommand="gvProducto_RowCommand" >
        <Columns>
            <asp:BoundField DataField="Id_producto" HeaderText="Id_producto" SortExpression="Id_producto" />
            <asp:BoundField DataField="Nombre_producto" HeaderText="Nombre_producto" SortExpression="Nombre_producto" />
            <asp:BoundField DataField="Marca_producto" HeaderText="Marca_producto" SortExpression="Marca_producto" />
            <asp:BoundField DataField="Precio_producto" HeaderText="Precio_producto" SortExpression="Precio_producto" />
            <asp:BoundField DataField="Stock_producto" HeaderText="Stock_producto" SortExpression="Stock_producto" />
            <asp:BoundField DataField="Id_min" HeaderText="Id_min" SortExpression="Id_min" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
    <br />
    <br />
    <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver a pagina anterior" />
    <br /><br />
    <br />
&nbsp;
  

</asp:Content>
