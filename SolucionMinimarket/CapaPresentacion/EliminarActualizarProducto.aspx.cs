using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class EliminarActualizarProducto : System.Web.UI.Page
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

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaNegocio.Producto bib = new CapaNegocio.Producto();
                bib.Id_producto = int.Parse(txtID.Text);

                if (bib.buscarProducto())
                {
                    txtNombre.Text = bib.Nombre_producto;
                    txtMarca.Text = bib.Marca_producto;
                    txtMarca.Text = bib.Marca_producto;
                    txtPrecio.Text = bib.Precio_producto.ToString();
                    txtStock.Text = bib.Stock_producto.ToString();
                    lblMensaje.Text = string.Empty;
                }
                else
                {
                    lblMensaje.Text = "Producto no existe";
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error : " + ex.Message;
                limpiar();
            }
        }

        public void limpiar()
        {
            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
        }
        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaNegocio.Producto a = new Producto();
                a.Id_producto = Convert.ToInt32(txtID.Text);
                if (a.buscarProducto())
                {
                    a.Id_producto = Convert.ToInt32(txtID.Text);
                    a.Nombre_producto = txtNombre.Text;
                    a.Marca_producto = txtMarca.Text;
                    a.Precio_producto = Convert.ToInt32(txtPrecio.Text);
                    a.Stock_producto = Convert.ToInt32(txtStock.Text);
                    a.Id_min = Convert.ToInt32(DDLMini.SelectedValue.ToString());
                    a.modificarProducto();
                    lblMensaje.Text = "Producto Modificado";
                    limpiar();
                    cargarDDL();
                }
                else
                {
                    lblMensaje.Text = "Producto No existe";
                }
             }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
                lblMensaje.Text = "Error al modificar";
                limpiar();
                cargarDDL();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaNegocio.Producto a = new Producto();
                a.Id_producto = Convert.ToInt32(txtID.Text);
                if (a.buscarProducto())
                {
                    a.eliminarProducto();
                    lblMensaje.Text = "Producto Eliminado";
                    limpiar();
                    cargarDDL();
                }
                else
                {
                    lblMensaje.Text = "Producto no existe";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
                lblMensaje.Text = "Error al borrar ";
                
                cargarDDL();
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administracion.aspx");
        }
    }
}