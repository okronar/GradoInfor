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


        public ElegirBebida(Form2 formito)
        {



            InitializeComponent();
            userControl11.pictureModification.Image = Image.FromFile("D:\\Sergio\\ProyectosDesarrolloInterfaces\\HamburgueseriaQueHamburguesea\\bebida.jpg");
            userControl11.nombre.Text = "Bebidas";


           

            // userControlBebidas.Imagen.Image = Image.FromFile("D:\\Sergio\\ProyectosDesarrolloInterfaces\\HamburgueseriaQueHamburguesea\\bebida");
        }

        private void radioNestea_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAgua.Checked)
            {
                userControl11.nombre.Text = "Agüita";
                userControl11.precio.Text = "1.8 Lereles";
            }
            else if (radioNestea.Checked)
            {
                userControl11.nombre.Text = "Nestea";
                userControl11.precio.Text = "2.8 Lereles";
            }
            else if (radioCoca.Checked)
            {
                userControl11.nombre.Text = "Coca cola";
                userControl11.precio.Text = "2.3 Lereles";
            }
            else {
                userControl11.nombre.Text = "Bebida";
                userControl11.precio.Text = "Dineros";

            }

        }
    }
}
