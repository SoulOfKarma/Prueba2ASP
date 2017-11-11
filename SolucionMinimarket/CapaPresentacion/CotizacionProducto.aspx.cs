using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class CotizacionProducto : System.Web.UI.Page
    {
        CapaNegocio.ColleccionMinimarket a = new ColleccionMinimarket();
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
                txtPrecio.Enabled = false;
                txtTotal.Text = "0";
                Session.Clear();

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
                Console.WriteLine("Error :" + ex.Message);
            }
        }


        public void cargarDDL()
        {
            DDLMini.DataSource = a.readAll();
            DDLMini.DataTextField = "Nombre_Minimarket";
            DDLMini.DataValueField = "Id_Minimarket";
            DDLMini.DataBind();

        }

        protected void btnCotizar_Click(object sender, EventArgs e)
        {
            int CotStock = Convert.ToInt32(txtCotizarxstock.Text);
            int Stock = Convert.ToInt32(txtStock.Text);
            if (CotStock > Stock)
            {
                lblMensaje.Text = "Supera el stock que hay en el minimarket Porfavor cambiar valor a calcular";
            }
            else
            {
                int precio = Convert.ToInt32(txtPrecio.Text);
                int total = precio * CotStock;
                txtTotal.Text = total.ToString();

            }
            
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("DatosProductos.aspx");
        }
    }
}