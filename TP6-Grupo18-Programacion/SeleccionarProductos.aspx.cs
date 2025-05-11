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
    public partial class SeleccionarProductos : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
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

            gvProductos.DataSource = tabla;
            gvProductos.DataBind();
        }

        protected void gvProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string idProducto = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_idProducto")).Text;
            string nombreProducto = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_nombre")).Text;
            string proveedor = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_proveedor")).Text;
            string precio = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_precio")).Text;

            // Crear la Session si esta no existe (primera vez o cuando es borrada por el linkbutton)
            if (Session["Tabla"] == null)
            {
                
            }
        }

     
    }
}