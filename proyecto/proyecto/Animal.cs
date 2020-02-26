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

        public string Raza { get { return raza; } set { raza = value; } }
        public double PesoAnimal { get { return peso_a; } set { peso_a = value; } }
        public double AlturaAnimal { get { return altura_a; } set { altura_a = value; } }
        public string Color { get { return color; } set { color = value; } }

        
        public Animal(string raza,double peso,double altura,string color, string nombre, decimal precio, string imagen, string descripcion,int cantidad):base(nombre,precio,imagen,descripcion,cantidad)
        {
            Raza = raza;
            PesoAnimal = peso;
            AlturaAnimal = altura;
            Color = color;

        }
        
        public override string ToString()
        {
            return Nombre + " Color: " + Color + " Especie: " + Raza + " Cantidad: " + Cantidad + " Precio:  $" + Precio + " pesos" ;
        }
        
    }
}
