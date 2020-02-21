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
    public partial class Aves : Form
    {
        Producto[] Comida = new Producto[16];
        Producto[] Snacks = new Producto[6];
        Producto[] Higiene = new Producto[6];
        Producto[] Jaulas = new Producto[7];
        Producto[] Accesorios = new Producto[7];
        Producto[] Comederos = new Producto[4];
        public Aves()
        {
            InitializeComponent();
            comboBox1.Items.Add("Pajaros");
            comboBox1.Items.Add("Comida");
            comboBox1.Items.Add("Snacks");
            comboBox1.Items.Add("Higiene y Limpieza");
            comboBox1.Items.Add("Jaulas y Pajareras");
            comboBox1.Items.Add("Accesorios");
            comboBox1.Items.Add("Comederos y bebederos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Owner.Show();
        }

        private void Aves_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Pajaros")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("");
                comboBox2.Items.Add("");
                comboBox2.Items.Add("");
                comboBox2.Items.Add("");
                comboBox2.Items.Add("");
                comboBox2.Items.Add("");
                comboBox2.Items.Add("");
            }
            else if (comboBox1.SelectedItem.ToString() == "Comida")
            {
                comboBox2.Items.Clear();
                foreach (var i in Comida)
                {
                    comboBox2.Items.Add(i.nombre);
                }

            }
            else if (comboBox1.SelectedItem.ToString() == "Snacks")
            {
                comboBox2.Items.Clear();
                foreach (var i in Snacks)
                {
                    comboBox2.Items.Add(i.nombre);
                }

            }
            else if (comboBox1.SelectedItem.ToString() == "Higiene y Limpieza")
            {
                comboBox2.Items.Clear();
                foreach (var i in Higiene)
                {
                    comboBox2.Items.Add(i.nombre);
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Jaulas y Pajareras")
            {
                comboBox2.Items.Clear();
                foreach (var i in Jaulas)
                {
                    comboBox2.Items.Add(i.nombre);
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Accesorios")
            {
                comboBox2.Items.Clear();
                foreach (var i in Accesorios)
                {
                    comboBox2.Items.Add(i.nombre);
                }

            }
            else if (comboBox1.SelectedItem.ToString() == "Comederos y bebederos")
            {
                comboBox2.Items.Clear();
                foreach (var i in Comederos)
                {
                    comboBox2.Items.Add(i.nombre);
                }

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Aves_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
