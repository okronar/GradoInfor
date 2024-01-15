using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using InterfazHamburgueseria;

namespace InterfazHamburgueseria
{    //CLASE GESTOR lleva todas las clases y sus printeos etc
    internal class Cesta
    {   //creas una lista de hamburguesas
        private static List<Hamburguesa> Hamburguesas = new List<Hamburguesa>();

            //para printear hamburguesas tienes la lista o coger una hamburgesa y llamar al metodo propio

            //y le vas añadiendo productos cuando lo llames
        public static void altaHamburguesa(Hamburguesa Ham) {

            Hamburguesas.Add(Ham);
            
        }
        //esto para printear hamburguesas y sus ingredientes
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
        //sacar los precios de todas las burguers cangreburguers
        public static double PrecioHam()
        {
            double total = 0 ;
            foreach (Hamburguesa ham in Hamburguesas)
            {
                total = total + ham.getPrecio();
            }
            
            return total;

        }

        //otra lista para postres
        private static List<Postre> Postres = new List<Postre>();

        //dar de alta
        public static void altaPostre(Postre Pos)
        {
             Postres.Add(Pos);

        }
       //y sacar precios
        public static double PrecioPos()
        {
            double total = 0;
            foreach (Postre ham in Postres)
            {
                total = total + ham.getPrecio();
            }
            return total;

        }
        //lo mismo nuggets
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
        //lo mismo bebidas pero en las bebidas se elige entre grande y pequeña despues en el main
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
        //lo mismo en patatas , se elige en el main
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
