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
    public partial class VerLista : Form
    {
        public VerLista()
        {
            InitializeComponent();
            
        }

        public VerLista(string cadena)
        {
            InitializeComponent();
            
            label3.Text = cadena;
            label3.Size = new Size(label3.PreferredWidth, label3.PreferredHeight);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            this.Owner.Show();
        }

        private void VerLista_Load(object sender, EventArgs e)
        {
           
        }

        private void VerLista_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
