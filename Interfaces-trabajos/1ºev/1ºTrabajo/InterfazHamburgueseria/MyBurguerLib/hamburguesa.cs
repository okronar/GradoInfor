using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBurguerLib
{
    public class Hamburguesa
    {

        private int codigo;
        private double precio;
        private String ingredientes;
        public Hamburguesa(int codigo)
        {
            this.codigo = codigo;
            setPrecio(codigo);
            setIngredientes(codigo);

        }
        //simplemente dependiendo el parametro que se le pase asocia a la instancia los valores
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
                case 3:
                    this.precio = 2.5;
                    break;
                case 4:
                    this.precio = 4.7;
                    break;
                default: this.precio = 0; break;

            }
        }
        //lo mismo que el anterior
        public void setIngredientes(int codigo)
        {

            switch (codigo)
            {
                case 1:
                    this.ingredientes = "Simple : lechuga,carne";
                    break;
                case 2:
                    this.ingredientes = "Completa :lechuga,carne,queso y huevo";
                    break;
                case 3:
                    this.ingredientes = "Bacon : lechuga,carne,bacon";
                    break;
                case 4:
                    this.ingredientes = "Muerte : lechuga,carne,bacon,huevo,pate de pato foie";
                    break;
                default:
                    this.ingredientes = "no hay hamburguesa para pobres";
                    break;

            }
        }

        public double getPrecio() { return precio; }


        //esto te printea los ingredientes
        public String PrintBurguer() {
            return this.ingredientes;
        }

        //printea precio
        public void showPrecio(int codigo)
        {
            Console.WriteLine(this.precio);
        }
        //esto es para pruebas
        public void showIngredientes(int codigo)
        {
            Console.WriteLine(this.ingredientes);
        }
    }
}
