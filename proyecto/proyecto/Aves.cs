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
        List<string[]> lista = Csv.LeeCSV(@"basedatos\petShopAve.csv");
        public Aves()
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
            try
            {
                IEnumerable<string> query =
                from array in lista
                where array.Contains(comboBox1.SelectedItem.ToString()) && array.Contains(comboBox2.SelectedItem.ToString())
                select array[4];
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            label3.Visible = false;
            label6.Text = "$0";
            numericUpDown2.Value = 1;
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

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
            label4.Visible = true;
            label6.Text = "$0.0";
            numericUpDown2.Value = 1;
            label3.Visible = true;
            IEnumerable<string> query =
                from array in lista
                where array.Contains(comboBox1.SelectedItem.ToString()) && array.Contains(comboBox2.SelectedItem.ToString())
                select array[2];

            foreach (var item in query)
            {
                label4.Text = "$" + item;
            }
            label6.Text = "$" + Convert.ToString(numericUpDown2.Value * Convert.ToDecimal(label4.Text.Remove(0, 1)));

            IEnumerable<string> query2 =
                from array in lista
                where array.Contains(comboBox1.SelectedItem.ToString()) && array.Contains(comboBox2.SelectedItem.ToString())
                select array[3];
            foreach (var item in query2)
            {
                pictureBox1.ImageLocation = item;
            }
        }

        private void Aves_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IEnumerable<string> query =
                from array in lista
                where array.Contains(comboBox1.SelectedItem.ToString()) && array.Contains(comboBox2.SelectedItem.ToString())
                select array[4];
            Producto aux = new Producto(comboBox2.Text, Convert.ToDecimal(label4.Text.Remove(0, 1)), pictureBox1.ImageLocation, query.ToArray()[0], numericUpDown2.Value);

            Compra.AgregarProducto(aux);
            var resultado = Compra.Mostrar();
            foreach (var i in resultado)
                MessageBox.Show(i.ToString() + "\nCantidad: " + i.Cantidad.ToString());
        }
    }
}
