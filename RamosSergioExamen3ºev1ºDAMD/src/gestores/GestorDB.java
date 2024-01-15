/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package gestores;

import excepciones.MyException;
import interfazGUI.VentanaListado;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import modelo.Almacen;
import modelo.Mercancia;

/**
 * creo los constructores de la base de datos
 *
 * @author Sergio
 */
public class GestorDB {

    private String user;
    private String db;
    private String conexion;
    private String password;
    private Connection conn;

    /**
     *
     * @param user
     * @param db
     * @param conexion
     * @param password
     */
    public GestorDB(String user, String db, String conexion, String password) {
        //inicializamos todos los parámetros, pero no nos conectamos a la base
        this.user = user;
        this.db = db;
        this.conexion = conexion;
        this.password = password;
        this.conn = null;

    }

    public void initDataBase() throws MyException {
        try {
            //cargar el driver
            Class.forName("com.mysql.jdbc.Driver");
            this.conn
                    = DriverManager.getConnection(conexion + db, user, password);
        } catch (ClassNotFoundException ex) {
            //ex.printStackTrace();
            throw new MyException("No has puesto la librería MySql");
        } catch (SQLException ex) {
            ex.printStackTrace();
            throw new MyException(ex.getSQLState() + " Error al conectarse");
        }
    }

    /**
     * este para cuando cierre la ventana que se cierre la conexion
     *
     * @throws excepciones.MyException
     *
     */
    public void cerrarConexion() throws MyException {
        try {
            this.conn.close();
            System.out.println("se cierra");
        } catch (SQLException ex) {
            ex.printStackTrace();
            throw new MyException(ex.getSQLState() + " no se ha podido cerrar la base de datos, posible perdida de informacion");

        }
    }

    public int insertoMercancia(Mercancia m1) throws MyException {
        PreparedStatement st = null;

        try {
            st = this.conn.prepareStatement("INSERT INTO mercancia VALUES(?,?,?,?);");
            st.setString(1, m1.getCodigo());
            st.setString(2, m1.getDescripcion());
            st.setInt(3, m1.getCantidad());
            st.setFloat(4, m1.getPrecio());
            GestorMercancias.altaM(m1);
            return st.executeUpdate();
        } catch (SQLException ex) {
            throw new MyException("error insertando a : " + m1);
        } finally {
            try {
                st.close();
            } catch (SQLException ex) {
                throw new MyException("posible perdida de datos");
            }
        }

    }

    public boolean comprobarNuevo(Almacen a, ArrayList<Mercancia> lista) {
        for (Mercancia mercancia : lista) {
            if (a.getCodigo().equals(mercancia.getCodigo())) {
                return true;
            }
        }
        return false;

    }

    public void guardaMercancias(ArrayList<Mercancia> lista) throws MyException {

        for (Mercancia p : lista) {
            insertoMercancia(p);

        }
    }

    public int actualizarMercanciaSalida(Mercancia m, int cantite) throws MyException {
        PreparedStatement st = null;
        int total = m.getCantidad() - cantite;
        try {
            st = this.conn.prepareStatement("UPDATE mercancia SET cantidad = ? WHERE codigo =?;");
            st.setInt(1, total);
            st.setString(2, m.getCodigo());

            return st.executeUpdate();

        } catch (SQLException ex) {

            throw new MyException("error actualizando salida");
        } finally {

            try {
                st.close();
            } catch (SQLException ex) {
                ex.printStackTrace();
                throw new MyException(ex.getSQLState() + "posible perdida de datos");
            }
        }
    }

    public int actualizarMercanciaDesdeFich(Almacen v) throws MyException {
        PreparedStatement st = null;
        try {
            st = this.conn.prepareStatement("UPDATE mercancia SET cantidad = ? WHERE codigo =?;");
            st.setInt(1, v.getCantidad());
            st.setString(2, v.getCodigo());

            return st.executeUpdate();

        } catch (SQLException ex) {

            throw new MyException("error actualizando desde fichero");
        } finally {

            try {
                st.close();
            } catch (SQLException ex) {
                ex.printStackTrace();
                throw new MyException(ex.getSQLState() + "posible perdida de datos");
            }
        }
    }

    public ArrayList ArrayMercancias() throws MyException {

        ArrayList<Mercancia> lista = new ArrayList<>();

        PreparedStatement ps = null;
        ResultSet rs = null;
        try {
            ps = conn.prepareStatement("SELECT * "
                    + " FROM mercancia;");

            rs = ps.executeQuery();
            while (rs.next()) {
                Mercancia p = new Mercancia(
                        rs.getString(1),
                        rs.getString(2),
                        rs.getInt(3),
                        rs.getFloat(4)
                );
                GestorMercancias.altaM(p);
                lista.add(p);
            }
            return lista;

        } catch (SQLException ex) {
            ex.printStackTrace();
            throw new MyException(ex.getErrorCode() + "  Error obteniendo el listado de mercancia");
        } finally {
            try {
                rs.close();
            } catch (SQLException ex) {
                throw new MyException("posible perdida de datos");
            }
        }

    }

}
