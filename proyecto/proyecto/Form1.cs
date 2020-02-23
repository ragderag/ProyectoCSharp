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
        Reptilescs reptilescs = new Reptilescs();
        Aves aves = new Aves();
        Roedores roedores = new Roedores();
        Peces peces = new Peces();
        Gatos gatos = new Gatos();
        Perros perros = new Perros();
        QuitarLista quitar = new QuitarLista();
        VerLista ver = new VerLista();
        Comprar comp = new Comprar();

        public Form1()
        {
            InitializeComponent();
            Compra.limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reptilescs.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aves.Show(this);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            roedores.Show(this);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            peces.Show(this);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gatos.Show(this);
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            perros.Show(this);
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public Reptilescs Reptilescs { get; set; }
        public Aves Aves { get; set; }
        public Perros Perros { get; set; }
        public Roedores Roedores { get; set; }
        public Gatos Gatos { get; set; }
        public Peces Peces { get; set; }

        public VerLista Ver { get; set; }
        public QuitarLista Quitar { get; set; }

        public Comprar Com { get; set; }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ver.Show(this);
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            quitar.Show(this);
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comp.Show(this);
            Hide();
        }
    }
}
