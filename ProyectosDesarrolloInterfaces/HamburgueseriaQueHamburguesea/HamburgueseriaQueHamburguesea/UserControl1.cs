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
    public partial class UserControl1 : UserControl
    {

        public static PictureBox img;

        public UserControl1()
        {
            InitializeComponent();
            img = this.Imagen;
        }

        private void nombre_Click(object sender, EventArgs e)
        {
            
        }
    }
}
