using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            
            label4.Text = "$"+aux.ToString();
            string path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.Length - 18);
            path = path + "Historial";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string path_file = path + "\\" + "reg_compras.txt";
            if (!File.Exists(path_file))
            {
                using (File.Create(path_file)) { }
            }
            StreamWriter registros;
            registros = File.AppendText(path_file);
            registros.WriteLine("---------------------------------------------------------");
            registros.WriteLine(label6.Text);
            registros.WriteLine("Total" + label4.Text);
            registros.Close();
        }

        private void Comprar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Comprar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compra.limpiar();
            this.Visible = false;
            this.Owner.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
