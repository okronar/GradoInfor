package testNeodatis;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Scanner;

import org.neodatis.odb.*;
import org.neodatis.odb.core.query.IQuery;
import org.neodatis.odb.core.query.IValuesQuery;
import org.neodatis.odb.impl.core.query.criteria.CriteriaQuery;
import org.neodatis.odb.impl.core.query.values.ValuesCriteriaQuery;

public class main {

	public static void main(String[] args) {

		
			//traspasoDatos();
		
		
		System.out.println("elige opcion");

		Scanner scanner = new Scanner(System.in);

		int opcion = scanner.nextInt();

		switch (opcion) {
//Número de pedidos recibidos y procesados correctamente.
		case 1:

			ODB odb = ODBFactory.open("D:/Sergio/Base_datos_O1/proyectoAlmacenObjetos.odb");
			Objects<Pedido> objects = odb.getObjects(Pedido.class);
			int cuenta = 0;
			while (objects.hasNext()) {
				Pedido pedido1 = objects.next();
				System.out.println("\t: " + pedido1.getNumeroCliente() + " " + pedido1.getNumeroPedido() + " "
						+ pedido1.getFecha());
				cuenta++;
			}
			System.out.println("numero de pedidos recibidos : " + cuenta);
			odb.close();

			break;
//Número de líneas de pedido recibidas.
		case 2:
			ODB odb2 = ODBFactory.open("D:/Sergio/Base_datos_O1/proyectoAlmacenObjetos.odb");
			Objects<LineaPedido> lineasPedido = odb2.getObjects(LineaPedido.class);
			int cuenta2 = 0;
			while (lineasPedido.hasNext()) {
				LineaPedido lineaPedido = lineasPedido.next();
				System.out.println("\t: " + lineaPedido.getNumeroPedido() + " " + lineaPedido.getCodigo() + " "
						+ lineaPedido.getCantidad());
				cuenta2++;
			}
			System.out.println("numero de lineas de pedidos recibidas : " + cuenta2);
			odb2.close();
			break;

		// Listado de artículos diferentes recibidos (incluir en cuantos pedidos cada
		// artículo).
		case 3:
			ODB odb3 = ODBFactory.open("D:/Sergio/Base_datos_O1/proyectoAlmacenObjetos.odb");

			IValuesQuery query = new ValuesCriteriaQuery(LineaPedido.class).count("numeroPedido").field("codigo")
					.groupBy("codigo");
			Values values = odb3.getValues(query);

			// Mostrar los resultados
			System.out.println("Listado de artículos diferentes recibidos:");
			while (values.hasNext()) {
				
				ObjectValues ObjectValues = (ObjectValues) values.next();

				System.out.println("\tArtículo: " + ObjectValues.getByAlias("codigo") + " - Pedidos: "
						+ ObjectValues.getByAlias("numeroPedido"));
			}

			odb3.close();
			break;
			
		//Listado de clientes que han enviado pedidos. (incluir el número de pedidos)
	
		case 4:
			
			ODB odb4 = ODBFactory.open("D:/Sergio/Base_datos_O1/proyectoAlmacenObjetos.odb");

			IValuesQuery query2 = new ValuesCriteriaQuery(Pedido.class).count("numeroPedido").field("numeroCliente")
					.groupBy("numeroCliente");
			Values values2 = odb4.getValues(query2);
			
			System.out.println("Listado de clientes con Pedidos:");
			while (values2.hasNext()) {
				
				ObjectValues ObjectValues = (ObjectValues) values2.next();

				System.out.println("\tCliente: " + ObjectValues.getByAlias("numeroCliente") + " - Pedidos: "
						+ ObjectValues.getByAlias("numeroPedido"));
			}

			odb4.close();
			break;
			
			//Listado de artículos con las cantidades sumadas de todos los pedidos.
			
			case 5:
			
			ODB odb5 = ODBFactory.open("D:/Sergio/Base_datos_O1/proyectoAlmacenObjetos.odb");

			IValuesQuery query3 = new ValuesCriteriaQuery(LineaPedido.class).sum("cantidad").field("codigo")
					.groupBy("codigo");
			Values values3 = odb5.getValues(query3);
			
			System.out.println("Listado de clientes con Pedidos:");
			while (values3.hasNext()) {
				
				ObjectValues ObjectValues = (ObjectValues) values3.next();
				System.out.println("\tArticulo: " + ObjectValues.getByAlias("codigo") + " - Cantidad Total: "
						+ ObjectValues.getByAlias("cantidad"));
				

			}

			odb5.close();
			break; 
			
			
		

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
			int cantidad = resultSet.getInt(3);
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
