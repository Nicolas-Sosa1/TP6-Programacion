<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP6_Grupo18_Programacion.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Inicio</h1>
            <asp:HyperLink ID="hlSeleccionarProductos" runat="server" NavigateUrl="~/SeleccionarProductos.aspx">Seleccionar Productos</asp:HyperLink>
            <br /><br />
            <asp:LinkButton ID="lbEliminarProductosSeleccionados" runat="server" OnClick="lbEliminarProductosSeleccionados_Click">Eliminar Productos Seleccionados</asp:LinkButton>
            <br /><br />
            <asp:HyperLink ID="hlMostrarProductos" runat="server" NavigateUrl="~/MostrarProductos.aspx">Mostrar Productos</asp:HyperLink>
            <br /><br />
            <asp:Label ID="lblEliminar" runat="server" Text=""></asp:Label>
            <br /><br />
            <asp:HyperLink ID="hlVolverInicio" runat="server" NavigateUrl="~/Inicio.aspx">Volver atras</asp:HyperLink>
        </div>
    </form>
</body>
</html>
