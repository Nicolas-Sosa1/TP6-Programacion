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

            gvProductos.DataSource = tabla;
            gvProductos.DataBind();
        }

        protected void gvProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvProductos.EditIndex = e.NewEditIndex;
            CargarGridView();
        }

       
        protected void gvProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvProductos.EditIndex = -1;
            CargarGridView();
        }

        // UPDATE
        protected void gvProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string idProducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_eit_IdProducto")).Text;
            string nombreProducto = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_NombreProducto")).Text;
            string cantidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_CantidadPorUnidad")).Text;
            string precio = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_Precio")).Text;

            Producto producto = new Producto(Convert.ToInt32(idProducto), nombreProducto, cantidad, Convert.ToDecimal(precio));

            GestionProductos gestion = new GestionProductos();

            string consulta = gestion.ActualizarProducto(producto);
            conexion.EjecutarTransaccion(consulta);
            gvProductos.EditIndex = -1;
            CargarGridView();
        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            CargarGridView();
        }

        // DELETE
        protected void gvProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string idProducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_it_idProducto")).Text;

            Producto producto = new Producto(Convert.ToInt32(idProducto));

            GestionProductos gestion = new GestionProductos();

            string consulta = gestion.EliminarProducto(producto);
            conexion.EjecutarTransaccion(consulta);

            CargarGridView();
        }

    }
}