 package gestores;

import excepciones.MyException;

import java.io.DataInputStream;
import java.io.DataOutputStream;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

import java.util.ArrayList;

import modelo.Almacen;
import modelo.Mercancia;

/**
 * Esta clase GestorFicheros maneja la lectura y escritura de datos en ficheros.
 * Está relacionada con las clases Almacen y Mercancia, y utiliza excepciones personalizadas.
 * @author Sergio
 */
public class GestorFicheros {

    /**
     * Método privado que crea un nuevo fichero llamado "murcia.txt" dentro de la carpeta "ficheros".
     * @return El objeto File que representa el fichero creado.
     */
    private static File creoFichero() {
        // Se crea un objeto File que representa la carpeta "ficheros"
        File carpeta = new File("ficheros");
        // Se verifica si la carpeta no existe y, en ese caso, se crea
        if (!carpeta.exists()) {
            carpeta.mkdir();
        }
        // Se crea un objeto File que representa el fichero "murcia.txt" dentro de la carpeta
        File fichero = new File(carpeta, "murcia.txt");
        // Se devuelve el objeto File que representa el fichero creado
        return fichero;
    }

    /**
     * Método privado que crea un nuevo fichero llamado "nuevos.txt" dentro de la carpeta "ficheros".
     * @return El objeto File que representa el fichero creado.
     */
    private static File creoFicheroNuevo() {
        // Se crea un objeto File que representa la carpeta "ficheros"
        File carpeta = new File("ficheros");
        // Se verifica si la carpeta no existe y, en ese caso, se crea
        if (!carpeta.exists()) {
            carpeta.mkdir();
        }
        // Se crea un objeto File que representa el fichero "nuevos.txt" dentro de la carpeta
        File fichero = new File(carpeta, "nuevos.txt");
        // Se devuelve el objeto File que representa el fichero creado
        return fichero;
    }

    /**
     * Método público que guarda datos nuevos del almacén en un fichero.
     * @param a Objeto Almacen que contiene los datos a guardar.
     * @throws MyException Si ocurre algún error al abrir, escribir o cerrar el fichero.
     */
    public static void guardoDatosNuevos(Almacen a) throws MyException {
        // Abre el fichero
        File fich = creoFicheroNuevo();
        // Inicializa el flujo de salida de datos hacia el fichero
        DataOutputStream fOut = null;

        try {
            fOut = new DataOutputStream(new FileOutputStream(fich, true));
            // Escribe el código y la cantidad en el fichero
            fOut.writeUTF(a.getCodigo());
            fOut.writeInt(a.getCantidad());

        } catch (FileNotFoundException ex) {
            throw new MyException("Error abriendo el fichero " + fich.getAbsolutePath());
        } catch (IOException ex) {
            throw new MyException("Error escribiendo en el fichero " + fich.getAbsolutePath());
        } finally {
            // Cierra el flujo de salida de datos del fichero en el bloque finally
            if (fOut != null) {
                try {
                    fOut.close();
                } catch (IOException ex) {
                    throw new MyException("Error cerrando el fichero " + fich.getAbsolutePath());
                }
            }
        }
    }

    /**
     * Método público que lee datos de un fichero y los devuelve como una lista de objetos Almacen.
     * @return ArrayList de objetos Almacen con los datos leídos.
     * @throws MyException Si ocurre algún error al abrir, leer o cerrar el fichero.
     */
    public static ArrayList<Almacen> leoDatos() throws MyException {
        // Abre el fichero para la lectura
        File fich = creoFichero();
        // Crea una lista para almacenar los datos leídos
        ArrayList<Almacen> lista = new ArrayList<>();
        // Inicializa el flujo de entrada de datos desde el fichero
        DataInputStream dIn = null;

        try {
            dIn = new DataInputStream(new FileInputStream(fich));
            // Lee los datos del fichero mientras haya datos disponibles
            while (dIn.available() > 0) {
                Almacen p = new Almacen(dIn.readUTF(), dIn.readInt());
                lista.add(p);
            }

            return lista;
        } catch (FileNotFoundException ex) {
            throw new MyException("Error abriendo el fichero " + fich.getAbsolutePath());
        } catch (IOException ex) {
            throw new MyException("Error leyendo el fichero " + fich.getAbsolutePath());
        } finally {
            // Cierra el flujo de entrada de datos del fichero en el bloque finally
            if (dIn != null) {
                try {
                    dIn.close();
                } catch (IOException ex) {
                    throw new MyException("Error cerrando el fichero " + fich.getAbsolutePath());
                }
            }
        }
    }

    /**
     * Método público que guarda datos de una lista de Almacen en un fichero.
     * @param lista Lista de objetos Almacen que contiene los datos a guardar.
     * @throws MyException Si ocurre algún error al abrir, escribir o cerrar el fichero.
     */
    public static void guardoDatos(ArrayList<Almacen> lista) throws MyException {
        // Abre el fichero
        File fich = creoFichero();
        // Inicializa el flujo de salida de datos hacia el fichero
        DataOutputStream fOut = null;

        try {
            fOut = new DataOutputStream(new FileOutputStream(fich));
            // Escribe los códigos y cantidades en el fichero
            for (Almacen p : lista) {
                System.out.println(p.getCodigo());
                fOut.writeUTF(p.getCodigo());
                fOut.writeInt(p.getCantidad());
            }
        } catch (FileNotFoundException ex) {
            throw new MyException("Error abriendo el fichero " + fich.getAbsolutePath());
        } catch (IOException ex) {
            throw new MyException("Error escribiendo en el fichero " + fich.getAbsolutePath());
        } finally {
            // Cierra el flujo de salida de datos del fichero en el bloque finally
            if (fOut != null) {
                try {
                    fOut.close();
                } catch (IOException ex) {
                    throw new MyException("Error cerrando el fichero " + fich.getAbsolutePath());
                }
            }
        }
    }
}
