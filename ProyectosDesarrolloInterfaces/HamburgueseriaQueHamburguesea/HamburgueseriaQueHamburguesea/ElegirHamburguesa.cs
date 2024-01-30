using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HamburgueseriaQueHamburguesea
{
    public partial class ElegirHamburguesa : Form
    {
        public ElegirHamburguesa(Form2 formito)
        {
            InitializeComponent();

            userControl11.pictureModification.Image = Image.FromFile("D:\\Sergio\\ProyectosDesarrolloInterfaces\\HamburgueseriaQueHamburguesea\\burguer.jpg");
            userControl11.nombre.Text = "Bebidas";

        }

        private void radioBurra_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBurra.Checked)
            {
                userControl11.nombre.Text = "La burra";
                userControl11.precio.Text = "10.5 Lereles";
            }
            else if (radioApocalipsis.Checked)
            {
                userControl11.nombre.Text = "La muerte hecha Burguer";
                userControl11.precio.Text = "12.6 Lereles";
            }


        }
    }


   
}
