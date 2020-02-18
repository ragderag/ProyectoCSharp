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
    public partial class Peces : Form
    {
        PecesAnimal pecesa = new PecesAnimal();
        PecesComida pecesc = new PecesComida();
        public Peces()
        {
            InitializeComponent();
        }

        private void Peces_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Owner.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pecesa.Show(this);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pecesc.Show(this);
            this.Hide();
        }
    }
}
