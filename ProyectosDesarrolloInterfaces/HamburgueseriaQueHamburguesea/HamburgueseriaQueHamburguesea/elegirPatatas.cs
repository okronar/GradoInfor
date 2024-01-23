using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgueseriaQueHamburguesea
{
    public partial class elegirPatatas : Form
    {


        public elegirPatatas(Form2 formitoe)
        {
            InitializeComponent();
            userControl11.pictureModification.Image = Image.FromFile("D:\\Sergio\\ProyectosDesarrolloInterfaces\\HamburgueseriaQueHamburguesea\\patacas.jpg");
            userControl11.nombre.Text = "Bebidas";

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

      
    }
}
