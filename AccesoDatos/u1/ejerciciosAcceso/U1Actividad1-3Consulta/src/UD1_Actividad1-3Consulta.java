import java.io.*;


/*
Este programa Java lee un archivo de acceso aleatorio que almacena información de empleados. Dado un ID de empleado como argumento,
 busca y muestra en la consola los detalles del empleado correspondiente, incluyendo el apellido, el departamento y el salario.
*/
public class Actividad3_consulta{
    public static void main(String[] args) throws IOException {
        // Verifica si se proporciona el ID del empleado como argumento al programa
        if (args.length < 1) {
            System.out.println("Introduce el empleado a consultar");
            System.exit(1);
        }

        int id, dep, posicion;
        Double salario;
        char apellido[] = new char[10], aux;
        int registro = 0;

        try {
            // Recoge el ID del empleado a consultar
            registro = Integer.parseInt(args[0]);      
        } catch (NumberFormatException n) {
            System.out.println("Numero de empleado incorrecto");
             System.exit(2);
        }

        // Declara el fichero de acceso aleatorio
        File fichero = new File("AleatorioEmple.dat");  
         RandomAccessFile file = new RandomAccessFile(fichero, "r");
  
        posicion = (registro - 1) * 36;
        // Verifica si la posición supera la longitud del archivo
        if (posicion >= file.length() ) {
            System.out.println("ID: " + registro + ","
                    + " NO EXISTE EMPLEADO ID DEMASIADO GRANDE...");
        } else {
              file.seek(posicion); // Nos posicionamos en la ubicación del registro
            id = file.readInt(); // Obtiene el ID de empleado

            // Verifica si el ID obtenido coincide con el ID a consultar
            if (id != registro) {
                System.out.println("ID: " + registro + ","
                        + " NO EXISTE EMPLEADO - HUECO...");  
                System.exit(3);
            }

            // Lee y almacena uno a uno los caracteres del apellido en un array
            for (int i = 0; i < apellido.length; i++) {
                  aux = file.readChar();
                apellido[i] = aux;
            }

            // Convierte el array de caracteres a un String
            String apellidoS = new String(apellido).trim();

            // Obtiene el departamento y salario del empleado
            dep = file.readInt();
             salario = file.readDouble();

            // Muestra la información del empleado en la consola
            System.out.println("ID: " + registro + 
                             ", Apellido: " + apellidoS + 
                    ", Departamento: " + dep + ", Salario: " + salario);
        }  
        file.close();  // Cierra el archivo
    }
}

