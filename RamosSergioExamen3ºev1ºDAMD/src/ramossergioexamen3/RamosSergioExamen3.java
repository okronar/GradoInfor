/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ramossergioexamen3;

import excepciones.MyException;
import gestores.GestorDB;
import interfazGUI.VentanaMenu;
import javax.swing.JOptionPane;

/**
 *
 * @author Sergio
 */
public class RamosSergioExamen3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        GestorDB myConexion = new GestorDB("examen", "amacen", "jdbc:mysql://127.0.0.1/", "examen");
        try {
            myConexion.initDataBase();
            VentanaMenu vM = new VentanaMenu(myConexion);

        } catch (MyException ex) {
            JOptionPane.showMessageDialog(null, "No se ha podido conectar con la base de datos");
        }
    }
    
}
