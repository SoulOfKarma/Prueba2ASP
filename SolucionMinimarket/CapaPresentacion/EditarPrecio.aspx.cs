using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class EditarPrecio : System.Web.UI.Page
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
                string valor = Convert.ToString(Request.QueryString["id"]);
                cargarData(valor);
                cargarDDL();
                txtID.Enabled = false;
                txtNombre.Enabled = false;
                txtMarca.Enabled = false;
                txtStock.Enabled = false;
                DDLMini.Enabled = false;

            }
        }

        public void cargarData(string val)
        {
            try
            {
                CapaNegocio.Producto bib = new CapaNegocio.Producto();
                bib.Id_producto = int.Parse(val);

                if (bib.buscarProducto())
                {
                    txtID.Text = val;
                    txtNombre.Text = bib.Nombre_producto;
                    txtMarca.Text = bib.Marca_producto;
                    txtMarca.Text = bib.Marca_producto;
                    txtPrecio.Text = bib.Precio_producto.ToString();
                    txtStock.Text = bib.Stock_producto.ToString();
                    
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :"+ex.Message);
            }
        }
       

        public void cargarDDL()
        {
            DDLMini.DataSource = a.readAll();
            DDLMini.DataTextField = "Nombre_Minimarket";
            DDLMini.DataValueField = "Id_Minimarket";
            DDLMini.DataBind();

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

                    Response.Redirect("Administracion.aspx");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);

            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administracion.aspx");
        }
    }
}