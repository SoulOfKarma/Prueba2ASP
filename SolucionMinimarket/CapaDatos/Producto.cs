//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public int Id_producto { get; set; }
        public string Nombre_producto { get; set; }
        public string Marca_producto { get; set; }
        public int Precio_producto { get; set; }
        public int Stock_producto { get; set; }
        public int Id_Minimarket { get; set; }
    
        public virtual Minimarket Minimarket { get; set; }
    }
}
