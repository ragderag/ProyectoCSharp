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
    public partial class QuitarLista : Form
    {
        public QuitarLista()
        {
            InitializeComponent();
        }

        public QuitarLista(String [] lista)
        {
            InitializeComponent();
            foreach (var i in lista)
            {
                foreach (var j in Compra.Mostrar())
                {
                    if (i == j.Nombre)
                    {
                        comboBox1.Items.Add(j.Nombre);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Owner.Show();
        }

        private void QuitarLista_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var j in Compra.Mostrar())
            {
                if (comboBox1.SelectedItem.ToString() == j.Nombre)
                {
                    label4.Text = j.Cantidad.ToString();
                    pictureBox1.ImageLocation = j.Imagen;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Producto aux = null;
            foreach (var j in Compra.Mostrar())
            {
                if (comboBox1.SelectedItem.ToString() == j.Nombre)
                {
                    aux = j;
                }
            }
            Compra.QuitarCantidad(aux,Convert.ToInt32(numericUpDown1.Value));
            label4.Text = "";
            comboBox1.Items.Clear();
            comboBox1.ResetText();
            foreach (var j in Compra.Mostrar())
            {
                comboBox1.Items.Add(j.Nombre);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Producto aux=null;
            foreach (var j in Compra.Mostrar())
            {
                if (comboBox1.SelectedItem.ToString() == j.Nombre)
                {
                    aux = j;
                }
            }
            Compra.QuitarProducto(aux);
            comboBox1.Items.Clear();
            comboBox1.ResetText();
            foreach(var j in Compra.Mostrar())
            {
                comboBox1.Items.Add(j.Nombre);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
