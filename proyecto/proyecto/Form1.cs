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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reptilescs reptilescs = new Reptilescs();
            reptilescs.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aves aves = new Aves();
            aves.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Roedores roedores = new Roedores();
            roedores.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Peces peces = new Peces();
            peces.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gatos gatos = new Gatos();
            gatos.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Perros perros = new Perros();
            perros.Visible = true;
        }
    }
}
