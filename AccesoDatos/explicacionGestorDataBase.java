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
 * Clase que gestiona la conexión y operaciones con la base de datos.
 * 
 * @author Sergio
 */
public class GestorDB {

    // Atributos para la conexión a la base de datos
    private String user;
    private String db;
    private String conexion;
    private String password;
    private Connection conn;

    /**
     * Constructor de la clase GestorDB.
     *
     * @param user      Nombre de usuario para la conexión a la base de datos.
     * @param db        Nombre de la base de datos.
     * @param conexion  URL de conexión a la base de datos.
     * @param password  Contraseña para la conexión a la base de datos.
     */
    public GestorDB(String user, String db, String conexion, String password) {
        // Inicializamos todos los parámetros, pero no nos conectamos a la base
        this.user = user;
        this.db = db;
        this.conexion = conexion;
        this.password = password;
        this.conn = null;
    }

    /**
     * Inicializa la conexión a la base de datos.
     *
     * @throws MyException Si ocurre un error durante la inicialización.
     */
    public void initDataBase() throws MyException {
        try {
            // Cargar el driver de MySQL
            Class.forName("com.mysql.jdbc.Driver");
            this.conn = DriverManager.getConnection(conexion + db, user, password);
        } catch (ClassNotFoundException ex) {
            // Excepción si no se encuentra el driver
            throw new MyException("No has puesto la librería MySql");
        } catch (SQLException ex) {
            // Excepción si hay un error al conectarse a la base de datos
            ex.printStackTrace();
            throw new MyException(ex.getSQLState() + " Error al conectarse");
        }
    }

    /**
     * Cierra la conexión a la base de datos.
     *
     * @throws MyException Si ocurre un error al cerrar la conexión.
     */
    public void cerrarConexion() throws MyException {
        try {
            // Cerrar la conexión
            this.conn.close();
            System.out.println("se cierra");
        } catch (SQLException ex) {
            // Excepción si hay un error al cerrar la conexión
            ex.printStackTrace();
            throw new MyException(ex.getSQLState() + " No se ha podido cerrar la base de datos, posible pérdida de información");
        }
    }

    /**
     * Inserta una mercancía en la base de datos.
     *
     * @param m1 Mercancía a insertar.
     * @return Número de filas afectadas por la inserción.
     * @throws MyException Si ocurre un error durante la inserción.
     */
    public int insertoMercancia(Mercancia m1) throws MyException {
        PreparedStatement st = null;

        try {
            // Preparar la sentencia SQL para la inserción
            st = this.conn.prepareStatement("INSERT INTO mercancia VALUES(?,?,?,?);");
            st.setString(1, m1.getCodigo());
            st.setString(2, m1.getDescripcion());
            st.setInt(3, m1.getCantidad());
            st.setFloat(4, m1.getPrecio());
            
            // Llamar a un método estático (no proporcionado) para realizar alguna acción relacionada con la alta de la mercancía
            GestorMercancias.altaM(m1);
            
            // Ejecutar la sentencia SQL de inserción y devolver el número de filas afectadas
            return st.executeUpdate();
        } catch (SQLException ex) {
            // Excepción si hay un error durante la inserción
            throw new MyException("Error insertando a : " + m1);
        } finally {
            try {
                // Cerrar el PreparedStatement
                st.close();
            } catch (SQLException ex) {
                // Excepción si hay un error al cerrar el PreparedStatement
                throw new MyException("Posible pérdida de datos al cerrar el Statement");
            }
        }
    }

    /**
     * Comprueba si una mercancía es nueva en el almacén.
     *
     * @param a     Almacén a verificar.
     * @param lista Lista de mercancías.
     * @return true si la mercancía es nueva, false en caso contrario.
     */
    public boolean comprobarNuevo(Almacen a, ArrayList<Mercancia> lista) {
        // Iterar sobre la lista de mercancías para comprobar si el código ya existe
        for (Mercancia mercancia : lista) {
            if (a.getCodigo().equals(mercancia.getCodigo())) {
                return true;
            }
        }
        return false;
    }

    /**
     * Guarda un conjunto de mercancías en la base de datos.
     *
     * @param lista Lista de mercancías a guardar.
     * @throws MyException Si ocurre un error durante la operación.
     */
    public void guardaMercancias(ArrayList<Mercancia> lista) throws MyException {
        // Iterar sobre la lista y llamar al método de inserción para cada mercancía
        for (Mercancia p : lista) {
            insertoMercancia(p);
        }
    }

    /**
     * Actualiza la cantidad de mercancía después de una salida.
     *
     * @param m       Mercancía a actualizar.
     * @param cantite Cantidad a restar.
     * @return Número de filas afectadas por la actualización.
     * @throws MyException Si ocurre un error durante la actualización.
     */
    public int actualizarMercanciaSalida(Mercancia m, int cantite) throws MyException {
        PreparedStatement st = null;
        int total = m.getCantidad() - cantite;
        try {
            // Preparar la sentencia SQL para la actualización de la cantidad de mercancía
            st = this.conn.prepareStatement("UPDATE mercancia SET cantidad = ? WHERE codigo =?;");
            st.setInt(1, total);
            st.setString(2, m.getCodigo());
            
            // Ejecutar la sentencia SQL de actualización y devolver el número de filas afectadas
            return st.executeUpdate();
        } catch (SQLException ex) {
            // Excepción si hay un error durante la actualización
            throw new MyException("Error actualizando salida");
        } finally {
            try {
                // Cerrar el PreparedStatement
                st.close();
            } catch (SQLException ex) {
                // Excepción si hay un error al cerrar el PreparedStatement
                ex.printStackTrace();
                throw new MyException(ex.getSQLState() + " Posible pérdida de datos al cerrar el Statement");
            }
        }
    }

    /**
     * Actualiza la cantidad de mercancía desde un fichero.
     *
     * @param v Mercancía a actualizar.
     * @return Número de filas afectadas por la actualización.
     * @throws MyException Si ocurre un error durante la actualización.
     */
    public int actualizarMercanciaDesdeFich(Almacen v) throws MyException {
        PreparedStatement st = null;
        try {
            // Preparar la sentencia SQL para la actualización de la cantidad de mercancía desde un fichero
            st = this.conn.prepareStatement("UPDATE mercancia SET cantidad = ? WHERE codigo =?;");
            st.setInt(1, v.getCantidad());
            st.setString(2, v.getCodigo());
            
            // Ejecutar la sentencia SQL de actualización y devolver el número de filas afectadas
            return st.executeUpdate();
        } catch (SQLException ex) {
            // Excepción si hay un error durante la actualización
            throw new MyException("Error actualizando desde fichero");
        } finally {
            try {
                // Cerrar el PreparedStatement
                st.close();
            } catch (SQLException ex) {
                // Excepción si hay un error al cerrar el PreparedStatement
                ex.printStackTrace();
                throw new MyException(ex.getSQLState() + " Posible pérdida de datos al cerrar el Statement");
            }
        }
    }

    /**
     * Obtiene un ArrayList de mercancías desde la base de datos.
     *
     * @return ArrayList de mercancías.
     * @throws MyException Si ocurre un error durante la obtención de datos.
     */
    public ArrayList ArrayMercancias() throws MyException {
        ArrayList<Mercancia> lista = new ArrayList<>();
        PreparedStatement ps = null;
        ResultSet rs = null;
        try {
            // Preparar la sentencia SQL para obtener el listado de mercancías
            ps = conn.prepareStatement("SELECT * FROM mercancia;");
            
            // Ejecutar la sentencia SQL y obtener el conjunto de resultados
            rs = ps.executeQuery();
            
            // Iterar sobre el conjunto de resultados y crear instancias de Mercancia
            while (rs.next()) {
                Mercancia p = new Mercancia(
                        rs.getString(1),
                        rs.getString(2),
                        rs.getInt(3),
                        rs.getFloat(4)
                );
                
                // Llamar a un método estático (no proporcionado) para realizar alguna acción relacionada con la alta de la mercancía
                GestorMercancias.altaM(p);
                
                // Agregar la mercancía a la lista
                lista.add(p);
            }
            return lista;

        } catch (SQLException ex) {
            // Excepción si hay un error durante la obtención de datos
            ex.printStackTrace();
            throw new MyException(ex.getErrorCode() + "  Error obteniendo el listado de mercancia");
        } finally {
            try {
                // Cerrar el ResultSet
                rs.close();
            } catch (SQLException ex) {
                // Excepción si hay un error al cerrar el ResultSet
                throw new MyException("Posible pérdida de datos al cerrar el ResultSet");
            }
        }
    }
}
