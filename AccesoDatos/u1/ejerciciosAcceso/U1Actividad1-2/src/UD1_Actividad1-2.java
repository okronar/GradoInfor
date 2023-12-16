/* Muestra en la consola el contenido de un fichero de texto
 * que se le pasa al programa como un parámetro.
 */

import java.io.*;

public class Actividad2 {
    public static void main(String[] args) {
        // Verifica si se proporciona un argumento al programa
        if (args.length != 1) {
            System.out.println("ingresa algo anda....");
        } else {
            try {
                // Obtiene el nombre del fichero de texto del primer argumento
                String entrada = args[0];

                // Crea un objeto File que representa el fichero de texto
                File fichero = new File(entrada);

                // Verifica si el fichero existe
                if (fichero.exists()) {
                    // Crea un objeto FileReader para leer el contenido del fichero
                             FileReader lectorFichero = new FileReader(fichero);

                    int caracter;
                    // Lee uno a uno los caracteres del fichero y los muestra en la consola
                    while ((caracter = lectorFichero.read()) != -1) {
                        System.out.println((char) caracter); // (char) convierte el valor entero a carácter
                    }

                    // Cierra el FileReader
                    lectorFichero.close();
                } else {
                    // Muestra un mensaje si el fichero no existe
                       System.out.println("no existe....");
                }
            } catch (IOException e) {
                // Muestra un mensaje si hay un error de lectura
                        System.out.println("ERROR....");
            }
        }
    }
}
