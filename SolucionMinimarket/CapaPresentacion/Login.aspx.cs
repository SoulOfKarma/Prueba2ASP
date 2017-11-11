using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Login : System.Web.UI.Page
    {
        private Usuario MiUsuario
        {
            get
            {
                if (Session["MiUsuario"] == null)
                {
                    Session["MiUsuario"] = new Usuario();
                }
                return (Usuario)Session["MiUsuario"];
            }
            set { Session["MiUsuario"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            CapaNegocio.Usuario a = new Usuario();
            a.Id_usuario = Convert.ToInt32(txtID.Text);
            a.Pass_usuario = txtPass.Text;
            if (!a.buscarUser())
            {
                lblMensaje.Text = "Usuario no existe";
            }
            else
            {
                Usuario b = new Usuario(Convert.ToInt32(txtID.Text), txtPass.Text);
                MiUsuario = b;
                Response.Redirect("Administracion.aspx");
            }
            

           
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}