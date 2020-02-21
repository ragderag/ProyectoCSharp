using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Producto
    {
        decimal precio;
        string imagen;
        string nombre;
        string descripcion;
        int cantidad;

        public decimal Precio{ get { return precio; } set { precio = value; } }
        public string Imagen { get { return imagen; } set { imagen = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public Producto(string nombre,decimal precio, string imagen,string descripcion) 
        {
            Nombre = nombre;
            Precio = precio;
            Imagen = imagen;
            Descripcion = descripcion;
        }
        public Producto(string nombre, decimal precio, int cantidad, string imagen, string descripcion)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            Imagen = imagen;
            Descripcion = descripcion;
        }
        public override string ToString()
        {
            return Descripcion +" Precio:  $"+ Precio + " pesos";
        }
    }
}
