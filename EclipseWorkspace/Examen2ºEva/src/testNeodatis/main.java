package testNeodatis;

import java.io.File;
import java.math.BigDecimal;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.neodatis.odb.*;
import org.neodatis.odb.core.query.IQuery;
import org.neodatis.odb.core.query.IValuesQuery;
import org.neodatis.odb.impl.core.query.criteria.CriteriaQuery;
import org.neodatis.odb.impl.core.query.values.ValuesCriteriaQuery;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class main {
	private static Connection con;

	public static void main(String[] args) {
//PRIMERA PARTE DE XML Y NEODATIS
		// leerVentasDesdeXML();
		encontrarProductoConMayorCantidadDeVentas();
		listarTotalUnidadesVendidasPorTipo();
		consultaInventario();

// SEGUNDA PARTE DE NEODATIS Y SQL
		Conectar();
		//CrearTabla();
		//transferirArticulosASQLite();
		calcularVentasPorTipoSQLite();
		encontrarProductoConMayorVentaSQLite();
		calcularInventarioSql();
		Desconectar();

	}

//
	public static void leerVentasDesdeXML() {

		try {
			ODB odb = ODBFactory.open("NeodatisDB/ExamDB1.odb");
			File xmlFile = new File("xml/inventario.xml");
			DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
			DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
			Document doc = dBuilder.parse(xmlFile);
			doc.getDocumentElement().normalize();

			NodeList nList = doc.getElementsByTagName("articulo");

			for (int temp = 0; temp < nList.getLength(); temp++) {
				Node nNode = nList.item(temp);
				if (nNode.getNodeType() == Node.ELEMENT_NODE) {
					Element eElement = (Element) nNode;

					Articulo articulo = new Articulo();

					articulo.setFecha(eElement.getElementsByTagName("fecha").item(0).getTextContent());
					articulo.setProducto(eElement.getElementsByTagName("producto").item(0).getTextContent());
					articulo.setTipo(eElement.getElementsByTagName("tipo").item(0).getTextContent());

					articulo.setPrecio(
							Double.parseDouble(eElement.getElementsByTagName("precio").item(0).getTextContent()));

					articulo.setCantidad(
							Integer.parseInt(eElement.getElementsByTagName("cantidad").item(0).getTextContent()));
					articulo.setCosteTotal(
							Double.parseDouble(eElement.getElementsByTagName("precio").item(0).getTextContent()),
							Integer.parseInt(eElement.getElementsByTagName("cantidad").item(0).getTextContent()));
					odb.store(articulo);
				}
			}
			odb.close();
		} catch (Exception e) {
			e.printStackTrace();
		}

	}

	private static void encontrarProductoConMayorCantidadDeVentas() {
		ODB odb = null;
		try {
			odb = ODBFactory.open("NeodatisDB/ExamDB1.odb");
			Objects<Articulo> articulos = odb.getObjects(Articulo.class);
			Map<String, Integer> ventasPorProducto = new HashMap<>();

			// Se suma las ventas por producto
			while (articulos.hasNext()) {
				Articulo articulo = articulos.next();
				ventasPorProducto.put(articulo.getProducto(),
						ventasPorProducto.getOrDefault(articulo.getProducto(), 0) + articulo.getCantidad());
			}

			// Se encuentra el producto con la mayor cantidad de ventas
			String productoConMasVentas = null;
			int maxVentas = 0;
			for (Map.Entry<String, Integer> entry : ventasPorProducto.entrySet()) {
				if (entry.getValue() > maxVentas) {
					maxVentas = entry.getValue();
					productoConMasVentas = entry.getKey();
				}
			}

			// Se muestra el resultado
			if (productoConMasVentas != null) {
				System.out.println("\nEl producto con mayor cantidad de ventas en unidades es: " + productoConMasVentas
						+ " con " + maxVentas + " unidades.");
			} else {
				System.out.println("No se encontraron ventas.");
			}

		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			if (odb != null) {
				odb.close();
			}
		}
	}

	private static void listarTotalUnidadesVendidasPorTipo() {
		ODB odb = null;
		try {
			odb = ODBFactory.open("NeodatisDB/ExamDB1.odb");

			// Se crea una consulta que agrupa las ventas por color y suma las cantidades.
			IValuesQuery query = new ValuesCriteriaQuery(Articulo.class).field("tipo").sum("cantidad").groupBy("tipo");
			Values values = odb.getValues(query);

			System.out.println("\nTotal de unidades vendidas por tipo Neodatis:");
			while (values.hasNext()) {
				ObjectValues value = values.next();
				String tipo = (String) value.getByAlias("tipo");
				BigDecimal totalUnidades = (BigDecimal) value.getByAlias("cantidad");
				System.out.println("- tipo: " + tipo + ", Total Unidades: " + totalUnidades);
			}
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			if (odb != null) {
				odb.close();
			}
		}
	}

	private static void consultaInventario() {
		// Abre la conexión con la base de datos NeoDatis
		ODB odb = ODBFactory.open("NeodatisDB/ExamDB1.odb");

		// Crea la consulta para calcular el inventario total
		IValuesQuery query = new ValuesCriteriaQuery(Articulo.class).sum("costeTotal");

		// Ejecuta la consulta y obtén los resultados
		Values values = odb.getValues(query);

		// Obtiene el resultado de la consulta
		Object result = values.getFirst();

		// Muestra el resultado
		if (result != null) {
			System.out.println("\n " + result + " €");
		} else {
			System.out.println("No se encontraron resultados para la consulta.");
		}

		// Cierra la conexión con la base de datos
		odb.close();
	}

	// Desconectamos la base de datos.
	public static void Desconectar() {
		try {
			con.close();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	// Conectamos con la base de datos creada en la carpeta DB
	public static void Conectar() {
		try {
			Class.forName("org.sqlite.JDBC");
			con = DriverManager.getConnection("jdbc:sqlite:SQLiteDB\\ExamenDB.db");
		} catch (SQLException e) {
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	// Creamos la tabla Ventas
	private static void CrearTabla() {
		java.sql.Statement statement;
		try {
			statement = con.createStatement();
			statement.execute(
					"create table IF NOT EXISTS Articulos(fecha text, producto text, tipo text, precio double, cantidad integer, costeTotal double)");
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	// Transferimos los datos de la base de datos de neodatis a la base de datos de
	// SQLite
	public static void transferirArticulosASQLite() {
		ODB odb = null;
		try {
			// Se abre Neodatis DB y recuperar objetos Articulo
			odb = ODBFactory.open("NeodatisDB/ExamDB1.odb");
			Objects<Articulo> articulos = odb.getObjects(Articulo.class);

			// Preparar la sentencia SQL para insertar en SQLite
			String sql = "INSERT INTO Articulos (fecha, producto, tipo, precio, cantidad,costeTotal) VALUES (?, ?, ?, ?, ?,?)";
			PreparedStatement pstmt = con.prepareStatement(sql);

			// Se Inserta cada objeto Articulo en SQLite
			while (articulos.hasNext()) {
				Articulo articulo = articulos.next();
				pstmt.setString(1, articulo.getFecha());
				pstmt.setString(2, articulo.getProducto());
				pstmt.setString(3, articulo.getTipo());
				pstmt.setDouble(4, articulo.getPrecio());
				pstmt.setInt(5, articulo.getCantidad());
				pstmt.setDouble(6, articulo.getCosteTotal());
				pstmt.executeUpdate();
			}

			System.out.println("\nTransferencia completada con éxito.");

		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			if (odb != null) {
				odb.close();
			}
		}
	}
	
	 public static void encontrarProductoConMayorVentaSQLite() {
		    try {

		        // Se crea y ejecuta la consulta SQL para encontrar el producto con la mayor cantidad de unidades vendidas
		        String sql = "SELECT producto, SUM(cantidad) AS total_unidades FROM Articulos GROUP BY producto ORDER BY total_unidades DESC LIMIT 1";
		        Statement stmt = con.createStatement();
		        ResultSet rs = stmt.executeQuery(sql);

		        // Verificar si hay resultado y mostrar el producto con la mayor cantidad de unidades vendidas
		        if (rs.next()) {
		            String producto = rs.getString("producto");
		            int totalUnidades = rs.getInt("total_unidades");
		            System.out.println("\nEl producto con la mayor cantidad de ventas en unidades es: " + producto + " con " + totalUnidades + " unidades.");
		        } else {
		            System.out.println("\nNo se encontraron ventas de articulo.");
		        }

		    } catch (Exception e) {
		        e.printStackTrace();
		    } 
		}
	 public static void calcularVentasPorTipoSQLite() {
		    try {

		        // Crear y ejecutar la consulta SQL para sumar la columna cantidad agrupada por tipo
		        String sql = "SELECT tipo, SUM(cantidad) AS total_unidades_por_tipo FROM Articulos GROUP BY tipo";
		        Statement stmt = con.createStatement();
		        ResultSet rs = stmt.executeQuery(sql);

		        // Mostrar el total de unidades vendidas por cada color
		        System.out.println("\nVentas por tipo:");
		        while (rs.next()) {
		            String tipo = rs.getString("tipo");
		            int totalUnidades = rs.getInt("total_unidades_por_tipo");
		            System.out.println("- Tipo: " + tipo + ", Total Unidades: " + totalUnidades);
		        }

		    } catch (Exception e) {
		        e.printStackTrace();
		    } 
		}
	 public static void calcularInventarioSql() {
		    try {

		        // Crear y ejecutar la consulta SQL para sumar la columna cantidad agrupada por tipo
		        String sql = "SELECT SUM(costeTotal) AS total FROM Articulos GROUP BY costeTotal";
		        Statement stmt = con.createStatement();
		        ResultSet rs = stmt.executeQuery(sql);
		        double totalisimo = 0;
		        // Mostrar el total de unidades vendidas por cada color
		        System.out.println("\nVentas :");
		        while (rs.next()) {
		          
		            double total = rs.getDouble("total");
		            totalisimo += total;
		            //System.out.println("- Total: " + total);
		        }
		        System.out.println(totalisimo + "€");

		    } catch (Exception e) {
		        e.printStackTrace();
		    } 
		}
	 

}
