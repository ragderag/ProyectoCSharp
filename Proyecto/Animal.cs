using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Animal : Producto
    {
        string raza;
        double peso;
        double altura;
        string color;

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        
    }
}
