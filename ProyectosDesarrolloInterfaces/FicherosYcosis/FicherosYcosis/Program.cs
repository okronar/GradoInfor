internal class Program
{
    private static void Main(string[] args)
    {
        string filepath = @"D:\Sergio\Interfaces-trabajos\list_people_in.txt";
        List<string> lineas = new List<string>();
        lineas = File.ReadAllLines(filepath).ToList();

        foreach (string linea in lineas)
        {
            Console.WriteLine(linea);
        }
        lineas.Add("Juan,Toledo,jt@email.com");

        filepath = @"D:\Sergio\Interfaces-trabajos\list_people_out.txt";

        try {
            File.WriteAllLines(filepath, lineas);
        }
        catch (Exception){ }
    }
}