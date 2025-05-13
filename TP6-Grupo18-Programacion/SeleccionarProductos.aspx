<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarProductos.aspx.cs" Inherits="TP6_Grupo18_Programacion.SeleccionarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
            <br /><br />
            <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" AutoGenerateSelectButton="True" OnSelectedIndexChanging="gvProductos_SelectedIndexChanging">
            <Columns>
                <asp:TemplateField HeaderText="Id Producto">
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_idProducto" runat="server" Text='<%# Bind("idProducto") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre Producto">                    
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_nombre" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Id Proveedor">
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_proveedor" runat="server" Text='<%# Bind("idProveedor") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Precio Unitario">
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_precio" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
                <br /><br />
                <asp:HyperLink ID="hlVolver" runat="server" NavigateUrl="~/Ejercicio2.aspx">Volver al inicio</asp:HyperLink>
        </div>
    </form>
</body>
</html>
