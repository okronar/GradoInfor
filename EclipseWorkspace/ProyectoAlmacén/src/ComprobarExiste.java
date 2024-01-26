import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

public class ComprobarExiste {

	
	public static boolean ComprobarPedido(String numeroPedido) {
        // Declaración de la variable que indicará si el pedido existe o no
        boolean pedidoExiste = false;

        try {
            // Cargar la clase del controlador JDBC
            Class.forName("org.sqlite.JDBC");

            // Establecer la conexión con la base de datos SQLite
            Connection connection = DriverManager.getConnection("jdbc:sqlite:D://Sergio/proyectoAlmacen.db");

            // Crear una declaración SQL
            java.sql.Statement statement = connection.createStatement();

            // Ejecutar la consulta SQL para verificar si el pedido existe
            ResultSet resultSet = statement.executeQuery("SELECT * FROM pedido WHERE numeroPedido = '" + numeroPedido + "'");

            // Verificar si se encontró algún resultado
            if (resultSet.next()) {
                // Se encontró al menos un resultado, por lo tanto, el pedido existe
                pedidoExiste = true;
            }

            // Cerrar recursos
            resultSet.close();
            statement.close();
            connection.close();

        } catch (ClassNotFoundException | SQLException e) {
            // Manejar la excepción si ocurre
            e.printStackTrace();
        }

        // Devolver si el pedido existe o no
        return pedidoExiste;
    }
	public static boolean ComprobarArticulo(String numeroPedido) {
        // Declaración de la variable que indicará si el pedido existe o no
        boolean pedidoExiste = false;

        try {
            // Cargar la clase del controlador JDBC
            Class.forName("org.sqlite.JDBC");

            // Establecer la conexión con la base de datos SQLite
            Connection connection = DriverManager.getConnection("jdbc:sqlite:D://Sergio/proyectoAlmacen.db");

            // Crear una declaración SQL
            java.sql.Statement statement = connection.createStatement();

            // Ejecutar la consulta SQL para verificar si el pedido existe
            ResultSet resultSet = statement.executeQuery("SELECT * FROM articulos WHERE numeroPedido = '" + numeroPedido + "'");

            // Verificar si se encontró algún resultado
            if (resultSet.next()) {
                // Se encontró al menos un resultado, por lo tanto, el articulo existe
                pedidoExiste = true;
            }

            // Cerrar recursos
            resultSet.close();
            statement.close();
            connection.close();

        } catch (ClassNotFoundException | SQLException e) {
            // Manejar la excepción si ocurre
            e.printStackTrace();
        }

        // Devolver si el pedido existe o no
        return pedidoExiste;
    }
  	  
  	  
  	  
  }
