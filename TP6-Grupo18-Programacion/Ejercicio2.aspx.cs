using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_Grupo18_Programacion
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbEliminarProductosSeleccionados_Click(object sender, EventArgs e)
        {
            Session["Tabla"] = null;
            lblEliminar.Text = "Se eliminaron todos los productos seleccionados por el usuario";
            lblEliminar.ForeColor = System.Drawing.Color.Red;
        }
    }
}