using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Entity;

namespace CapaNegocio
{
    public class ColleccionUsuario
    {

        public List<Usuario> generarListado(List<CapaDatos.Usuario> ex)
        {

            List<Usuario> listMini = new List<Usuario>();
            foreach (CapaDatos.Usuario lel in ex)
            {
                CapaNegocio.Usuario val = new CapaNegocio.Usuario();
                val.Id_usuario = lel.Id_usuario;
                val.Pass_usuario = lel.Pass_usuario;
    

                listMini.Add(val);
            }

            return listMini;
        }

        public List<Usuario> readAll()
        {
            var val = CommonBC.ModeloMinimarket.Usuario;
            return generarListado(val.ToList());
        }
    }
}
