using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Entity;

namespace CapaNegocio
{
    public class CommonBC
    {
        private static BaseDatosMinimarketEntities _modeloMinimarket;

        public static BaseDatosMinimarketEntities ModeloMinimarket
        {
            get
            {
                if (_modeloMinimarket == null)
                {
                    _modeloMinimarket = new BaseDatosMinimarketEntities();
                    
                }
                return _modeloMinimarket;
            }
        }

        public CommonBC() { }

    }
}
