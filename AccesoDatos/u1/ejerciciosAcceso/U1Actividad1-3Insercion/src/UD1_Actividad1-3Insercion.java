import java.io.*;

public class Actividad3_Insercion {
    public static void main(String[] args) throws IOException {
        // Verifica si se proporcionan los 4 argumentos necesarios
        if (args.length != 4) {
            System.out.println("ERROR. SE REQUIEREN 4 ARGUMENTOS");
             System.exit(0);
        }

        // Crea o abre el archivo de datos de empleados
        File archivoDatos = new File("ArchivoEmpleados.dat");

        // Crea un objeto RandomAccessFile para acceder al archivo en modo lectura/escritura
        RandomAccessFile archivoAccesoAleatorio = new RandomAccessFile(archivoDatos, "rw");

        // Inicializa un objeto StringBuffer para almacenar el apellido
        StringBuffer buffer = null;

        // Inicializa variables para almacenar ID, departamento y salario
        String apellido = args[1];
        int id = 0, dep = 0;
        Double salario = null;

        // Intenta convertir los argumentos a tipos de datos apropiados
        try {
              id = Integer.parseInt(args[0]);
        } catch (java.lang.NumberFormatException tipoErroneo) {
             System.out.println("ERROR. TIPO DE ARGUMENTO DE ID INCORRECTO");
            System.exit(1);
        } 

        try {
            dep = Integer.parseInt(args[2]);
        } catch (java.lang.NumberFormatException tipoErroneo) {
            System.out.println("ERROR. TIPO DE ARGUMENTO DE DEP INCORRECTO");
             System.exit(1);
        }   

        try {
            salario = Double.parseDouble(args[3]);
        } catch (java.lang.NumberFormatException tipoErroneo) {
            System.out.println("ERROR. TIPO DE ARGUMENTO DE SALARIO INCORRECTO");
              System.exit(1);
        } 

        // Bandera para indicar si el registro ya existe
         boolean registroExistente = false;

        // Calcula la posición del registro en el archivo
        long posicion = (id - 1) * 36; 
         long i = 0;

        // Comprueba si el registro ya existe en el archivo
        for (;;) { 
            archivoAccesoAleatorio.seek(i); 
            int nuevoId = archivoAccesoAleatorio.readInt();   
            if (nuevoId == id)
                registroExistente = true;
            i = archivoAccesoAleatorio.getFilePointer() + 20 + 4 + 8; 
            
            if (i == archivoAccesoAleatorio.length())
                break;
        }

        // Comprueba si el registro ya existe e imprime un mensaje apropiado
        if (registroExistente)     
            System.out.println("Error, el registro ya existe");
        else {
            // Si el registro no existe, lo inserta en la posición calculada
            archivoAccesoAleatorio.seek(posicion);
                archivoAccesoAleatorio.writeInt(id); 
                buffer = new StringBuffer(apellido);      
                buffer.setLength(10); 
            archivoAccesoAleatorio.writeChars(buffer.toString());
            archivoAccesoAleatorio.writeInt(dep);      
            archivoAccesoAleatorio.writeDouble(salario);
                System.out.println("Datos insertados");
        } 

        // Cierra el archivo de acceso aleatorio
        archivoAccesoAleatorio.close();  
    }
}
