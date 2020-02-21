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
        List<string[]> lista = Csv.LeeCSV(@"basedatos\petShop.csv");
        List<Producto> Comida = new List<Producto>();
        List<Producto> Complementos = new List<Producto>();
        List<Producto> Higiene = new List<Producto>();
        List<Producto> Iluminacion = new List<Producto>();
        List<Producto> Decoracion = new List<Producto>();
        List<Producto> Cale = new List<Producto>();
        public Reptilescs()
        {
            InitializeComponent();

            label4.Visible = false;
            label3.Visible = false;
            IEnumerable<string> query =
                (from array in lista
                 select array[0]).Distinct();

            foreach (var item in query)
            {
                comboBox1.Items.Add(item);
            }

            /*
            comboBox1.Items.Add("Reptiles");
            comboBox1.Items.Add("Comida");
            comboBox1.Items.Add("Complementos Alimenticios");
            comboBox1.Items.Add("Higiene y Limpieza");
            comboBox1.Items.Add("Iluminacion");
            comboBox1.Items.Add("Decoracion");
            comboBox1.Items.Add("Calefaccion");
            */
            /*
            foreach (var i in lista)
            {
                if (i[0] == "comida")
                {
                    Producto aux = new Producto(i[1], Convert.ToDecimal(i[2]), i[3], i[5]);
                    Comida.Add(aux);
                }
                else if (i[0] == "Complementos") 
                {
                    Producto aux = new Producto(i[1], Convert.ToDecimal(i[2]), i[3], i[5]);
                    Complementos.Add(aux);
                }
                else if (i[0] == "higiene")
                {
                    Producto aux = new Producto(i[1], Convert.ToDecimal(i[2]), i[3], i[5]);
                    Higiene.Add(aux);
                }
                else if (i[0] == "iluminacion")
                {
                    Producto aux = new Producto(i[1], Convert.ToDecimal(i[2]), i[3], i[5]);
                    Iluminacion.Add(aux);
                }
                else if (i[0] == "Decoracion")
                {
                    Producto aux = new Producto(i[1], Convert.ToDecimal(i[2]), i[3], i[5]);
                    Decoracion.Add(aux);
                }
                else if (i[0] == "cale")
                {
                    Producto aux = new Producto(i[1], Convert.ToDecimal(i[2]), i[3], i[5]);
                    Cale.Add(aux);
                }
            
            }    
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Owner.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IEnumerable<string> query =
                from array in lista
                where array.Contains(comboBox1.SelectedItem.ToString()) && array.Contains(comboBox2.SelectedItem.ToString())
                select array[5];
            Producto aux = new Producto(comboBox2.ToString(), Convert.ToDecimal(label4.Text.Remove(0,1)), pictureBox1.ImageLocation, query.ToArray()[0]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            label3.Visible = false;
            label6.Text = "$0";
            numericUpDown1.Value = 1;
            IEnumerable<string> query =
                (from array in lista
                 where array.Contains(comboBox1.SelectedItem.ToString())
                 select array[1]).Distinct();
            comboBox2.Items.Clear();
            comboBox2.ResetText();

            foreach (var item in query)
            {
                comboBox2.Items.Add(item);
            }
            button2.Visible = false;
            /*

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
                foreach (var i in Comida)
                {
                    comboBox2.Items.Add(i.nombre);
                }

            }
            else if (comboBox1.SelectedItem.ToString() == "Complementos Alimenticios")
            {
                comboBox2.Items.Clear();
                foreach (var i in Complementos)
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
            else if (comboBox1.SelectedItem.ToString() == "Iluminacion")
            {
                comboBox2.Items.Clear();
                foreach (var i in Iluminacion)
                {
                    comboBox2.Items.Add(i.nombre);
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Decoracion")
            {
                comboBox2.Items.Clear();
                foreach (var i in Decoracion)
                {
                    comboBox2.Items.Add(i.nombre);
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Calefaccion")
            {
                comboBox2.Items.Clear();
                foreach (var i in Cale)
                {
                    comboBox2.Items.Add(i.nombre);
                }
            }
            */
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
            label4.Visible = true;
            label6.Text = "$0.0";
            numericUpDown1.Value = 1;
            label3.Visible = true;
            IEnumerable<string> query =
                from array in lista
                where array.Contains(comboBox1.SelectedItem.ToString()) && array.Contains(comboBox2.SelectedItem.ToString())
                select array[2];

            foreach (var item in query)
            {
                label4.Text = "$" + item;
            }
            label6.Text = "$" + Convert.ToString(numericUpDown1.Value * Convert.ToDecimal(label4.Text.Remove(0, 1)));

            IEnumerable<string> query2 =
                from array in lista
                where array.Contains(comboBox1.SelectedItem.ToString()) && array.Contains(comboBox2.SelectedItem.ToString())
                select array[3];
            foreach (var item in query2)
            {
                pictureBox1.ImageLocation = item;
            }

            /*if (comboBox1.SelectedItem.ToString() == "Reptiles")
            {

            }
            else if (comboBox1.SelectedItem.ToString() == "Comida")
            {
                foreach (var i in Comida)
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
                foreach (var i in Complementos)
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
                foreach (var i in Higiene)
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
                foreach (var i in Iluminacion)
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
                foreach (var i in Decoracion)
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
                foreach (var i in Cale)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        pictureBox1.Image = null;
                        pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                        pictureBox1.Image = Image.FromFile(i.imagen);
                    }
                }
            }
            */

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<string> query =
                from array in lista
                where array.Contains(comboBox1.SelectedItem.ToString()) && array.Contains(comboBox2.SelectedItem.ToString())
                select array[5];
                if (query.ToArray().Length > 0)
                {
                    foreach (var item in query)
                    {
                        MessageBox.Show(item);
                    }
                }

            }
            catch (Exception)
            {
            }

            /*
            if (comboBox1.SelectedItem.ToString() == "Reptiles")
            {

            }
            else if (comboBox1.SelectedItem.ToString() == "Comida")
            {
                foreach (var i in Comida)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        MessageBox.Show(i.ToString());
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Complementos Alimenticios")
            {
                foreach (var i in Complementos)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        MessageBox.Show(i.ToString());
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Higiene y Limpieza")
            {
                foreach (var i in Higiene)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        MessageBox.Show(i.ToString());
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Iluminacion")
            {
                foreach (var i in Iluminacion)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        MessageBox.Show(i.ToString());
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Decoracion")
            {
                foreach (var i in Decoracion)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        MessageBox.Show(i.ToString());
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Calefaccion")
            {
                foreach (var i in Cale)
                {
                    if (comboBox2.SelectedItem.ToString() == i.nombre)
                    {
                        MessageBox.Show(i.ToString());
                    }
                }
            }
            */
        }

        private void Reptilescs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = "$" + Convert.ToString(numericUpDown1.Value * Convert.ToDecimal(label4.Text.Remove(0,1)));
        }
    }
}
