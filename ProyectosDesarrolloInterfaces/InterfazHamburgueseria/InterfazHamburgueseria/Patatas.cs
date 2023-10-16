using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazHamburgueseria
{
    internal class Patatas
    {
        private double precio;
        private int tamaño;
        public Patatas(int tamaño)
        {

            this.tamaño = tamaño;
            setPrecio(tamaño);

        }



        void setPrecio(int tamaño)
        {
            switch (tamaño)
            {
                case 1:
                    this.precio = 1;
                    break;
                case 2:
                    this.precio = 2;
                    break;

                default: this.precio = 0; break;

            }

        }
        public double getPrecio() { return precio; }
    }
}
