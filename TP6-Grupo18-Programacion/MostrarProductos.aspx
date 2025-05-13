<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarProductos.aspx.cs" Inherits="TP6_Grupo18_Programacion.MostrarProductos" %>

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
            Productos seleccionados por el usuario:<br />
            <br />
            <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <Columns>
                    <asp:TemplateField HeaderText="Id Producto">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_idProducto" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
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
                    <asp:TemplateField HeaderText="Precio Unidad">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_precio" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            <br />
            <asp:HyperLink ID="hlVolver" runat="server" NavigateUrl="~/Ejercicio2.aspx">Volver al Inicio</asp:HyperLink>
            <br />
        </div>
    </form>
</body>
</html>
