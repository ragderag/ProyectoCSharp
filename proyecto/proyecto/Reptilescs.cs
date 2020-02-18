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
    public partial class Reptilescs : Form
    {
        Producto[] comida=new Producto[16];
        Producto[] Comple = new Producto[6];
        Producto[] higiene = new Producto[7];
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
            string file = "basedatos\\comida.txt";
            try
            {
                int i = 0;
                FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);
                while (reader.Peek() > -1) 
                {
                    string cad=reader.ReadLine();
                    comida[i] = new Producto(cad.Split('@')[0], Convert.ToDecimal(cad.Split('@')[1]), cad.Split('@')[2], cad.Split('@')[3]);
                    i++;
                } 
                reader.Close();
            }
            catch (SystemException e) { MessageBox.Show(e.ToString()); }

            string file1 = "basedatos\\Complementos.txt";
            try
            {
                int i = 0;
                FileStream stream = new FileStream(file1, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);
                while (reader.Peek() > -1)
                {
                    string cad = reader.ReadLine();
                    Comple[i] = new Producto(cad.Split('@')[0], Convert.ToDecimal(cad.Split('@')[1]), cad.Split('@')[2], cad.Split('@')[3]);
                    i++;
                }
                reader.Close();
            }
            catch (SystemException e) { MessageBox.Show(e.ToString()); }

            string file2 = "basedatos\\higiene.txt";
            try
            {
                int i = 0;
                FileStream stream = new FileStream(file2, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);
                while (reader.Peek() > -1)
                {
                    string cad = reader.ReadLine();
                    higiene[i] = new Producto(cad.Split('@')[0], Convert.ToDecimal(cad.Split('@')[1]), cad.Split('@')[2], cad.Split('@')[3]);
                    i++;
                }
                reader.Close();
            }
            catch (SystemException e) { MessageBox.Show(e.ToString()); }

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
                comboBox2.Items.Clear();
                foreach (var i in comida) 
                {
                    comboBox2.Items.Add(i.nombre);
                }
                
            }
            else if (comboBox1.SelectedItem.ToString() == "Complementos Alimenticios")
            {
                comboBox2.Items.Clear();
                foreach (var i in Comple)
                {
                    comboBox2.Items.Add(i.nombre);
                }

            }
            else if (comboBox1.SelectedItem.ToString() == "Higiene y Limpieza")
            {
                comboBox2.Items.Clear();
                foreach (var i in higiene)
                {
                    comboBox2.Items.Add(i.nombre);
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Iluminacion")
            {
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
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Roca Calefactora Repticare Standard 1,68kg");
                comboBox2.Items.Add("Termostato 100W 401gr");
                comboBox2.Items.Add("Lampara de Rayos UVA Neo 75W");
                comboBox2.Items.Add("Bombilla de Calentamiento");

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Reptiles")
            {
                
            }
            else if (comboBox1.SelectedItem.ToString() == "Comida")
            {
                foreach (var i in comida)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        pictureBox1.Image = null;
                        pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                        pictureBox1.Image = Image.FromFile(i.imagen);
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Complementos Alimenticios")
            {
                foreach (var i in Comple)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        pictureBox1.Image = null;
                        pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                        pictureBox1.Image = Image.FromFile(i.imagen);
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Higiene y Limpieza")
            {
                foreach (var i in higiene)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        pictureBox1.Image = null;
                        pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                        pictureBox1.Image = Image.FromFile(i.imagen);
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Iluminacion")
            {
                
            }
            else if (comboBox1.SelectedItem.ToString() == "Decoracion")
            {
                
            }
            else if (comboBox1.SelectedItem.ToString() == "Calefaccion")
            {
                
            }
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Reptiles")
            {

            }
            else if (comboBox1.SelectedItem.ToString() == "Comida")
            {
                foreach (var i in comida)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        MessageBox.Show(i.ToString());
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Complementos Alimenticios")
            {
                foreach (var i in Comple)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        MessageBox.Show(i.ToString());
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Higiene y Limpieza")
            {
                foreach (var i in higiene)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        MessageBox.Show(i.ToString());
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Iluminacion")
            {

            }
            else if (comboBox1.SelectedItem.ToString() == "Decoracion")
            {

            }
            else if (comboBox1.SelectedItem.ToString() == "Calefaccion")
            {

            }
            
            
        }
    }
}
