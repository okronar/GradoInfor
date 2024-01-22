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
           
            
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

    }
}
