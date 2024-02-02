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
			ResultSet resultSet = statement
					.executeQuery("SELECT * FROM pedido WHERE numeroPedido = '" + numeroPedido + "'");

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
			System.out.println("no se pudo realizar la comprobacion de pedido");
		}

		// Devolver si el pedido existe o no
		return pedidoExiste;
	}

	public static boolean ComprobarArticuloPedido(String codigo) {
		// Declaración de la variable que indicará si el pedido existe o no
		boolean pedidoExiste = false;

		try {
			// Cargar la clase del controlador JDBC
			Class.forName("org.sqlite.JDBC");

			// Establecer la conexión con la base de datos SQLite
			Connection connection = DriverManager.getConnection("jdbc:sqlite:D://Sergio/proyectoAlmacen.db");

			// Crear una declaración SQL
			java.sql.Statement statement = connection.createStatement();

			// Ejecutar la consulta SQL para verificar si el articulo existe en pedidos
			ResultSet resultSet = statement
					.executeQuery("SELECT * FROM articulosPedido WHERE codigo = '" + codigo + "'");

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
			System.out.println("no se pudo realizar la comprobacion de articulo del pedido");
		}

		// Devolver si el pedido existe o no
		return pedidoExiste;
	}

	public static boolean ComprobarArticulo(String codigo) {
		// Declaración de la variable que indicará si el articulo existe en articulosStock
		boolean existe = false;

		try {
			// Cargar la clase del controlador JDBC
			Class.forName("org.sqlite.JDBC");

			// Establecer la conexión con la base de datos SQLite
			Connection connection = DriverManager.getConnection("jdbc:sqlite:D://Sergio/proyectoAlmacen.db");

			// Crear una declaración SQL
			java.sql.Statement statement = connection.createStatement();

			// Ejecutar la consulta SQL para verificar si el articulo existe
			ResultSet resultSet = statement
					.executeQuery("SELECT * FROM articulosStock WHERE codigo = '" + codigo + "'");

			// Verificar si se encontró algún resultado
			if (resultSet.next()) {
				// Se encontró al menos un resultado, por lo tanto, el articulo existe
				existe = true;
			}

			// Cerrar recursos
			resultSet.close();
			statement.close();
			connection.close();

		} catch (ClassNotFoundException | SQLException e) {
			// Manejar la excepción si ocurre
			e.printStackTrace();
			System.out.println("no se pudo realizar la comprobacion de articulo");
		}

		// Devolver si el pedido existe o no
		return existe;
	}

	public static boolean ComprobarCliente(String numCliente) {
		// Declaración de la variable que indicará si el cliente existe o no
		boolean existe = false;

		try {
			// Cargar la clase del controlador JDBC
			Class.forName("org.sqlite.JDBC");

			// Establecer la conexión con la base de datos SQLite
			Connection connection = DriverManager.getConnection("jdbc:sqlite:D://Sergio/proyectoAlmacen.db");

			// Crear una declaración SQL
			java.sql.Statement statement = connection.createStatement();

			// Ejecutar la consulta SQL para verificar si el cliente existe
			ResultSet resultSet = statement
					.executeQuery("SELECT * FROM clientes WHERE numeroCliente = '" + numCliente + "'");

			// Verificar si se encontró algún resultado
			if (resultSet.next()) {
				// Se encontró al menos un resultado, por lo tanto, el cliente existe
				existe = true;
			}

			// Cerrar recursos
			resultSet.close();
			statement.close();
			connection.close();

		} catch (ClassNotFoundException | SQLException e) {
			// Manejar la excepción si ocurre
			e.printStackTrace();
			System.out.println("no se pudo realizar la comprobacion de cliente");
		}

		// Devolver si el pedido existe o no
		return existe;
	}

	public static boolean ComprobarStock(String codigo, String cantidad) {
		// Declaración de la variable que indicará si el pedido existe o no
		boolean hayStock = false;

		try {
			// Cargar la clase del controlador JDBC
			Class.forName("org.sqlite.JDBC");

			// Establecer la conexión con la base de datos SQLite
			Connection connection = DriverManager.getConnection("jdbc:sqlite:D://Sergio/proyectoAlmacen.db");

			// Crear una declaración SQL
			java.sql.Statement statement = connection.createStatement();

			// almaceno resultados en variables
			ResultSet resultSet = statement
					.executeQuery("SELECT stock FROM articulosStock WHERE codigo = '" + codigo + "'");
			int cantidadInt = Integer.parseInt(cantidad);

			if (resultSet.next()) {
				String stock = resultSet.getString("stock");
				int stockInt = Integer.parseInt(stock);
				// compruebo si hay stock
				if (stockInt >= cantidadInt) {

					hayStock = true;
				}

				// Cerrar recursos
				resultSet.close();
				statement.close();
				connection.close();
			}

			else {
				System.out.println("El código especificado no fue encontrado en la base de datos.");
				resultSet.close();
				statement.close();
				connection.close();
			}

		} catch (ClassNotFoundException | SQLException e) {
			// Manejar la excepción si ocurre
			e.printStackTrace();
			System.out.println("Error en la base de datos");
			
		}

		// Devolver si el pedido existe o no
		return hayStock;
	}

}
