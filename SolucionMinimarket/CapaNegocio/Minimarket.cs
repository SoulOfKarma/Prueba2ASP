using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Minimarket
    {
        private int id_minimarket;
        private string nombre_minimarket;
        private string direccion_minimarket;



        public int Id_minimarket
        {
            get
            {
                return id_minimarket;
            }

            set
            {
                id_minimarket = value;
            }
        }

        public string Nombre_minimarket
        {
            get
            {
                return nombre_minimarket;
            }

            set
            {
                nombre_minimarket = value;
            }
        }

        public string Direccion_minimarket
        {
            get
            {
                return direccion_minimarket;
            }

            set
            {
                direccion_minimarket = value;
            }
        }

        public Minimarket(int id_minimarket, string nombre_minimarket, string direccion_minimarket)
        {
            this.id_minimarket = id_minimarket;
            this.nombre_minimarket = nombre_minimarket;
            this.direccion_minimarket = direccion_minimarket;
        }

        private void Init()
        {
            id_minimarket = 0;
            nombre_minimarket = string.Empty;
            direccion_minimarket = string.Empty;

        }

        public Minimarket()
        {
            Init();
        }


    }
}
