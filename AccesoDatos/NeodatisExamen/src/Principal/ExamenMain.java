package Principal;

import org.neodatis.odb.ODB;
import org.neodatis.odb.ODBFactory;
import org.neodatis.odb.ObjectValues;
import org.neodatis.odb.Values;
import org.neodatis.odb.core.query.IValuesQuery;
import org.neodatis.odb.impl.core.query.values.ValuesCriteriaQuery;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import java.io.File;
import java.math.BigDecimal;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.sql.SQLException;

import org.neodatis.odb.Objects;
import java.util.HashMap;
import java.util.Map;

public class ExamenMain {
	private static Connection con;

	public static void main(String[] args) {
		
		//leerVentasDesdeXML();
		calcularTotalUnidadesVendidasNeodatis();
		listarTotalUnidadesVendidasPorColor();
		encontrarProductoConMayorCantidadDeVentas();
		Conectar();
		CrearTabla();
		//transferirVentasASQLite();
		calcularTotalUnidadesVendidasSQLite();
		calcularVentasPorColorSQLite();
		encontrarProductoConMayorVentaSQLite();
		
		
	}
	
	public static void leerVentasDesdeXML() {
       
        try {
        	ODB odb = ODBFactory.open("NeodatisDB/ExamDB1.odb");
            File xmlFile = new File("xml/ventas.xml");
            DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
            Document doc = dBuilder.parse(xmlFile);
            doc.getDocumentElement().normalize();

            NodeList nList = doc.getElementsByTagName("venta");

            for (int temp = 0; temp < nList.getLength(); temp++) {
                Node nNode = nList.item(temp);
                if (nNode.getNodeType() == Node.ELEMENT_NODE) {
                    Element eElement = (Element) nNode;

                    Venta venta = new Venta();
                    venta.setFecha(eElement.getElementsByTagName("fecha").item(0).getTextContent());
                    venta.setProducto(eElement.getElementsByTagName("producto").item(0).getTextContent());
                    venta.setTalla(eElement.getElementsByTagName("talla").item(0).getTextContent());
                    venta.setColor(eElement.getElementsByTagName("color").item(0).getTextContent());
                    
                    venta.setPrecio(Integer.parseInt(eElement.getElementsByTagName("precio").item(0).getTextContent()));
                    venta.setCantidad(Integer.parseInt(eElement.getElementsByTagName("cantidad").item(0).getTextContent()));

                    odb.store(venta);
                }
            }
            odb.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        
    }
	
	private static void calcularTotalUnidadesVendidasNeodatis() {
	    ODB odb = null;
	    try {
	        odb = ODBFactory.open("NeodatisDB/ExamDB1.odb");
	        
	        // Se crea una consulta para sumar todas las cantidades de ventas.
	        IValuesQuery query = new ValuesCriteriaQuery(Venta.class)
	                .sum("cantidad");
	        Values values = odb.getValues(query);
	        
	        if (values.hasNext()) {
	            ObjectValues value = values.next();
	            // Obtiene el total de unidades vendidas.
	            BigDecimal totalUnidades = (BigDecimal) value.getByAlias("cantidad");
	            System.out.println("Total de unidades vendidas: " + totalUnidades.intValue());
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
	
	private static void listarTotalUnidadesVendidasPorColor() {
	    ODB odb = null;
	    try {
	        odb = ODBFactory.open("NeodatisDB/ExamDB1.odb");
	        
	        // Se crea una consulta que agrupa las ventas por color y suma las cantidades.
	        IValuesQuery query = new ValuesCriteriaQuery(Venta.class)
	                .field("color")
	                .sum("cantidad")
	                .groupBy("color");
	        Values values = odb.getValues(query);
	        
	        System.out.println("\nTotal de unidades vendidas por color Neodatis:");
	        while (values.hasNext()) {
	            ObjectValues value = values.next();
	            String color = (String) value.getByAlias("color");
	            BigDecimal totalUnidades = (BigDecimal) value.getByAlias("cantidad");
	            System.out.println("- Color: " + color + ", Total Unidades: " + totalUnidades);
	        }
	    } catch (Exception e) {
	        e.printStackTrace();
	    } finally {
	        if (odb != null) {
	            odb.close();
	        }
	    }
	}
	
	private static void encontrarProductoConMayorCantidadDeVentas() {
        ODB odb = null;
        try {
            odb = ODBFactory.open("NeodatisDB/ExamDB1.odb"); 
            Objects<Venta> ventas = odb.getObjects(Venta.class);
            Map<String, Integer> ventasPorProducto = new HashMap<>();

            // Se suma las ventas por producto
            while (ventas.hasNext()) {
                Venta venta = ventas.next();
                ventasPorProducto.put(venta.getProducto(), ventasPorProducto.getOrDefault(venta.getProducto(), 0) + venta.getCantidad());
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
                System.out.println("\nEl producto con mayor cantidad de ventas en unidades es: " + productoConMasVentas + " con " + maxVentas + " unidades.");
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
	
	// Desconectamos la base de datos.
		public static void Desconectar() {
			try {
				con.close();
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
		
		// Conectamos con la base de datos creada en la carpeta DB
		public static void Conectar()  {
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
				statement.execute("create table IF NOT EXISTS Ventas(fecha text, producto text, talla text, color text, precio integer, cantidad integer)");
			} catch (SQLException e) {
				e.printStackTrace();
			}		
		}
		
		// Transferimos los datos de la base de datos de neodatis a la base de datos de SQLite
		public static void transferirVentasASQLite() {
	        ODB odb = null;
	        try {
	            // Se abre Neodatis DB y recuperar objetos Venta
	            odb = ODBFactory.open("NeodatisDB/ExamDB1.odb");
	            Objects<Venta> ventas = odb.getObjects(Venta.class);

	            // Preparar la sentencia SQL para insertar en SQLite
	            String sql = "INSERT INTO Ventas (fecha, producto, talla, color, precio, cantidad) VALUES (?, ?, ?, ?, ?, ?)";
	            PreparedStatement pstmt = con.prepareStatement(sql);

	            //Se Inserta cada objeto Venta en SQLite
	            while (ventas.hasNext()) {
	                Venta venta = ventas.next();
	                pstmt.setString(1, venta.getFecha());
	                pstmt.setString(2, venta.getProducto());
	                pstmt.setString(3, venta.getTalla());
	                pstmt.setString(4, venta.getColor());
	                pstmt.setInt(5, venta.getPrecio());
	                pstmt.setInt(6, venta.getCantidad());
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
		
		 public static void calcularTotalUnidadesVendidasSQLite() {
		        try {

		            // Se crea y ejecuta la consulta SQL para sumar la columna cantidad
		            String sql = "SELECT SUM(cantidad) AS total_unidades FROM Ventas";
		            Statement stmt = con.createStatement();
		            ResultSet rs = stmt.executeQuery(sql);

		            // Se verifica si hay resultado y mostrar el total de unidades vendidas
		            if (rs.next()) {
		                int totalUnidades = rs.getInt("total_unidades");
		                System.out.println("\nTotal de unidades vendidas: " + totalUnidades);
		            } else {
		                System.out.println("\nNo se pudieron calcular las unidades vendidas.");
		            }

		        } catch (Exception e) {
		            e.printStackTrace();
		        } 
		 }
		 
		 public static void calcularVentasPorColorSQLite() {
			    try {

			        // Crear y ejecutar la consulta SQL para sumar la columna cantidad agrupada por color
			        String sql = "SELECT color, SUM(cantidad) AS total_unidades_por_color FROM Ventas GROUP BY color";
			        Statement stmt = con.createStatement();
			        ResultSet rs = stmt.executeQuery(sql);

			        // Mostrar el total de unidades vendidas por cada color
			        System.out.println("\nVentas por color:");
			        while (rs.next()) {
			            String color = rs.getString("color");
			            int totalUnidades = rs.getInt("total_unidades_por_color");
			            System.out.println("- Color: " + color + ", Total Unidades: " + totalUnidades);
			        }

			    } catch (Exception e) {
			        e.printStackTrace();
			    } 
			}
		 
		 public static void encontrarProductoConMayorVentaSQLite() {
			    try {

			        // Se crea y ejecuta la consulta SQL para encontrar el producto con la mayor cantidad de unidades vendidas
			        String sql = "SELECT producto, SUM(cantidad) AS total_unidades FROM Ventas GROUP BY producto ORDER BY total_unidades DESC LIMIT 1";
			        Statement stmt = con.createStatement();
			        ResultSet rs = stmt.executeQuery(sql);

			        // Verificar si hay resultado y mostrar el producto con la mayor cantidad de unidades vendidas
			        if (rs.next()) {
			            String producto = rs.getString("producto");
			            int totalUnidades = rs.getInt("total_unidades");
			            System.out.println("\nEl producto con la mayor cantidad de ventas en unidades es: " + producto + " con " + totalUnidades + " unidades.");
			        } else {
			            System.out.println("\nNo se encontraron ventas.");
			        }

			    } catch (Exception e) {
			        e.printStackTrace();
			    } 
			}
		 

	
	
	
	

}
