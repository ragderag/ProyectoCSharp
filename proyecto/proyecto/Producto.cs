using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Producto
    {
        decimal Precio;
        string Imagen;
        string Nombre;
        string Descripcion;

        public decimal precio{ get { return Precio; } set { Precio = value; } }
        public string imagen { get { return Imagen; } set { Imagen = value; } }
        public string nombre { get { return Nombre; } set { Nombre = value; } }
        public string descripcion { get { return Descripcion; } set { Descripcion = value; } }

        public Producto(string nombre,decimal precio, string imagen,string descripcion) 
        {
            Nombre = nombre;
            Precio = precio;
            Imagen = imagen;
            Descripcion = descripcion;
        }
        public override string ToString()
        {
            return Descripcion +" Precio:  $"+ Precio + " pesos";
        }
    }
}
