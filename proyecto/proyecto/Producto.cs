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
        decimal cantidad;

        public decimal Precio{ get { return precio; } set { precio = value; } }
        public string Imagen { get { return imagen; } set { imagen = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public decimal Cantidad { get { return cantidad; } set { cantidad = value; } }
        public Producto(string nombre,decimal precio, string imagen,string descripcion,decimal cantidad) 
        {
            Nombre = nombre;
            Precio = precio;
            Imagen = imagen;
            Descripcion = descripcion;
            Cantidad = cantidad;
        }
        public override string ToString()
        {
            return Nombre+" Cantidad: "+cantidad +" Precio:  $"+ Precio + " pesos";
        }
    }
}
