using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Comida : Producto
    {
        string marca;
        double cantidad;
        string descripcion;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

    }
}
