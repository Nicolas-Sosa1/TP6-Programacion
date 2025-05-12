<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP6_Grupo18_Programacion.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Productos</h1>
            <br />
            <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="False" CellPadding="4" AutoGenerateEditButton="True" ForeColor="#333333" GridLines="None" OnRowEditing="gvProductos_RowEditing" OnRowUpdating="gvProductos_RowUpdating"  OnRowDeleting="gvProductos_RowDeleting" AllowPaging="True" OnPageIndexChanging="gvProductos_PageIndexChanging">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="Id Producto">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_IdProducto" runat="server" Text='<%# Bind("idProducto") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="lbl_eit_IdProducto" runat="server" Text='<%# Bind("idProducto") %>'></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre Producto">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_NombreProducto" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_eit_NombreProducto" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cantidad Por Unidad">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_CantidadPorUnidad" runat="server" Text='<%# Bind("CantidadPorUnidad") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_eit_CantidadPorUnidad" runat="server" Text='<%# Bind("CantidadPorUnidad") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Precio">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Precio" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_eit_Precio" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
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
        </div>
    </form>
</body>
</html>
