internal class Program
{
    private static void Main(string[] args)
    {
        const double precioH = 2;
        const double precioP = 0.80;
        const double precioB = 1;
        int NumHam = 0;
        int NumPat = 0;
        int NumBe = 0;
        String linea;
        double precioFinal;
        Console.WriteLine("Numero de Hamburguesas");
        linea = Console.ReadLine();
        NumHam = int.Parse(linea);
        Console.WriteLine("Numero de patatas");
        linea = Console.ReadLine();
        NumPat = int.Parse(linea);
        Console.WriteLine("Numero de bebidas");
        linea = Console.ReadLine();
        NumBe = int.Parse(linea);

        precioFinal = (precioH*NumHam)+(precioP*NumPat)+(precioB*NumBe);


        Console.WriteLine("Ha pedido " + NumHam + " hamburguesas " +NumPat+" raciones de patatas "+NumBe+ " bebidas y el precio final es :" +
           precioFinal + "$" );
        
    }
}