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
                Session["Tabla"] = CrearTabla();
            }
            // Guardar la Session DataTable en un objeto DataTable para verificar si en sus filas tiene algun ID Producto igual al seleccionado
            DataTable tabla = (DataTable)Session["Tabla"];
            bool yaExiste = tabla.AsEnumerable().Any(row => row["IdProducto"].ToString() == idProducto);

            // Si el ID ya existe
            if (yaExiste)
            {
                lblMensaje.Text = "Producto ya agregado, seleccione otro";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
            // Si no existe agrega el producto
            else
            {
                AgregarFila((DataTable)Session["Tabla"], idProducto, nombreProducto, proveedor, precio);
                Session["Tabla"] = tabla;
                lblMensaje.Text = "Productos agregados: " + nombreProducto;
                lblMensaje.ForeColor = System.Drawing.Color.Green;
            }
        }

        private DataTable CrearTabla()
        {
            DataTable tabla = new DataTable();
            DataColumn column = new DataColumn("IdProducto", System.Type.GetType("System.String"));

            tabla.Columns.Add(column);
            column = new DataColumn("NombreProducto", System.Type.GetType("System.String"));
            tabla.Columns.Add(column);
            column = new DataColumn("IdProveedor", System.Type.GetType("System.String"));
            tabla.Columns.Add(column);
            column = new DataColumn("PrecioUnidad", System.Type.GetType("System.String"));
            tabla.Columns.Add(column);

            return tabla;
        }

        private DataTable AgregarFila(DataTable tabla, string idProducto, string nombre, string proveedor, string precio)
        {
            DataRow row = tabla.NewRow();

            row["IdProducto"] = idProducto;
            row["NombreProducto"] = nombre;
            row["IdProveedor"] = proveedor;
            row["PrecioUnidad"] = precio;

            tabla.Rows.Add(row);

            return tabla;
        }

    }
}