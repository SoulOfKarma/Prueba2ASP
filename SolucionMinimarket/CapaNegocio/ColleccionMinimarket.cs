using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Entity;

namespace CapaNegocio
{
    public class ColleccionMinimarket
    {
        public List<Minimarket> generarListado(List<CapaDatos.Minimarket> ex)
        {

            List<Minimarket> listMini = new List<Minimarket>();
            foreach (CapaDatos.Minimarket lel in ex)
            {
                CapaNegocio.Minimarket val = new CapaNegocio.Minimarket();
                val.Id_minimarket = lel.Id_Minimarket;
                val.Nombre_minimarket = lel.Nombre_Minimarket;
                val.Direccion_minimarket = lel.Direccion_Minimarket;

                listMini.Add(val);
            }

            return listMini;
        }

        public List<Minimarket> readAll()
        {
            var val = CommonBC.ModeloMinimarket.Minimarket;
            return generarListado(val.ToList());
        }

        
    }
}
