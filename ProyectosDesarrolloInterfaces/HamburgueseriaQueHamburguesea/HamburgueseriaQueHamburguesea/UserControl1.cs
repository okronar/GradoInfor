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
    public partial class UserControl1 : UserControl
    {



        public UserControl1()
        {
            InitializeComponent();
            botonVolver.Click += botonVolver_Click;
            botonAnadir.Click += botonAnadir_Click; 

        }

        private void nombre_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {

        }

        private void botonAnadir_Click(object sender, EventArgs e)
        {

        }

        public Button botoncin
        {
            get { return botonVolver; }
            set { botonVolver = botoncin; }
        }


        public PictureBox pictureModification
        {

            get { return Imagen; }
            set { Imagen = pictureModification; }

        }
    }
}
