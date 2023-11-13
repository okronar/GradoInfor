using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBurguerLib
{
    public class Bebidas
    {
        private double precio;
        private int tamanno;


        public Bebidas(int tamanno)
        {

            this.tamanno = tamanno;
            setPrecio(tamanno);

        }


        public void setPrecio(int codigo)
        {
            switch (codigo)
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
