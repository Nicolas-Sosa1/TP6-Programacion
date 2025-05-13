using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_Grupo18_Programacion
{
    public partial class MostrarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Tabla"] != null)
            {
                gvProductos.DataSource = (DataTable)Session["Tabla"];
                gvProductos.DataBind();
            }
        }
    }
}