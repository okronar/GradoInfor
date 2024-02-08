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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HamburgueseriaQueHamburguesea
{
    public partial class ElegirHamburguesa : Form
    {
        Form2 form2;
        public ElegirHamburguesa(Form2 formito)
        {
            InitializeComponent();

            userControl11.pictureModification.Image = Image.FromFile("D:\\Sergio\\ProyectosDesarrolloInterfaces\\HamburgueseriaQueHamburguesea\\burguer.jpg");
            //userControl11.pictureModification.Image = Image.FromFile("C:\\Users\\okron\\OneDrive\\Escritorio\\DAMD\\GradoInfor\\ProyectosDesarrolloInterfaces\\HamburgueseriaQueHamburguesea\\burguer.jpg");
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
            int[] extras = { 0, 0, 0, 0 };

            if (radioBurra.Checked)
            {

                Burger bur1 = new Burger(1, 0, extras);
                Form2.Cesta.addItem(bur1);
                MessageBox.Show("Burra añadida chicu");
                Form2.anotaciones += txtboxAnotaciones.Text + " .";
                txtboxAnotaciones.Text = "";


            }
            else if (radioApocalipsis.Checked)
            {

                Burger bur1 = new Burger(1, 2, extras);
                Form2.Cesta.addItem(bur1);
                MessageBox.Show("Apocalipsis añadida chicu");
                Form2.anotaciones += txtboxAnotaciones.Text + " .";
                txtboxAnotaciones.Text = "";

            }
        }



        private void radioBurra_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBurra.Checked)
            {
                userControl11.nombre.Text = "La burra";
                userControl11.precio.Text = "10.5 Lereles";
                lbLabel.Visible = true;
                lbIngredientes.Text = "Pan de pueblo bien aceitado, omega3 de cancun\n Bacon del malo de bellota, Carne de Burro 78% artificial,\n" +
                    "Queso de la cabra de la esquina, lechuga menos que ná,\n Cebolla ";
                
            }
            else if (radioApocalipsis.Checked)
            {
                userControl11.nombre.Text = "La muerte hecha Burguer";
                userControl11.precio.Text = "12.6 Lereles";
                lbLabel.Visible = true;
                lbIngredientes.Text = "Pan de Centeno bien grasoso, trigliceridos de Vallecas\n Bacon del bueno de pata negra, Carne de Vacuno 98% artificial,\n" +
                    "Queso de la vaca de la esquina, lechuga mas bien poca,\n Cebolla sin caramelizar y un poco extracaramelizada";
                


            }


        }

        private void ElegirHamburguesa_FormClosing(object sender, FormClosingEventArgs e)
        {
            form2.Show();
            this.Hide();

        }

    }



}
