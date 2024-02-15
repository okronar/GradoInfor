package testNeodatis;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Scanner;

import org.neodatis.odb.*;

public class main {

	public static void main(String[] args) {

<<<<<<< Updated upstream
		
		
		System.out.println("elige opcion");
=======
		System.out.println("elije opcion");
>>>>>>> Stashed changes
		Scanner scanner = new Scanner(System.in);

		int opcion = scanner.nextInt();

		switch (opcion) {

		case 1:

			ODB odb = ODBFactory.open("D:/Sergio/Base_datos_O1/proyectoAlmacenObjetos.odb");
			Objects<Pedido> objects = odb.getObjects(Pedido.class);
			while (objects.hasNext()) {
				Pedido pedido1 = objects.next();
				System.out.println("\t: " + pedido1.getNumeroCliente() + " " + pedido1.getNumeroPedido() + " "
						+ pedido1.getFecha());
			}
			odb.close();

			break;

		case 2:
			ODB odb = ODBFactory.open("D:/Sergio/Base_datos_O1/proyectoAlmacenObjetos.odb");
			Objects<LineaPedido> lineasPedido = odb.getObjects(LineaPedido.class);
			while (lineasPedido.hasNext()) {
				LineaPedido lineaPedido = lineasPedido.next();
				System.out.println("\t: " + lineaPedido.getNumeroPedido() + " " + lineaPedido.getCodigo() + " "
						+ lineaPedido.getCantidad());
			}
			odb.close();
			break;
		case 3:
			ODB odb = ODBFactory.open("D:/Sergio/Base_datos_O1/proyectoAlmacenObjetos.odb");

			// Consulta para obtener los artículos y contar cuántos pedidos tienen
			IQuery query = new CriteriaQuery(LineaPedido.class).groupBy("codigo").count("*", "count")
					.orderByDesc("count");

			Objects<Object[]> results = odb.getObjects(query);

			// Mostrar los resultados
			System.out.println("Listado de artículos diferentes recibidos:");
			while (results.hasNext()) {
				Object[] result = results.next();
				String codigoArticulo = (String) result[0];
				long cantidadPedidos = (long) result[1];
				System.out.println("\tArtículo: " + codigoArticulo + " - Pedidos: " + cantidadPedidos);
			}

			odb.close();
			break;
		case 4:
			ODB odb = ODBFactory.open("D:/Sergio/Base_datos_O1/proyectoAlmacenObjetos.odb");

			// Consulta para obtener los clientes y contar cuántos pedidos han enviado
			IQuery queryClientes = new CriteriaQuery(Pedido.class).groupBy("numeroCliente").count("*", "count")
					.orderByDesc("count");

			Objects<Object[]> resultadosClientes = odb.getObjects(queryClientes);

			// Mostrar los resultados
			System.out.println("Listado de clientes que han enviado pedidos:");
			while (resultadosClientes.hasNext()) {
				Object[] resultadoCliente = resultadosClientes.next();
				String numeroCliente = (String) resultadoCliente[0];
				long cantidadPedidosCliente = (long) resultadoCliente[1];
				System.out.println("\tCliente: " + numeroCliente + " - Pedidos: " + cantidadPedidosCliente);
			}

			odb.close();
			break;
		case 5:
			ODB odb = ODBFactory.open("D:/Sergio/Base_datos_O1/proyectoAlmacenObjetos.odb");

			// Consulta para obtener los artículos y sumar las cantidades de todos los
			// pedidos
			IQuery queryArticulos = new CriteriaQuery(LineaPedido.class).groupBy("codigo").sum("cantidad",
					"totalCantidad");

			Objects<Object[]> resultadosArticulos = odb.getObjects(queryArticulos);

			// Mostrar los resultados
			System.out.println("Listado de artículos con las cantidades sumadas de todos los pedidos:");
			while (resultadosArticulos.hasNext()) {
				Object[] resultadoArticulo = resultadosArticulos.next();
				String codigoArticulo = (String) resultadoArticulo[0];
				long totalCantidadArticulo = (long) resultadoArticulo[1];
				System.out.println("\tArtículo: " + codigoArticulo + " - Cantidad total: " + totalCantidadArticulo);
			}

			odb.close();
			break;

		case 6:
			ODB odb = ODBFactory.open("D:/Sergio/Base_datos_O1/proyectoAlmacenObjetos.odb");

			// Consulta para obtener las unidades pedidas por pedido
			IQuery queryUnidadesPorPedido = new CriteriaQuery(LineaPedido.class).groupBy("numeroPedido").sum("cantidad",
					"totalUnidades");

			Objects<Object[]> resultadosUnidadesPorPedido = odb.getObjects(queryUnidadesPorPedido);

			// Mostrar los resultados
			System.out.println("Listado de unidades pedidas por pedido:");
			while (resultadosUnidadesPorPedido.hasNext()) {
				Object[] resultadoPedido = resultadosUnidadesPorPedido.next();
				String numeroPedido = (String) resultadoPedido[0];
				long totalUnidadesPedido = (long) resultadoPedido[1];
				System.out.println("\tPedido: " + numeroPedido + " - Total de unidades: " + totalUnidadesPedido);
			}

			odb.close();
			break;
			
		case 7:
		    ODB odb = ODBFactory.open("D:/Sergio/Base_datos_O1/proyectoAlmacenObjetos.odb");

		    // Consulta para obtener la media de artículos por pedido
		    IQuery queryMediaArticulosPorPedido = new CriteriaQuery(LineaPedido.class)
		                                                .groupBy("numeroPedido")
		                                                .count("*", "totalArticulos")
		                                                .avg("totalArticulos");

		    Objects<Object[]> resultadosMediaArticulosPorPedido = odb.getObjects(queryMediaArticulosPorPedido);

		    // Mostrar los resultados
		    System.out.println("Media de artículos por pedido recibidos:");
		    while (resultadosMediaArticulosPorPedido.hasNext()) {
		        Object[] resultadoPedido = resultadosMediaArticulosPorPedido.next();
		        String numeroPedido = (String) resultadoPedido[0];
		        double mediaArticulosPorPedido = (double) resultadoPedido[1];
		        System.out.println("\tPedido: " + numeroPedido + " - Media de artículos: " + mediaArticulosPorPedido);
		    }

		    odb.close();
		    break;

			

		// traspasoDatos();

		}
	}

	private static void traspasoDatos() throws SQLException {
		Connection connection = DriverManager.getConnection("jdbc:sqlite:D:/Sergio/proyectoAlmacen.db");
		ODB odb = ODBFactory.open("D:/Sergio/Base_datos_O1/proyectoAlmacenObjetos.odb");

		java.sql.Statement statement = connection.createStatement();
		ResultSet resultSet = statement.executeQuery("SELECT * FROM articulosPedido");
		while (resultSet.next()) {

			String numeroPedido = resultSet.getString(1);
			String codigo = resultSet.getString(2);
			String cantidad = resultSet.getString(3);
			LineaPedido Lp1 = new LineaPedido(numeroPedido, codigo, cantidad);
			odb.store(Lp1);

		}
		resultSet = statement.executeQuery("SELECT * FROM pedido");
		while (resultSet.next()) {

			String numeroCliente = resultSet.getString(1);
			String numeroPedido = resultSet.getString(2);
			String fecha = resultSet.getString(3);
			Pedido p1 = new Pedido(numeroCliente, numeroPedido, fecha);
			odb.store(p1);

		}

		connection.close();
		odb.close();
	}

}
