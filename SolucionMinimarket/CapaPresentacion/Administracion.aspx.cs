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
    public partial class Administracion : System.Web.UI.Page
    {
        CapaNegocio.ColleccionProductos a = new ColleccionProductos();

        private Usuario MiUsuario
        {
            get
            {
                if (Session["MiUsuario"] == null)
                {
                    Response.Redirect("Index.aspx");
                }
                return (Usuario)Session["MiUsuario"];
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarDatos();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarProducto.aspx");
        }

        protected void btmEliMod_Click(object sender, EventArgs e)
        {
            Response.Redirect("EliminarActualizarProducto.aspx");
        }
       

    public void cargarDatos()
        {
            gvProducto.DataSource = a.readAll();
            gvProducto.DataBind();
        }

        protected void gvProducto_PageIndexChanging(object sender, GridViewPageEventArgs e)
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
                Response.Redirect(string.Format("EditarPrecio.aspx?id={0}",id));
            }

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}