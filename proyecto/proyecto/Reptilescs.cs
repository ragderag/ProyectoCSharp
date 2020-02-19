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
        Producto[] iluminacion = new Producto[6];
        Producto[] decoracion = new Producto[7];
        Producto[] cale = new Producto[4];

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

            string file3 = "basedatos\\iluminacion.txt";
            try
            {
                int i = 0;
                FileStream stream = new FileStream(file3, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);
                while (reader.Peek() > -1)
                {
                    string cad = reader.ReadLine();
                    iluminacion[i] = new Producto(cad.Split('@')[0], Convert.ToDecimal(cad.Split('@')[1]), cad.Split('@')[2], cad.Split('@')[3]);
                    i++;
                }
                reader.Close();
            }
            catch (SystemException e) { MessageBox.Show(e.ToString()); }

            string file4 = "basedatos\\Decoracion.txt";
            try
            {
                int i = 0;
                FileStream stream = new FileStream(file4, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);
                while (reader.Peek() > -1)
                {
                    string cad = reader.ReadLine();
                    decoracion[i] = new Producto(cad.Split('@')[0], Convert.ToDecimal(cad.Split('@')[1]), cad.Split('@')[2], cad.Split('@')[3]);
                    i++;
                }
                reader.Close();
            }
            catch (SystemException e) { MessageBox.Show(e.ToString()); }

            string file5 = "basedatos\\Cale.txt";
            try
            {
                int i = 0;
                FileStream stream = new FileStream(file5, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);
                while (reader.Peek() > -1)
                {
                    string cad = reader.ReadLine();
                    cale[i] = new Producto(cad.Split('@')[0], Convert.ToDecimal(cad.Split('@')[1]), cad.Split('@')[2], cad.Split('@')[3]);
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
                foreach (var i in iluminacion)
                {
                    comboBox2.Items.Add(i.nombre);
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Decoracion")
            {
                comboBox2.Items.Clear();
                foreach (var i in decoracion)
                {
                    comboBox2.Items.Add(i.nombre);
                }

            }
            else if (comboBox1.SelectedItem.ToString() == "Calefaccion")
            {
                comboBox2.Items.Clear();
                foreach (var i in cale)
                {
                    comboBox2.Items.Add(i.nombre);
                }

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
                foreach (var i in iluminacion)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        pictureBox1.Image = null;
                        pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                        pictureBox1.Image = Image.FromFile(i.imagen);
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Decoracion")
            {
                foreach (var i in decoracion)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        pictureBox1.Image = null;
                        pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                        pictureBox1.Image = Image.FromFile(i.imagen);
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Calefaccion")
            {
                foreach (var i in cale)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        pictureBox1.Image = null;
                        pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                        pictureBox1.Image = Image.FromFile(i.imagen);
                    }
                }
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
                foreach (var i in iluminacion)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        MessageBox.Show(i.ToString());
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Decoracion")
            {
                foreach (var i in decoracion)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        MessageBox.Show(i.ToString());
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Calefaccion")
            {
                foreach (var i in cale)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        MessageBox.Show(i.ToString());
                    }
                }
            }
            
            
        }
    }
}
