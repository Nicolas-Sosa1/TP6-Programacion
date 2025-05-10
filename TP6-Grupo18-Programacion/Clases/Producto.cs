using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_Grupo18_Programacion.Clases
{
    public class Producto
    {
        // ATRIBUTOS
        private int id;
        private string nombre;
        private string cantidad;
        private decimal precio;

        // CONSTRUCTORES
        public Producto(int id, string nombre, string cantidad, decimal precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public Producto(int id)
        {
            this.id = id;
        }

        // GETTERS
        public int getId() { return id; }
        public string getNombre() { return nombre; }
        public string getCantidad() { return cantidad; }
        public decimal getPrecio() { return precio; }
    }
}