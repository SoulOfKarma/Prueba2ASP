using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class AgregarProducto : System.Web.UI.Page
    {
        CapaNegocio.ColleccionMinimarket a = new ColleccionMinimarket();

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
                cargarDDL();
            }
        }

        public void cargarDDL()
        {
            DDLMini.DataSource = a.readAll();
            DDLMini.DataTextField = "Nombre_Minimarket";
            DDLMini.DataValueField = "Id_Minimarket";
            DDLMini.DataBind();

        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaNegocio.Producto a = new Producto();
                a.Id_producto = Convert.ToInt32(txtID.Text);
                if (!a.buscarProducto())
                {
                    a.Id_producto = Convert.ToInt32(txtID.Text);
                    a.Nombre_producto = txtNombre.Text;
                    a.Marca_producto = txtMarca.Text;
                    a.Precio_producto = Convert.ToInt32(txtPrecio.Text);
                    a.Stock_producto = Convert.ToInt32(txtStock.Text);
                    a.Id_min = Convert.ToInt32(DDLMini.SelectedValue.ToString());
                    a.crearProducto();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :"+ex.Message);
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administracion.aspx");
        }
    }
}