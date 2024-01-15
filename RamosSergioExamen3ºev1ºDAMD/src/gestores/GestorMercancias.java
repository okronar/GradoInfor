/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package gestores;

import excepciones.MyException;
import interfazGUI.VentanaListado;
import java.util.ArrayList;
import java.util.HashSet;
import modelo.Almacen;
import modelo.Mercancia;

/**
 *
 * @author Sergio
 */
public class GestorMercancias {

    private static final ArrayList<Mercancia> MERCANCIAS = new ArrayList();
    private static final ArrayList<Almacen> SINSTOCK = new ArrayList();

    public static boolean altaM(Mercancia m) {

        return MERCANCIAS.add(m);
    }

    /**
     * busca usuarios por codigo
     *
     * @return
     */
    public static boolean altaSIN(Almacen m) {

        return SINSTOCK.add(m);
    }

    public static boolean bajaSIN(Almacen m) {

        return SINSTOCK.remove(m);
    }

    /**
     * busca usuarios por codigo
     *
     * @param codigo
     * @return
     */
    public static Mercancia buscaM(String codigo) {

        for (Mercancia a : MERCANCIAS) {
            if ((a.getCodigo()).equalsIgnoreCase(codigo)) {
                return a;

            }
        }

        return null;
    }

    public static String[][] listadoMercancias() throws MyException {
        int indice = 0;
        String[][] datos = new String[MERCANCIAS.size()][VentanaListado.CABECERA.length];
        for (Mercancia x : MERCANCIAS) {
            datos[indice++] = x.toArray();
        }

        return datos;
    }

    public static boolean compruebaListadoSIN(Almacen m) {
        for (Almacen a : SINSTOCK) {
            if (a.getCodigo().equals(m.getCodigo())) {
                return true;
            }
        }
        return false;
    }

    public static String listadoSINSTOCK() {
        String resultado = "CODIGO  DESCRIPCION   CANTIDAD   PRECIO";
        for (Almacen me : SINSTOCK) {
            resultado += me.toString() + "\n";
        }
        return resultado;
    }

}
