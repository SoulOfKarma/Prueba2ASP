<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Administracion.aspx.cs" Inherits="CapaPresentacion.Administracion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Button ID="btnAgregar" runat="server" Text="Agregar " OnClick="btnAgregar_Click" />
    <asp:Button ID="btmEliMod" runat="server" Text="Eliminar o Modificar" OnClick="btmEliMod_Click" />
   

    <asp:GridView ID="gvProducto" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id_producto" ForeColor="#333333" GridLines="None" OnPageIndexChanging="gvProducto_PageIndexChanging" OnRowCommand="gvProducto_RowCommand">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Id_producto" HeaderText="Id_producto" SortExpression="Id_producto" />
            <asp:BoundField DataField="Nombre_producto" HeaderText="Nombre_producto" SortExpression="Nombre_producto" />
            <asp:BoundField DataField="Marca_producto" HeaderText="Marca_producto" SortExpression="Marca_producto" />
            <asp:BoundField DataField="Precio_producto" HeaderText="Precio_producto" SortExpression="Precio_producto" />
            <asp:BoundField DataField="Stock_producto" HeaderText="Stock_producto" SortExpression="Stock_producto" />
            <asp:BoundField DataField="Id_min" HeaderText="Id_min" SortExpression="Id_min" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    
    <br />
    <br />
    <asp:Button ID="btnVolver" runat="server" Text="Volver a pagina anterior" OnClick="btnVolver_Click" />
    
</asp:Content>
