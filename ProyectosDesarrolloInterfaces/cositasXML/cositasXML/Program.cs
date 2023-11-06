using System.Xml;


internal class Program
{
    private static void Main(string[] args)
    {/*
        //acceso a fichero xml y muestra por consola

        XmlDocument Xdoc = new XmlDocument();
        Xdoc.Load("D:\\Sergio\\Interfaces-trabajos\\ficheros\\xmlDoc.xml");
        Xdoc.Save(Console.Out); */
        
        //acceso de otra manera
    XmlTextReader xtr = new XmlTextReader("D:\\Sergio\\Interfaces-trabajos\\ficheros\\xmlDoc.xml");

    //similar a la manera que se emplea en java, eñ objeto reader permite recorrer

    while (xtr.Read()){
        //es determinante que el dovumento este bien formado y que el elemento etiqueta tenga valor
        //El xtr.name se refiere a las etiquietas del xml, en mi caso he creado una variable con todas las etquiteas en minuscula para una busqueda mas general.
            string nombreMinusculas = xtr.Name.ToLower();
            if (xtr.NodeType == XmlNodeType.Element && nombreMinusculas == "author")
	{
                string s1 = xtr.ReadElementString();
                Console.WriteLine("Autor: " + s1);
	}


        }
    }

 
}