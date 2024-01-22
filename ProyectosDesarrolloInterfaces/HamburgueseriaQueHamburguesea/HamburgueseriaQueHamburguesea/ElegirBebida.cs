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
            userControlBebidas.pictureModification.Image = Image.FromFile("D:\\Sergio\\ProyectosDesarrolloInterfaces\\HamburgueseriaQueHamburguesea\\bebida.jpg");
            userControlBebidas.nombre.Text = "Pepe";
           // userControlBebidas.Imagen.Image = Image.FromFile("D:\\Sergio\\ProyectosDesarrolloInterfaces\\HamburgueseriaQueHamburguesea\\bebida");
        }

       
    }
}
