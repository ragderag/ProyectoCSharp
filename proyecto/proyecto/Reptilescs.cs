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
        Producto c1 = new Producto("Reptile Gammare 250ml 250gr",72.26,"CamRepGam.jpg", "Esta mezcla es una absoluta delicia de gammarus proteínas y otros crustáceos sabrosos para muchas tortugas y otros reptiles carnívoros.");
        Producto c2 = new Producto("Reptile Mixed 250ml 100gr", 78.89, "RepMix.png", "Ya sea agua o el barro tortugas, lagartos, lagartijas, monitores o Tejus: Esta mezcla contiene de forma natural moluscos y crustáceos puros, carne y pescado, y es una fiesta para todos los reptiles carnívoros!");
        


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
                comboBox2.Items.Add(c1.nombre);
                comboBox2.Items.Add(c2.nombre);

                /*
                comboBox2.Items.Add("Comida de camaleon Reptile Mixed 100ml 250gr");
                comboBox2.Items.Add("Comida para Gecko crestado 8 unidades 250gr");
                comboBox2.Items.Add("Comida Day Gecko 8 unidades 250gr");
                comboBox2.Items.Add("Raffy Vital 250");
                comboBox2.Items.Add("Reptile Pellets Omnivore 250ml");
                comboBox2.Items.Add("Iguvert 1L");
                comboBox2.Items.Add("Alimento Iguana Junior 500ml");
                comboBox2.Items.Add("Alimento iguana Adulta 500ml");
                comboBox2.Items.Add("Exo Terra Alimento Drag Adulto 250g");
                comboBox2.Items.Add("Exo Terra Alimento Drag Juvenil 250g");
                comboBox2.Items.Add("Agil 1L");
                comboBox2.Items.Add("Reptil Baby-Gran 100ml");
                comboBox2.Items.Add("Gammarus 90g");
                comboBox2.Items.Add("Raffy Minaral 250ml");
                comboBox2.Items.Add("Raffy Mineral 250ml");
                comboBox2.Items.Add("Trixie 100ml");
                comboBox2.Items.Add("Optimal para Tortugas Terrestres e iguanas 110g");
                comboBox2.Items.Add("Herbil Alimento Vegetal para Tortugas de Tierra 1L");
                */
            }
            else if (comboBox1.SelectedItem.ToString() == "Complementos Alimenticios")
            {
                //MessageBox.Show(comboBox1.SelectedItem.ToString());
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Rep Sepia Bone");
                comboBox2.Items.Add("Energil 1L");
                comboBox2.Items.Add("Calcio para Torgutas 45g");
                comboBox2.Items.Add("Calcil 250ml");
                comboBox2.Items.Add("Taberaqua Ocular Tortugas 20ml");
                comboBox2.Items.Add("Hueso de jibia Natural");

            }
            else if (comboBox1.SelectedItem.ToString() == "Higiene y Limpieza")
            {
                //MessageBox.Show(comboBox1.SelectedItem.ToString());
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Spogi 140mm");
                comboBox2.Items.Add("Exo Terra Limpiacristales 250ml");
                comboBox2.Items.Add("Reptix First Aid 150ml");
                comboBox2.Items.Add("Reptosafe 100ml");
                comboBox2.Items.Add("Reptosafe 250ml");
                comboBox2.Items.Add("gotas para limpieza de tortugas 100gr");
                comboBox2.Items.Add("Set de cepillos de Limpieza 23gr");

            }
            else if (comboBox1.SelectedItem.ToString() == "Iluminacion")
            {
                //MessageBox.Show(comboBox1.SelectedItem.ToString());
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Lampara Bombilla uv Aquazonic 36W");
                comboBox2.Items.Add("Exo Terra sun glo 50w");
                comboBox2.Items.Add("Fluorescente Uvb150");
                comboBox2.Items.Add("Rep Mini Light strip led");
                comboBox2.Items.Add("Rep Brigth Control Pro 70w");
                comboBox2.Items.Add("Reflector Lampara Compact para Reptil");
            }
            else if (comboBox1.SelectedItem.ToString() == "Decoracion")
            {
                //MessageBox.Show(comboBox1.SelectedItem.ToString());
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Planta seda Colgante Terrarios abutilon");
                comboBox2.Items.Add("Planta plastica hiedra del congo");
                comboBox2.Items.Add("Planta pandanus");
                comboBox2.Items.Add("Rama Ramificada 30cm");
                comboBox2.Items.Add("Arbol Flexible para Terrarios jungle tree");
                comboBox2.Items.Add("Exo Terra Cueva chica");
                comboBox2.Items.Add("Exo Terra Cueva grande");


            }
            else if (comboBox1.SelectedItem.ToString() == "Calefaccion")
            {
                //MessageBox.Show(comboBox1.SelectedItem.ToString());
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Roca Calefactora Repticare Standard 1,68kg");
                comboBox2.Items.Add("Termostato 100W 401gr");
                comboBox2.Items.Add("Lampara de Rayos UVA Neo 75W");
                comboBox2.Items.Add("Bombilla de Calentamiento");

            }

            //comboBox1.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == c1.nombre)
            {
                pictureBox1.Image = null;
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.Image = Image.FromFile(c1.imagen);
            }
            else if (comboBox2.SelectedItem.ToString() == c2.nombre)
            {
                pictureBox1.Image = null;
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.Image = Image.FromFile(c2.imagen);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == c1.nombre)
            {
                MessageBox.Show(c1.ToString());
            }
            else if (comboBox2.SelectedItem.ToString() == c2.nombre)
            {
                MessageBox.Show(c2.ToString());
            }
            
        }
    }
}
