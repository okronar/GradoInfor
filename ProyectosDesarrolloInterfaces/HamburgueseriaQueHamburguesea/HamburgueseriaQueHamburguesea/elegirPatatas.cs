﻿using System;
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
        Form2 form2;

        public elegirPatatas(Form2 formitoe)
        {
            InitializeComponent();
            userControl11.pictureModification.Image = Image.FromFile("D:\\Sergio\\ProyectosDesarrolloInterfaces\\HamburgueseriaQueHamburguesea\\patacas.jpg");
            userControl11.nombre.Text = "Bebidas";
            userControl11.botonAnadir.Click += botonAnadir_Click;
            userControl11.botonVolver.Click += botonVolver_Click;
            form2 = formitoe;
                
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
            

        }

        private void botonAnadir_Click(object sender, EventArgs e)
        {

        }



        private void radioSimple_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSimple.Checked)
            {
                userControl11.nombre.Text = "Ración simple";
                userControl11.precio.Text = "5.25 lereles";
            }
            else if (radioDoble.Checked)
            {
                userControl11.nombre.Text = "Ración Doble";
                userControl11.precio.Text = "7.88 Lereles";
            }
        }

   
    }
}
