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
        double peso;
        double altura;
        string color;

        public string Raza { get { return raza; } set { raza = value; } }
        public double Peso { get { return peso; } set { peso = value; } }
        public double Altura { get { return altura; } set { altura = value; } }
        public string Color { get { return color; } set { color = value; } }

        public Animal() { }
        public Animal(string raza,double peso,double altura,string color, string nombre, double precio, string imagen, string descripcion):base(nombre,precio,imagen,descripcion)
        {
            Raza = raza;
            Peso = peso;
            Altura = altura;
            Color = color;
            Nombre = nombre;
            Precio = precio;
            Imagen = imagen;
            Descripcion = descripcion;

        }
        public override string ToString()
        {
            return Descripcion + " Precio:  $" + Precio + " pesos" + "Raza: " + Raza + " Peso: " + Peso + "Kg" + "Altura: " + Altura + "metros" + " Color:" + Color;
        }
    }
}
