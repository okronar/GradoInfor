import java.io.IOException;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
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
	public static void main(String[] args)  {

		DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();

		try {
			
			
			
			// implementacion sqlite
			Class.forName("org.sqlite.JDBC");
			Connection connection = DriverManager.getConnection("jdbc:sqlite:D:/Sergio/proyectoAlmacen.db");
			// llamo a la clase para crear
			CrearTablas.borrar();
			CrearTablas.Tablas();

			// esto era para ejecutar consultas
			java.sql.Statement statement = connection.createStatement();
			//DOM
			DocumentBuilder builder = factory.newDocumentBuilder();
			Document document = builder.parse(new File("Pedidos_Tiendas.xml"));
			document.getDocumentElement().normalize();
			System.out.println("Elemento raiz: " + document.getDocumentElement().getNodeName());

			// lista con todos los nodos pedidos
			NodeList pedidos = document.getElementsByTagName("pedido");
			System.out.println("Nodos pedido a recorrer : " + pedidos.getLength());

			// recorrer la lista de pedidos
			for (int i = 0; i < pedidos.getLength(); i++) {
				Node pedi = pedidos.item(i);// obtiene un nodo pedido
				System.out.println("Pedido " + (i + 1));

				if (pedi.getNodeType() == Node.ELEMENT_NODE) {// tipo de nodo
					// obtener los elementos del nodo
					Element elemento = (Element) pedi;
					
					
					String numClienteString = getNodo("numero-cliente", elemento);
					
					String numPedidoString = getNodo("numero-pedido", elemento);
					
					String fecha = getNodo("fecha", elemento);
					
					insertarPedido(statement, numClienteString, numPedidoString, fecha);

					System.out.println("  Numero de cliente:" + getNodo("numero-cliente", elemento));
					System.out.println("  Numero de pedido:" + getNodo("numero-pedido", elemento));

					// lista con todos los nodos articulos
					NodeList articulos = elemento.getElementsByTagName("articulo");

					for (int j = 0; j < articulos.getLength(); j++) {
						Node articulo = articulos.item(j); // Obtener un nodo articulo
						System.out.println("  Artículo " + (j + 1));

						if (articulo.getNodeType() == Node.ELEMENT_NODE) {

							
							
							Element elementoArticulo = (Element) articulo;

							String codigoString = getNodo("codigo", elementoArticulo);
							
							String cantidadString = getNodo("cantidad", elementoArticulo);
							
							
							insertarArticulos(statement, numPedidoString, codigoString, cantidadString);
							

							System.out.println("  Numero de pedido:" + numPedidoString );
							System.out.println("  Codigo:" + codigoString);
							System.out.println("  Cantidad:" + cantidadString);

						}
					}
				}

			}

		} catch (Exception e) {
			e.printStackTrace();
		}

	}

	private static void insertarArticulos(java.sql.Statement statement, String numPedidoString, String codigoString,
			String cantidadString) throws SQLException {
		if (!ComprobarExiste.ComprobarArticulo(numPedidoString)) {
			statement.execute("INSERT INTO articulos values('" + numPedidoString + "','" + codigoString
				+ "','" + cantidadString + "')");
		}else {
			System.out.println("El Articulo ya existe");
		}
	}

	private static void insertarPedido(java.sql.Statement statement, String numClienteString, String numPedidoString,
			String fecha) throws SQLException {
		if (!ComprobarExiste.ComprobarPedido(numPedidoString)) {
			statement.execute("INSERT INTO pedido values('" + numClienteString + "','"
					+ numPedidoString + "','" + fecha + "')");
		} else {
			System.out.println("El pedido ya existe");
		}
	}
	

	private static String getNodo(String etiqueta, Element elem) {
		NodeList nodos = elem.getElementsByTagName(etiqueta).item(0).getChildNodes();
		Node nodo = (Node) nodos.item(0);
		return nodo.getNodeValue();
	}

}
