using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Pez : Animal
    {
        public Pez() { }
        public Pez(string raza, double peso, double altura, string color, string alimentacion, string nombre, double precio, string imagen, string descripcion) : base(raza, peso, altura, color, alimentacion, nombre, precio, imagen, descripcion)
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
            return Descripcion + "\n"+"Precio:  $" + Precio + " pesos\n" + "Raza: " + Raza +"\n"+ "Peso: " + PesoAnimal+ " Kg" + "\n" + "Altura: " + AlturaAnimal + " metros" +"\n"+ "Color: " + Color +"\n"+"Alimentacion: " + Alimentacion;
        }
    }
}
