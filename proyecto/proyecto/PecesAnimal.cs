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
    public partial class PecesAnimal : Form
    {
        Pez pescado = new Pez();
        public PecesAnimal()
        {
            InitializeComponent();
            comboBox1.Items.Add("Agua Calida");
            comboBox1.Items.Add("Agua Salada");
            comboBox1.Items.Add("Agua Fria");
        }

        private void PecesAnimal_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Agua Calida")
            {
                //comboBox2.SelectedItem.ToString("");
                comboBox2.SelectedItem = null;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Gurami Perla");
                comboBox2.Items.Add("Piraña Roja");
                comboBox2.Items.Add("Cíclido Convicto");
                comboBox2.Items.Add("Coryduras Panadas");
            }
            else if (comboBox1.SelectedItem.ToString() == "Agua Fria")
            {
                comboBox2.SelectedItem = null;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Goldfish");
                comboBox2.Items.Add("Barbo Rosado");
                comboBox2.Items.Add("Carpa Koi");
                comboBox2.Items.Add("Coridora Marmol");
            }
            else if (comboBox1.SelectedItem.ToString() == "Agua Salada")
            {
                comboBox2.SelectedItem = null;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Pez Betta");
                comboBox2.Items.Add("Labeo Bicolor");
                comboBox2.Items.Add("Barbo");
                comboBox2.Items.Add("Rasbora Galaxy");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Gurami Perla")
            {
                pescado.Raza = "Gumari";
                pescado.PesoAnimal = 00.600;
                pescado.Color = "Gris con Naranja";
                pescado.Nombre = comboBox2.Items.ToString();
                pescado.Precio = 200.00;
                pescado.Imagen = "gumari.JPG";
                pescado.Descripcion = "Pez de alta calidad";
                pescado.Alimentacion = "Vegetariano";
                pescado.AlturaAnimal = 0.20;
                var info = pescado.ToString();
                MessageBox.Show(info);
            }
            else if (comboBox2.SelectedItem.ToString() == "Piraña Roja")
            {
                pescado.Raza = "Piraña";
                pescado.PesoAnimal = 1.50;
                pescado.Color = "Gris con Dorado";
                pescado.Nombre = comboBox2.Items.ToString();
                pescado.Precio = 800.00;
                pescado.Imagen = "piraña.JPG";
                pescado.Descripcion = "Pez alto riesgo";
                pescado.Alimentacion = "Carnivoro";
                pescado.AlturaAnimal = 0.30;
                var info = pescado.ToString();
                MessageBox.Show(info);
            }
            else if (comboBox2.SelectedItem.ToString() == "Cíclido Convicto")
            {
                pescado.Raza = "Cíclido";
                pescado.PesoAnimal = 1.20;
                pescado.Color = "Gris";
                pescado.Nombre = comboBox2.Items.ToString();
                pescado.Precio = 500.00;
                pescado.Imagen = "ciclido.JPG";
                pescado.Descripcion = "Pez agresivo";
                pescado.Alimentacion = "Omnívoro";
                pescado.AlturaAnimal = 0.15;
                var info = pescado.ToString();
                MessageBox.Show(info);
            }

        }
    }
}
