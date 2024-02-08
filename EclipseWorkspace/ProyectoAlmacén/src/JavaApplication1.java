import java.io.IOException;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Scanner;

import javax.xml.parsers.*;
import java.io.File;
import org.w3c.dom.*;

/**
 *
 * @author Alumno
 */
public class JavaApplication1 {

	/**
	 * @param args the command line arguments
	 */
	public static void main(String[] args) {

		DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();

		try {

			// implementacion sqlite
			Class.forName("org.sqlite.JDBC");

			// AQUI VA LA BASE DE DATOS
			Connection connection = DriverManager.getConnection("jdbc:sqlite:D:/Sergio/proyectoAlmacen.db");
			// llamo a la clase para crear
			
			// CrearTablas.borrar();
			CrearTablas.Tablas();

			// esto era para ejecutar consultas
			java.sql.Statement statement = connection.createStatement();
			// DOM
			DocumentBuilder builder = factory.newDocumentBuilder();

			// AQUI VA EL FICHERO XML
			Document document = builder.parse(new File("Pedidos_Tiendas2.xml"));
			document.getDocumentElement().normalize();
			System.out.println("Elemento raiz: " + document.getDocumentElement().getNodeName());

			// lista con todos los nodos pedidos
			NodeList pedidos = document.getElementsByTagName("pedido");
			System.out.println("Nodos pedido a recorrer : " + pedidos.getLength());

			// metodo principal que engloba los demas, se le pasan los nodos padre y empieza
			// la marcha
			recorrerNodosEInsertar(statement, pedidos);
			connection.close();

		} catch (Exception e) {
			e.printStackTrace();
		}

	}

	private static void recorrerNodosEInsertar(java.sql.Statement statement, NodeList pedidos) throws SQLException {
		// recorrer la lista de pedidos
		for (int i = 0; i < pedidos.getLength(); i++) {
			Node pedi = pedidos.item(i);// obtiene un nodo pedido
			System.out.println("Pedido " + (i + 1));

			if (pedi.getNodeType() == Node.ELEMENT_NODE) {// tipo de nodo
				// obtener los elementos del nodo
				Element elemento = (Element) pedi;
				//almaceno las variables para luego hacer las inserciones
				String numClienteString = getNodo("numero-cliente", elemento);

				String numPedidoString = getNodo("numero-pedido", elemento);

				String fecha = getNodo("fecha", elemento);
				//metodo para insertar el pedido usando las variables y comprobando diferentes escenarios
				insertarPedido(statement, numClienteString, numPedidoString, fecha);

				System.out.println("  Numero de cliente:" + getNodo("numero-cliente", elemento));
				System.out.println("  Numero de pedido:" + getNodo("numero-pedido", elemento));

				// lista con todos los nodos articulos
				NodeList articulos = elemento.getElementsByTagName("articulo");
				//Por cada uno de los nodos articulos vamos extrayendo articulo del xml y creamos las variables
				for (int j = 0; j < articulos.getLength(); j++) {
					Node articulo = articulos.item(j); // Obtener un nodo articulo
					System.out.println("  Artículo " + (j + 1));

					if (articulo.getNodeType() == Node.ELEMENT_NODE) {

						Element elementoArticulo = (Element) articulo;

						String codigoString = getNodo("codigo", elementoArticulo);

						String cantidadString = getNodo("cantidad", elementoArticulo);
						//usamos las variables creadas para hacer la inserción haciendo antes las comprobaciones
						
						insertarArticulosPedido(statement, numPedidoString, codigoString, cantidadString);
						//con esto compruebo si hay stock o no y se imprime el mensaje dedicado
						printearStock(codigoString, cantidadString);

						System.out.println("  Numero de pedido:" + numPedidoString);
						System.out.println("  Codigo:" + codigoString);
						System.out.println("  Cantidad:" + cantidadString);

					}
				}
			}

		}
	}
	
	//con esto compruebo si hay stock o no y se imprime el mensaje dedicado

	private static void printearStock(String codigoString, String cantidadString) {
		if (ComprobarExiste.ComprobarStock(codigoString, cantidadString)) {

			System.out.println("Hay suficiente stock para su pedido de articulo ");

		} else {

			System.out.println(
					"Parece que no hay suficiente stock para su pedido de articulo, se realizará un envío parcial ");

		}
	}

	// con esto insertamos articulos en la tabla de articulos pedido, revisando que
	// el codigo del articulo exista para meterlo y si ya esta introducido en el
	// pedido
	private static void insertarArticulosPedido(java.sql.Statement statement, String numPedidoString,
			String codigoString, String cantidadString) throws SQLException {

		if (!ComprobarExiste.ComprobarArticuloPedido(codigoString) && ComprobarExiste.ComprobarArticulo(codigoString)) {
			statement.execute("INSERT INTO articulosPedido values('" + numPedidoString + "','" + codigoString + "','"
					+ cantidadString + "')");
		} else if (ComprobarExiste.ComprobarArticuloPedido(codigoString)) {
			System.out.println("El Articulo ya esta ingresado en el pedido");
		} else if (ComprobarExiste.ComprobarArticulo(codigoString)) {
			System.out.println("El articulo no existe");

		}
	}
//insertamos pedido y comprobamos varias cosas, la primera que el pedido no exista y que el cliente si , luego si ya existe y tambien el cliente se pedirá 
//una verificacion mediante scanner para sobreescritura del pedido si el usuario asi lo requiere

	private static void insertarPedido(java.sql.Statement statement, String numClienteString, String numPedidoString,
			String fecha) throws SQLException {
		if (!ComprobarExiste.ComprobarPedido(numPedidoString) && ComprobarExiste.ComprobarCliente(numClienteString)) {
			statement.execute(
					"INSERT INTO pedido values('" + numClienteString + "','" + numPedidoString + "','" + fecha + "')");
		} else if (!ComprobarExiste.ComprobarCliente(numClienteString)) {
			System.out.println("El cliente no existe");
		} else if (ComprobarExiste.ComprobarPedido(numPedidoString)
				&& ComprobarExiste.ComprobarCliente(numClienteString)) {
			System.out.println("El pedido ya existe, quiere sobreescribirlo");
			System.out.println("S/N");

			Scanner scanner = new Scanner(System.in);
			String input;

			while (true) {
				input = scanner.nextLine().toUpperCase(); // Convertir entrada a mayúsculas para comparación

				if (input.equals("S")) {
					statement.execute("DELETE FROM pedido WHERE numeroCliente = '" + numClienteString
							+ "' AND numeroPedido = '" + numPedidoString + "' AND fecha = '" + fecha + "' ");
					statement.execute("INSERT INTO pedido values('" + numClienteString + "','" + numPedidoString + "','"
							+ fecha + "')");
					System.out.println("El pedido ha sido sobreescrito con exito");
					break; // Salir del bucle si la entrada es S
				} else if (input.equals("N")) {
					System.out.println("No se realizará la sobrescritura."); // Mensaje en caso de 'N'
					break; // Salir del bucle si la entrada es N
				} else {
					System.out.println("Entrada inválida. Por favor, ingrese 'S' o 'N'.");
				}
			}
		}
	}

	private static String getNodo(String etiqueta, Element elem) {
		NodeList nodos = elem.getElementsByTagName(etiqueta).item(0).getChildNodes();
		Node nodo = (Node) nodos.item(0);
		return nodo.getNodeValue();
	}

}
