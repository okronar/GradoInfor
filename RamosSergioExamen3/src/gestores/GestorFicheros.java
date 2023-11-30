/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
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
 *
 * @author Sergio
 */
public class GestorFicheros {

    private static File creoFichero() {
        File carpeta = new File("ficheros");
        if (!carpeta.exists()) {
            carpeta.mkdir();

        }
        File fichero = new File(carpeta, "murcia.txt");
        return fichero;
    }

    private static File creoFicheroNuevo() {
        File carpeta = new File("ficheros");
        if (!carpeta.exists()) {
            carpeta.mkdir();

        }
        File fichero = new File(carpeta, "nuevos.txt");
        return fichero;
    }

    public static void guardoDatosNuevos(Almacen a) throws MyException {
        //abro fichero 
        File fich = creoFicheroNuevo();
        DataOutputStream fOut = null;

        try {
            fOut = new DataOutputStream(new FileOutputStream(fich, true));

            fOut.writeUTF(a.getCodigo());
            fOut.writeInt(a.getCantidad());

        } catch (FileNotFoundException ex) {
            throw new MyException("Error abriendo el fichero " + fich.getAbsolutePath());
        } catch (IOException ex) {
            throw new MyException("Error escribiendo en el fichero " + fich.getAbsolutePath());
        } finally {
            if (fOut != null) {
                try {
                    fOut.close();
                } catch (IOException ex) {
                    throw new MyException("Error cerrando el fichero " + fich.getAbsolutePath());
                }
            }
        }

    }

    public static ArrayList<Almacen> leoDatos() throws MyException {
        File fich = creoFichero();
        ArrayList<Almacen> lista = new ArrayList<>();
        //abro el fichero para la lectura

        DataInputStream dIn = null;
        try {
            dIn = new DataInputStream(new FileInputStream(fich));
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
     * guarda los datos como String Int
     *
     * @param lista
     * @throws MyException
     */
    public static void guardoDatos(ArrayList<Almacen> lista) throws MyException {
        //abro fichero 
        File fich = creoFichero();
        DataOutputStream fOut = null;

        try {
            fOut = new DataOutputStream(new FileOutputStream(fich));
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
