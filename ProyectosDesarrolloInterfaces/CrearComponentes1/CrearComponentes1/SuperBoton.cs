using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearComponentes1
{
    public partial class SuperBoton : Button
    {
        //1.Atributos para redimensionar 
        private bool redimensionar = true;

        //getter setter 
        private bool Redimensionar {

            get { return redimensionar; }

            set { redimensionar = value; }
        }
       protected override void OnMouseEnter(EventArgs e) { 
            if(redimensionar)
            {
                //autoreferencia a supropio tamaño
                this.Size = new System.Drawing.Size(150, 150);
            }
            base.OnMouseEnter(e);
        
        }



        //public Component1()
        //{
        //    InitializeComponent();
        //}

        //public Component1(IContainer container)
        //{
        //    container.Add(this);

        //    InitializeComponent();
        //}
    }
}
