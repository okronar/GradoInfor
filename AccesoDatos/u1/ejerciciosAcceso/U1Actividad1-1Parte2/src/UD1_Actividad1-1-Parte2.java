/* Muestra los archivos o directorios de
 * un directorio específico que se cargan en 
 * un array de elementos tipo String usando el método list()
 * El nombre del directorio a listar se pasa 
 * como parámetro al método main
 */

import java.io.File;

public class Parte2_Actividad1 {
    public static void main(String[] args) {
        // Verifica que se haya proporcionado un argumento al programa
        if (args.length != 1) {
            System.out.println("ingresa algo ...");
            System.exit(0);
        }

        // Obtiene el nombre del directorio a listar del primer argumento
        String directorio = args[0];

        // Muestra un mensaje indicando el directorio a listar
        System.out.println("Archivos en el directorio " + directorio);

        // Crea un objeto File que representa el directorio
        File carpeta = new File(directorio);

        // Verifica si el directorio existe
        if (carpeta.exists()) {
            // Obtiene una lista de archivos y directorios en el directorio
            String[] archivos = carpeta.list();

            // Itera a través de la lista de archivos y muestra cada nombre
            for (int i = 0; i < archivos.length; i++) {
                System.out.println(archivos[i]);
            }
        } else {
            // Muestra un mensaje si el directorio no existe
            System.out.println("DIRECTORIO INEXISTENTE");
        }
    }
}
