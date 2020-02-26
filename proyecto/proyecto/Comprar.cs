using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Comprar : Form
    {
        public Comprar()
        {
            InitializeComponent();
        }

        public Comprar(string[] lista,string[] lista1)
        {
            InitializeComponent();
            if(lista.Length == 0 && lista1.Length == 0)
            {
                label6.Text = "Sin productos";
            }
            decimal aux = 0;
            foreach (var i in lista1)
            {
                foreach (var j in Compra.MostrarAnimales())
                {
                    if (i == j.Nombre)
                    {
                        label6.Text = label6.Text + j.ToString() + "\n";
                        aux = aux + j.Precio * j.Cantidad;
                    }
                }
            }
            foreach (var i in lista)
            {
                foreach(var j in Compra.Mostrar())
                {
                    if (i == j.Nombre)
                    {
                        label6.Text = label6.Text + j.ToString() + "\n";
                        aux = aux + j.Precio * j.Cantidad;
                    }
                }
            }
            
            label4.Text = aux.ToString();
        }

        private void Comprar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Comprar_Load(object sender, EventArgs e)
        {

        }
    }
}
