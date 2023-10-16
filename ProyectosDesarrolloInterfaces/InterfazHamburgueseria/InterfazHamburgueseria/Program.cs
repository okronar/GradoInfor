using InterfazHamburgueseria;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        string linea;
        int numero;




        Console.WriteLine("Bienvenido que hamburguesa desea ?");
        Console.WriteLine("1.Hamburguesa simpple 2.Hamburguesa completa 3.Hamburguesa Bacon 4.El Apocalipsis");
        linea = Console.ReadLine(); numero = int.Parse(linea);

        switch (numero)
        {

            case 1: Hamburguesa hambur1 = new Hamburguesa(numero);
                Console.WriteLine("Añadida la hamburguesa 1");
                Cesta.altaHamburguesa(hambur1 as Hamburguesa);
                break;
            case 2:
                Hamburguesa hambur2 = new Hamburguesa(numero);
                Console.WriteLine("Añadida la hamburguesa 2");
                Cesta.altaHamburguesa(hambur2 as Hamburguesa);
                break;
            case 3:
                Hamburguesa hambur3 = new Hamburguesa(numero);
                Console.WriteLine("Añadida la hamburguesa 3");
                Cesta.altaHamburguesa(hambur3 as Hamburguesa);
                break;
            case 4:
                Hamburguesa hambur4 = new Hamburguesa(numero);
                Console.WriteLine("Añadida la hamburguesa 4");
                Cesta.altaHamburguesa(hambur4 as Hamburguesa);
                break;
            case 0: Console.WriteLine("gracias por su visita, hasta luego");
                break;
        }

    }
}