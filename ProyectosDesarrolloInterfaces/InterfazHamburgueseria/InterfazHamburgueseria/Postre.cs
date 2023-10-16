using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazHamburgueseria
{
    internal class Postre
    {
        private double precio;

        public Postre()
        {
            this.precio = 2;
        }

        public double getPrecio() { return precio; }
    }
}
