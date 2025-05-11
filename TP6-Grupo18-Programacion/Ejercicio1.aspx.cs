using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_Grupo18_Programacion.Clases;

namespace TP6_Grupo18_Programacion
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        private Conexion conexion = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGridView();
            }
        }

        public void CargarGridView()
        {
            string consultaProductos = "SELECT * FROM Productos";
            SqlDataAdapter adapter = conexion.ObtenerAdaptador(consultaProductos);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);

            gvProducto.DataSource = tabla;
            gvProducto.DataBind();
        }
    }
}