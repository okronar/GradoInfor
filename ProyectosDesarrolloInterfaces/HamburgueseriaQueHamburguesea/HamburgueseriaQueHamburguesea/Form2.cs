using Hamburger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgueseriaQueHamburguesea
{
    public partial class Form2 : Form
    {

        public  static Pedido Cesta = new Pedido();

        public Form2(Form1 ventana1)
        {

            InitializeComponent();


        }

        private void botonBebida_Click(object sender, EventArgs e)
        {
            ElegirBebida ventanaBebida = new ElegirBebida(this);
            ventanaBebida.Show();
            this.Hide();

        }

        private void botonBurguer_Click(object sender, EventArgs e)
        {
            ElegirHamburguesa ventanaBurguer = new ElegirHamburguesa(this);
            ventanaBurguer.Show();
            this.Hide();

        }

        private void botonPatacas_Click(object sender, EventArgs e)
        {
            elegirPatatas ventanaPatacas = new elegirPatatas(this);
            ventanaPatacas.Show();
            this.Hide();
        }

        private void botonCesta_Click(object sender, EventArgs e)
        {
            CestaForm formcesta = new CestaForm(this);
            formcesta.Show();
            this.Hide();

        }

      
    }
}
