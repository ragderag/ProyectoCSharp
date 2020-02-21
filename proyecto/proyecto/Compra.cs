using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Compra
    {
        static List<Producto> Compras = new List<Producto>();

        public static void AgregarProducto(Producto obj)
        {
            bool bandera = false;
            if (Compras.Count == 0)
                Compras.Add(obj);
            else
                foreach (var i in Compras)
                {
                    if (i.Nombre == obj.Nombre && i.Descripcion == obj.Descripcion)
                        i.Cantidad = i.Cantidad + obj.Cantidad;
                    else
                        bandera = true; 
                }
            if (bandera)
            {
                Compras.Add(obj);
                bandera = false;
            }
        }

        public void QuitarProducto(Producto obj)
        {
        }

        public void QuitarCantidad(Producto obj, int can)
        {
        }

        public static void limpiar()
        {
            Compras.Clear();
        }
        public static List<Producto> Mostrar()
        {
            return Compras;
        }
    }
}
