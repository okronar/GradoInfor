using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace InterfazHamburgueseria
{
    internal class Cesta
    {
        private static List<Hamburguesa> Hamburguesas = new List<Hamburguesa>();
        public static void altaHamburguesa(Hamburguesa Ham) {

            Hamburguesas.Add(Ham);
            
        }
        public static String ListadoHamburguesas()
        {
            String lista = "";
            bool esPrimerElemento = true;

            foreach (Hamburguesa ham in Hamburguesas)
            {
                if (!esPrimerElemento)
                {
                    lista += ", ";
                }

                lista += ham.PrintBurguer();
                esPrimerElemento = false;
            }

            return lista;
        }

        public static double PrecioHam()
        {
            double total = 0 ;
            foreach (Hamburguesa ham in Hamburguesas)
            {
                total = total + ham.getPrecio();
            }
            
            return total;

        }


        private static List<Postre> Postres = new List<Postre>();

        public static void altaPostre(Postre Pos)
        {
             Postres.Add(Pos);

        }
       
        public static double PrecioPos()
        {
            double total = 0;
            foreach (Postre ham in Postres)
            {
                total = total + ham.getPrecio();
            }
            return total;

        }
        private static List<Nuggets> Nuggets = new List<Nuggets>();
        public static void altaNugget(Nuggets Nug)
        {
             Nuggets.Add(Nug);

        }
        public static double PrecioNug()
        {
            double total = 0;
            foreach (Nuggets ham in Nuggets)
            {
                total = total + ham.getPrecio();
            }
            return total;

        }

        private static List<Bebidas> Bebidas = new List<Bebidas>();
        public static void altaBebida(Bebidas Beb)
        {
             Bebidas.Add(Beb);

        }

        public static double PrecioBeb()
        {
            double total = 0;
            foreach (Bebidas ham in Bebidas)
            {
                total = total + ham.getPrecio();
            }
            return total;

        }

        private static List<Patatas> Patatas = new List<Patatas>();
        public static void altaPatatas(Patatas Pat)
        {
             Patatas.Add(Pat);

        }
        public static double PrecioPat()
        {
            double total = 0;
            foreach (Patatas ham in Patatas)
            {
                total = total + ham.getPrecio();
            }
            return total;

        }


    }
}
