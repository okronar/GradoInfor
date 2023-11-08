﻿
using InterfazHamburgueseria;


internal class Program
{
    private static void Main(string[] args)
    {

        Console.OutputEncoding = System.Text.Encoding.Unicode;
        string linea;
        int numero;
        //empieza la fiesta, un bucle con switch para ir añadiendo cosas a la cesta
        do 
        {   Console.WriteLine("Bienvenido que hamburguesa desea ?");
            // Console.WriteLine("1.Hamburguesa 2.Bebida  3.Patatas 4. Nuggets 5.Postre 0.salir");
            Console.WriteLine("╭────────────────────────────╮");
            Console.WriteLine("│   ¡Bienvenido al Menú!     │");
            Console.WriteLine("├────────────────────────────┤");
            Console.WriteLine("│ 1. 🍔 Hamburguesa          │");
            Console.WriteLine("│ 2. 🥤 Bebida               │");
            Console.WriteLine("│ 3. 🍟 Patatas              │");
            Console.WriteLine("│ 4. 🍗 Nuggets              │");
            Console.WriteLine("│ 5. 🍰 Postre               │");
            Console.WriteLine("│ 0. 🚪 Salir                │");
            Console.WriteLine("╰────────────────────────────╯");

            linea = Console.ReadLine(); numero = int.Parse(linea);
            switch (numero)
            {

                case 1:
                    //metodo para elegir y añadir burguer
                    Elegiburguer(linea); 
                    break;

                case 2:
                    //metodo para elegir y añadir bebida
                    ElegirBebida(linea); 
                    break;

                case 3:
                    //metodo para elegir y añadir patatas
                    ElegirPatatas(linea);
                    break;

                case 4://directo 
                    Console.WriteLine("nuggets añadidos");
                    Nuggets nug = new Nuggets();
                    Cesta.altaNugget(nug as Nuggets);
                    break;
                case 5://directo 

                    Console.WriteLine("postre añadido");
                    Postre pos = new Postre();
                    Cesta.altaPostre(pos as Postre);
                    break;

                case 0://se acaba el pedido y se printea las hamburguesas con sus ingredientes y el precio de todo el conjunto
                    double total = Cesta.PrecioHam() + Cesta.PrecioBeb() + Cesta.PrecioPos() + Cesta.PrecioPat() + Cesta.PrecioNug();
                    Console.WriteLine("gracias por su visita, hasta luego");
                    Console.WriteLine("su pedido consiste en " + Cesta.ListadoHamburguesas() + 
                        " y su precio es de : " + total + "€");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        } while (numero!=0);

    }

    private static void ElegirBebida(string linea)
    {
        Console.WriteLine("Bebida grande o pequeña");
        Console.WriteLine("Grande 1. o pequeña 2.");
        String linea2 = Console.ReadLine(); int numero2 = int.Parse(linea2);

        switch (numero2)
        {

            case 1:
                Bebidas beb1 = new Bebidas(numero2);
                Console.WriteLine("añadida la bebida grande");
                Cesta.altaBebida(beb1 as Bebidas);
                break;
            case 2:
                Bebidas beb2 = new Bebidas(numero2);
                Console.WriteLine("añadida la bebida pequeña");
                Cesta.altaBebida(beb2 as Bebidas);
                break;
        }
    }
    private static void ElegirPatatas(string linea)
    {
        Console.WriteLine("Patatas grande o pequeña");
        Console.WriteLine("Grande 1. o pequeña 2.");
        String linea2 = Console.ReadLine(); int numero2 = int.Parse(linea2);

        switch (numero2)
        {

            case 1:
                Patatas beb1 = new Patatas(numero2);
                Console.WriteLine("añadida la PAPA grande");
                Cesta.altaPatatas(beb1 as Patatas);
                break;
            case 2:
                Patatas beb12 = new Patatas(numero2);
                Console.WriteLine("añadida la PAPA pequeña");
                Cesta.altaPatatas(beb12 as Patatas);
                break;
                
        }
    }

    private static void Elegiburguer(string linea)
    {
        Console.WriteLine("elija su hamburguesa");
        Console.WriteLine("╭───────────────────────────────────────────╮");
        Console.WriteLine("│           Menú de Hamburguesas            │");
        Console.WriteLine("├───────────────────────────────────────────┤");
        Console.WriteLine("│ 1. Hamburguesa simple                     │");
        Console.WriteLine("│ 2. Hamburguesa completa                   │");
        Console.WriteLine("│ 3. Bacon                                  │");
        Console.WriteLine("│ 4. Muerte                                 │");
        Console.WriteLine("│ 5. Cancelar                               │");
        Console.WriteLine("╰───────────────────────────────────────────╯");

        // Console.WriteLine("1.Hamburguesa simple 2.Hamburguesa completa  3.Bacon 4. Muerte 5.cancelar");
        String linea2 = Console.ReadLine(); int numero2 = int.Parse(linea2);
        switch (numero2)
        {
            case 1:
                Hamburguesa hambur1 = new Hamburguesa(numero2);
                Console.WriteLine("Añadida la hamburguesa 1");
                Cesta.altaHamburguesa(hambur1 as Hamburguesa);

                break;
            case 2:
                Hamburguesa hambur2 = new Hamburguesa(numero2);
                Console.WriteLine("Añadida la hamburguesa 2");
                Cesta.altaHamburguesa(hambur2 as Hamburguesa);

                break;
            case 3:
                Hamburguesa hambur3 = new Hamburguesa(numero2);
                Console.WriteLine("Añadida la hamburguesa 3");
                Cesta.altaHamburguesa(hambur3 as Hamburguesa);

                break;
            case 4:
                Hamburguesa hambur4 = new Hamburguesa(numero2);
                Console.WriteLine("Añadida la hamburguesa 4");
                Cesta.altaHamburguesa(hambur4 as Hamburguesa);

                break;
            case 5:
                break;


        }
    }
}