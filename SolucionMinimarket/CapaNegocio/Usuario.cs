using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Usuario
    {
        private int id_usuario;
        private string pass_usuario;

        

        public int Id_usuario
        {
            get
            {
                return id_usuario;
            }

            set
            {
                id_usuario = value;
            }
        }

        public string Pass_usuario
        {
            get
            {
                return pass_usuario;
            }

            set
            {
                pass_usuario = value;
            }
        }
        public Usuario(int id_usuario, string pass_usuario)
        {
            this.id_usuario = id_usuario;
            this.pass_usuario = pass_usuario;
        }

        private void Init()
        {
            id_usuario = 0;
            pass_usuario = string.Empty;
        }

        public Usuario()
        {
            Init();
        }

        public bool buscarUser()
        {
            try
            {
                CapaDatos.Usuario a = CommonBC.ModeloMinimarket.Usuario.First(val => val.Id_usuario == this.Id_usuario);
                
                if (this.Id_usuario == a.Id_usuario && this.Pass_usuario == a.Pass_usuario)
                {
                    return true;

                }
                else
                {
                    return false;
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
                return false;
            }

        }

    }
}
