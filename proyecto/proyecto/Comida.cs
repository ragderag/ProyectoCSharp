using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Comida : Producto
    {
        string marca;
        double cantidad_c;
        string tipo;
        public string Marca { get { return marca; } set { marca = value; } }
        public double CantidadComida { get { return cantidad_c; } set { cantidad_c = value; } }
        public string Tipo { get { return tipo; } set { tipo = value; } }

        
        public Comida(string marca,double cantidad_c, string tipo, string nombre, decimal precio, string imagen, string descripcion) : base(nombre,precio,imagen,descripcion)
        {
            Marca = marca;
            CantidadComida = cantidad_c;
            Tipo = tipo;
            
        }


    }
}
