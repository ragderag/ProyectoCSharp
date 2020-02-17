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
    public partial class Reptilescs : Form
    {
        public Reptilescs()
        {
            InitializeComponent();
            comboBox1.Items.Add("Reptiles");
            comboBox1.Items.Add("Comida");
            comboBox1.Items.Add("Complementos Alimenticios");
            comboBox1.Items.Add("Higiene y Limpieza");
            comboBox1.Items.Add("Iluminacion");
            comboBox1.Items.Add("Decoracion");
            comboBox1.Items.Add("Calefaccion");
            comboBox1.Items.Add("Humedad");
            comboBox1.Items.Add("Incubadoras");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Owner.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Reptiles")
            {
                //MessageBox.Show(comboBox1.SelectedItem.ToString());
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Camaleones");
                comboBox2.Items.Add("Geckos");
                comboBox2.Items.Add("Iguanas");
                comboBox2.Items.Add("Lagartos");
                comboBox2.Items.Add("Pogonas");
                comboBox2.Items.Add("Tortugas de Agua");
                comboBox2.Items.Add("Tortugas de Tierra");
            }
            else if (comboBox1.SelectedItem.ToString() == "Comida")
            {
                //MessageBox.Show(comboBox1.SelectedItem.ToString());
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Comida de camaleon Reptile Gammare 250ml 250gr");
                comboBox2.Items.Add("Comida de camaleon Reptile Mixed 250ml 100gr");
                comboBox2.Items.Add("Comida de camaleon Reptile Mixed 100ml 250gr");
            }
            else if (comboBox1.SelectedItem.ToString() == "Complementos Alimenticios")
            {
                //MessageBox.Show(comboBox1.SelectedItem.ToString());
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Cal");
                comboBox2.Items.Add("Hum");
                comboBox2.Items.Add("Inc");
            }
            else if (comboBox1.SelectedItem.ToString() == "Higiene y Limpieza")
            {
                //MessageBox.Show(comboBox1.SelectedItem.ToString());
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Cale");
                comboBox2.Items.Add("Hume");
                comboBox2.Items.Add("Incu");
            }
            else if (comboBox1.SelectedItem.ToString() == "Iluminacion")
            {
                //MessageBox.Show(comboBox1.SelectedItem.ToString());
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Calef");
                comboBox2.Items.Add("Humed");
                comboBox2.Items.Add("Incub");
            }
            else if (comboBox1.SelectedItem.ToString() == "Decoracion")
            {
                //MessageBox.Show(comboBox1.SelectedItem.ToString());
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Calefa");
                comboBox2.Items.Add("Humeda");
                comboBox2.Items.Add("Incuba");
            }
            else if (comboBox1.SelectedItem.ToString() == "Calefaccion")
            {
                //MessageBox.Show(comboBox1.SelectedItem.ToString());
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Calefac");
                comboBox2.Items.Add("Humedad");
                comboBox2.Items.Add("Incubad");
            }
            else if (comboBox1.SelectedItem.ToString() == "Humedad")
            {
                //MessageBox.Show(comboBox1.SelectedItem.ToString());
                comboBox2.Items.Clear();
                comboBox2.Items.Add("on");
                comboBox2.Items.Add("ad");
                comboBox2.Items.Add("as");
            }
            else if (comboBox1.SelectedItem.ToString() == "Incubadoras")
            {
                //MessageBox.Show(comboBox1.SelectedItem.ToString());
                comboBox2.Items.Clear();
                comboBox2.Items.Add("n");
                comboBox2.Items.Add("d");
                comboBox2.Items.Add("s");
            }
            //comboBox1.SelectedItem.ToString();
        }
    }
}
