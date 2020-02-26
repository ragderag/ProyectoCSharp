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
        static List<Animal> ComprasAnimales = new List<Animal>();

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
        public static void AgregarProducto(Animal obj)
        {
            bool bandera = false;
            if (ComprasAnimales.Count == 0)
                ComprasAnimales.Add(obj);
            else
                foreach (var i in ComprasAnimales)
                {
                    if (i.Nombre == obj.Nombre && i.Descripcion == obj.Descripcion)
                        i.Cantidad = i.Cantidad + obj.Cantidad;
                    else
                        bandera = true;
                }
            if (bandera)
            {
                ComprasAnimales.Add(obj);
                bandera = false;
            }
        }

        public static void QuitarProducto(Producto obj)
        {
            Producto aux=null;
            
            foreach(var i in Compras)
            {
                if(i.Nombre==obj.Nombre)
                    aux=i;
            }

            Compras.Remove(aux);
            
        }
        public static void QuitarProducto(Animal obj)
        {
            Animal aux = null;

            foreach (var i in ComprasAnimales)
            {
                if (i.Nombre == obj.Nombre)
                    aux = i;
            }

            ComprasAnimales.Remove(aux);

        }
        public static void QuitarCantidad(Producto obj, int can)
        {
            Producto aux = null;

            foreach (var i in Compras)
            {
                if (i.Nombre == obj.Nombre) { 
                    if (i.Cantidad <= can)
                        aux = i;
                    i.Cantidad = i.Cantidad - can;
                }
            }

            Compras.Remove(aux);
        }
        public static void QuitarCantidad(Animal obj, int can)
        {
            Animal aux = null;

            foreach (var i in ComprasAnimales)
            {
                if (i.Nombre == obj.Nombre)
                {
                    if (i.Cantidad <= can)
                        aux = i;
                    i.Cantidad = i.Cantidad - can;
                }
            }

            ComprasAnimales.Remove(aux);
        }

        public static void limpiar()
        {
            Compras.Clear();
            ComprasAnimales.Clear();
        }

        public static List<Producto> Mostrar()
        {
            return Compras;
        }

        public static List<Animal> MostrarAnimales()
        {
            return ComprasAnimales;
        }

    }
}
