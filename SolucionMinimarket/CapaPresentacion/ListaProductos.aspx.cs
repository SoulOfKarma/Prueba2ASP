using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using System.Data.Entity;

namespace CapaPresentacion
{
    public partial class ListaProductos : System.Web.UI.Page
    {
        CapaNegocio.ColleccionProductos a = new ColleccionProductos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarDatos();
            }
            Session.Clear();

        }

        public void cargarDatos()
        {
            gvProducto.DataSource = a.readAll();
            gvProducto.DataBind();
        }

        protected void gvProducto_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
          
        }

        protected void gvProducto_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            gvProducto.PageIndex = e.NewPageIndex;
            cargarDatos();
        }

        protected void gvProducto_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {

                int index = Convert.ToInt32(e.CommandArgument);


                int id = Convert.ToInt32(gvProducto.DataKeys[index].Value);
                Response.Redirect(string.Format("DatosProductos.aspx?id={0}", id));
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}