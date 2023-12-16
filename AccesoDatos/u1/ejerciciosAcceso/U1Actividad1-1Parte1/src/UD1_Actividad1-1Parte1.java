/* Muestra los archivos o directorios 
 * de un directorio específico que se cargan en
 * un array de objetos tipo File utilizando el método list()
 */

import java.io.File;

public class Parte1_Actividad1 {
    public static void main(String[] args) {
        // Establece el directorio actual como punto de partida
        String directorio = ".";

         // Crea un objeto File que representa el directorio
        File carpeta = new File(directorio);

        // Obtiene una lista de archivos y directorios en el directorio actual
            File[] archivosYDirectorios = carpeta.listFiles();        
        
        // Muestra la cantidad de elementos en el directorio actual
              System.out.printf("Elementos en el directorio actual: %d %n", archivosYDirectorios.length);
        
        // Itera a través de la lista de archivos y directorios
        for (int indice = 0; indice < archivosYDirectorios.length; indice++) {
            // Obtiene el elemento actual de la lista
            File elemento = archivosYDirectorios[indice];
            
            // Muestra información sobre el elemento actual
                    System.out.printf("Nombre: %s, ¿es archivo?: %b, ¿es directorio?: %b %n", 
                               elemento.getName(), elemento.isFile(), elemento.isDirectory());
        }
    }
}
