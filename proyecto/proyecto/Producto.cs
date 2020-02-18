using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Producto
    {
        double precio;
        string imagen;
        string nombre;
        string descripcion;

        public double Precio{ get { return precio; } set { precio = value; } }
        public string Imagen { get { return imagen; } set { imagen = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }

        public Producto(string nombre,double precio, string imagen,string descripcion) 
        {
            Nombre = nombre;
            Precio = precio;
            Imagen = imagen;
            Descripcion = descripcion;
        }
        public Producto() { }

        public void AgregarLista()
        {

        }
        public void QuitarLista()
        {

        }
        public void Comprar()
        {

        }
        public override string ToString()
        {
            return Descripcion +" Precio:  $"+ Precio + " pesos";
        }
    }
}
