using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Maestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}