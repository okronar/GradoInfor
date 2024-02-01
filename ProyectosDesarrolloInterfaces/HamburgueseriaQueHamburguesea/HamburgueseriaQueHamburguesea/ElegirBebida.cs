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
    public partial class ElegirBebida : Form
    {
        Form2 form2;

        public ElegirBebida(Form2 formito)
        {



            InitializeComponent();
            userControl11.pictureModification.Image = Image.FromFile("D:\\Sergio\\ProyectosDesarrolloInterfaces\\HamburgueseriaQueHamburguesea\\bebida.jpg");
            userControl11.nombre.Text = "Bebidas";
            form2 = formito;

            userControl11.botonAnadir.Click += botonAnadir_Click;
            userControl11.botonVolver.Click += botonVolver_Click;
           

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();


        }

        private void botonAnadir_Click(object sender, EventArgs e)
        {

        }

        private void radioNestea_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAgua.Checked)
            {
                userControl11.nombre.Text = "Agüita";
                userControl11.precio.Text = "1.8 Lereles";
                lbLabel.Visible = true;
                lbIngredientes.Text = "Pues esto es agua";
            }
            else if (radioNestea.Checked)
            {
                userControl11.nombre.Text = "Nestea";
                userControl11.precio.Text = "2.8 Lereles";
                lbLabel.Visible = true;
                lbIngredientes.Text = "Pues esto es Nestea, te y Nes";
            }
            else if (radioCoca.Checked)
            {
                userControl11.nombre.Text = "Coca cola";
                userControl11.precio.Text = "2.3 Lereles";
                lbLabel.Visible = true;
                lbIngredientes.Text = "Pues esto es Coca-Cola si te cuento lo que lleva igual te matan";
            }
            else {
                userControl11.nombre.Text = "Bebida";
                userControl11.precio.Text = "Dineros";
                lbLabel.Visible = true;
                lbIngredientes.Text = "Pues esto es nada, el vacío";

            }

        }
    }
}
