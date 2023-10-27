package ad1_ejecutables; // Declaración del paquete al que pertenece la clase.

import ad1_clases.ad1_clase; // Importación de la clase ad1_clase del paquete ad1_clases.

public class ad1_ejecutable { // Declaración de la clase ad1_ejecutable.

    public static void main(String[] args) { // Declaración del método principal "main", que es el punto de entrada de la aplicación.

        String[] argumentos = {"C:\\"}; // Creación de un arreglo de cadenas llamado "argumentos" con un elemento que contiene la ruta "C:\\".

        ad1_clase.metodo(argumentos); // Llama al método "metodo" de la clase ad1_clase, pasando el array de argumentos como argumento.
    }
}
