using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_Grupo18_Programacion.Clases
{
    public class GestionProductos
    {
        public string ActualizarProducto(Producto producto)
        {
            string consulta = "UPDATE Productos SET NombreProducto = '" + producto.getNombre() + "', CantidadPorUnidad = '" + producto.getCantidad() +
            "', PrecioUnidad = " + producto.getPrecio() + " WHERE idProducto = " + producto.getId();
            return consulta;
        }

        public string EliminarProducto(Producto producto)
        {
            string consulta = "DELETE FROM Productos WHERE idProducto = " + producto.getId();
            return consulta;
        }
    }
}