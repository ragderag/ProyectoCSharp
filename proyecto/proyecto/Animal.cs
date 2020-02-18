using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Animal : Producto
    {
        string raza;
        double peso_a;
        double altura_a;
        string color;
        string alimentacion;

        public string Raza { get { return raza; } set { raza = value; } }
        public double PesoAnimal { get { return peso_a; } set { peso_a = value; } }
        public double AlturaAnimal { get { return altura_a; } set { altura_a = value; } }
        public string Color { get { return color; } set { color = value; } }
        public string Alimentacion { get { return alimentacion; } set { alimentacion = value; } }

        public Animal() { }
        public Animal(string raza,double peso,double altura,string color,string alimentacion,string nombre, double precio, string imagen, string descripcion):base(nombre,precio,imagen,descripcion)
        {
            Raza = raza;
            PesoAnimal = peso;
            AlturaAnimal = altura;
            Color = color;
            Nombre = nombre;
            Precio = precio;
            Imagen = imagen;
            Descripcion = descripcion;
            Alimentacion = alimentacion;

        }
        public override string ToString()
        {
            return Descripcion + " Precio:  $" + Precio + " pesos" + "Raza: " + Raza + " Peso: " + PesoAnimal + "Kg" + "Altura: " + AlturaAnimal + "metros" + " Color: " + Color + "Alimentacion: "+ Alimentacion;
        }
    }
}
