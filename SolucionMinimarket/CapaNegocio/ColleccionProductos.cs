using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Entity;

namespace CapaNegocio
{
    public class ColleccionProductos
    {

        public List<Producto> generarListado(List<CapaDatos.Producto> ex)
        {

            List<CapaNegocio.Producto> listMini = new List<Producto>();
            foreach (CapaDatos.Producto lel in ex)
            {
                CapaNegocio.Producto val = new CapaNegocio.Producto();
                val.Id_producto = lel.Id_producto;
                val.Nombre_producto = lel.Nombre_producto;
                val.Marca_producto = lel.Marca_producto;
                val.Precio_producto = lel.Precio_producto;
                val.Stock_producto = lel.Stock_producto;
                val.Id_min = lel.Id_Minimarket;

                listMini.Add(val);
            }

            return listMini;
        }

        public List<Producto> readAll()
        {
            var val = CommonBC.ModeloMinimarket.Producto;
            return generarListado(val.ToList());
        }
    }
}
