using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Casa : Producto
    {
        double altura_c;
        double peso_c;
        double largo;
        double ancho;
        string material;
        public double AlturaCasa { get { return altura_c; } set { altura_c = value; } }
        public double PesoCasa { get { return peso_c; } set { peso_c = value; } }
        public double Largo { get {return largo; } set { largo = value; } }
        public double Ancho { get { return ancho; } set { ancho = value; } }
        public string Material { get { return material; } set { material = value; } }
        public Casa() { }
        public Casa (double altura_c, double peso_c,double largo,double ancho,string material, string nombre, double precio, string imagen, string descripcion) : base(nombre,precio,imagen,descripcion)
        {
            AlturaCasa = altura_c;
            PesoCasa = peso_c;
            Largo = largo;
            Ancho = ancho;
            Material = material;
            Nombre = nombre;
            Precio = precio;
            Imagen = imagen;
            Descripcion = descripcion;
        }
    }
}
