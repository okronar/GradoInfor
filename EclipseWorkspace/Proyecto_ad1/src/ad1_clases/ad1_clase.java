package ad1_clases; // Declaración del paquete al que pertenece la clase.

import java.io.File; // Importación de la clase File del paquete java.io.

public class ad1_clase { // Declaración de la clase ad1_clase.

    public static void metodo(String[] args) { // Declaración del método "metodo" que toma un argumento de tipo arreglo de cadenas (String[] args).

        File file = new File(args[0]); // Creación de una instancia de la clase File a partir del primer argumento de la línea de comandos.

        if (file.isDirectory()) { // Comprueba si la instancia de File se refiere a un directorio.
        	
        	 // Obtiene un array de archivos y directorios 
            //contenidos en el directorio referenciado por "file".
            File[] ficheros = file.listFiles();
            
            for (File f : ficheros) { // Inicia un bucle for para iterar sobre los elementos del arreglo "ficheros".
            	
                System.out.println(f.getName()); // Imprime el nombre del archivo o directorio actual en la consola.
            }
        }
    }
}