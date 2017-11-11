using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class Producto
    {
        private int id_producto;
        private string nombre_producto;
        private string marca_producto;
        private int precio_producto;
        private int stock_producto;
        private int id_min;
        

        public int Id_producto
        {
            get
            {
                return id_producto;
            }

            set
            {
                id_producto = value;
            }
        }

        public string Nombre_producto
        {
            get
            {
                return nombre_producto;
            }

            set
            {
                nombre_producto = value;
            }
        }

        public string Marca_producto
        {
            get
            {
                return marca_producto;
            }

            set
            {
                marca_producto = value;
            }
        }

        public int Precio_producto
        {
            get
            {
                return precio_producto;
            }

            set
            {
                precio_producto = value;
            }
        }

        public int Stock_producto
        {
            get
            {
                return stock_producto;
            }

            set
            {
                stock_producto = value;
            }
        }

        public int Id_min
        {
            get
            {
                return id_min;
            }

            set
            {
                id_min = value;
            }
        }

        public Producto(int id_producto, string nombre_producto, string marca_producto, int precio_producto, int stock_producto)
        {
            this.id_producto = id_producto;
            this.nombre_producto = nombre_producto;
            this.marca_producto = marca_producto;
            this.precio_producto = precio_producto;
            this.stock_producto = stock_producto;
        }

        private void Init()
        {
            id_producto = 0;
            nombre_producto = string.Empty;
            marca_producto = string.Empty;
            precio_producto = 0;
            stock_producto = 0;
            id_min = 0;

        }

        public Producto()
        {
            Init();
        }

        public bool crearProducto()
        {
            try
            {
                CapaDatos.Producto a = new CapaDatos.Producto();
                a.Id_producto = this.Id_producto;
                a.Nombre_producto = this.Nombre_producto;
                a.Marca_producto = this.Marca_producto;
                a.Precio_producto = this.Precio_producto;
                a.Stock_producto = this.Stock_producto;
                a.Id_Minimarket = this.Id_min;

                CommonBC.ModeloMinimarket.Producto.Add(a);
                CommonBC.ModeloMinimarket.SaveChanges();


                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :"+ex.Message);
                return false;
            }

        }

        public bool buscarProducto()
        {
            try
            {
                CapaDatos.Producto a = CommonBC.ModeloMinimarket.Producto.First(val => val.Id_producto == this.Id_producto);
                this.Id_producto = a.Id_producto;
                this.Nombre_producto = a.Nombre_producto;
                this.Marca_producto = a.Marca_producto;
                this.Precio_producto = a.Precio_producto;
                this.Stock_producto = a.Stock_producto;

                


                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
                return false;
            }

        }

        public bool modificarProducto()
        {
            try
            {
                CapaDatos.Producto a = CommonBC.ModeloMinimarket.Producto.First(val => val.Id_producto == this.Id_producto);
              
                a.Nombre_producto = this.Nombre_producto;
                a.Marca_producto = this.Marca_producto;
                a.Precio_producto = this.Precio_producto;
                a.Stock_producto = this.Stock_producto;
                a.Id_Minimarket = this.Id_min;

                
                CommonBC.ModeloMinimarket.SaveChanges();


                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
                return false;
            }

        }

        public bool eliminarProducto()
        {
            try
            {
                CapaDatos.Producto a = CommonBC.ModeloMinimarket.Producto.First(val => val.Id_producto == this.Id_producto);

                CommonBC.ModeloMinimarket.Producto.Remove(a);


                CommonBC.ModeloMinimarket.SaveChanges();


                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
                return false;
            }

        }

    }
}
