import java.io.File;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class CrearTablas {

	public static void Tablas() throws ClassNotFoundException, SQLException {

		// implementacion sqlite
		Class.forName("org.sqlite.JDBC");
		Connection connection = DriverManager.getConnection("jdbc:sqlite:D://Sergio/proyectoAlmacen.db");

		// esto era para ejecutar consultas
		java.sql.Statement statement = connection.createStatement();

		statement.execute("CREATE TABLE IF NOT EXISTS pedido(numeroCliente String ,numeroPedido String,fecha String);");
		statement.execute("CREATE TABLE IF NOT EXISTS articulosPedido(numeroPedido String, codigo String, cantidad String);");
		statement.execute("CREATE TABLE IF NOT EXISTS clientes(numeroCliente String,nombre String, telefono String, direccion String);");
		statement.execute("CREATE TABLE IF NOT EXISTS articulosStock(descripcion String, codigo String, stock String);");
		
		/*
		statement.execute("INSERT INTO clientes VALUES ('1234567890', 'paco', '555-1111', 'montaña')");
		statement.execute("INSERT INTO clientes VALUES ('9876543210', 'pepe', '555-2222', 'ciudad')");
		statement.execute("INSERT INTO clientes VALUES ('1234567891', 'manuel', '555-3333', 'pueblo')");
		statement.execute("INSERT INTO clientes VALUES ('1234567892', 'manuela2', '555-4444', 'playa')");
		statement.execute("INSERT INTO clientes VALUES ('1234567893', 'satan', '555-5555', 'torre')");
		
		statement.execute("INSERT INTO articulosStock VALUES ('Pelota', '123456', '10')");
		statement.execute("INSERT INTO articulosStock VALUES ('Raqueta', '234567', '20')");
		statement.execute("INSERT INTO articulosStock VALUES ('Guantes', '345678', '30')");
		statement.execute("INSERT INTO articulosStock VALUES ('Red', '456789', '40')");
		statement.execute("INSERT INTO articulosStock VALUES ('Conos', '567890', '50')");
		statement.execute("INSERT INTO articulosStock VALUES ('Silbato', '678901', '60')");
		statement.execute("INSERT INTO articulosStock VALUES ('Pantalón', '789012', '70')");
		statement.execute("INSERT INTO articulosStock VALUES ('Camiseta', '890123', '80')");
		statement.execute("INSERT INTO articulosStock VALUES ('Gorra', '123457', '90')");
		statement.execute("INSERT INTO articulosStock VALUES ('Calcetines', '234568', '100')");
		statement.execute("INSERT INTO articulosStock VALUES ('Mallas', '901234', '110')");
		statement.execute("INSERT INTO articulosStock VALUES ('Zapatillas', '12345', '120')"); */



		connection.close();
	}

	public static void borrar() throws ClassNotFoundException, SQLException {
		// implementacion sqlite
		Class.forName("org.sqlite.JDBC");
		Connection connection = DriverManager.getConnection("jdbc:sqlite:D://Sergio/proyectoAlmacen.db");

		java.sql.Statement statement = connection.createStatement();
		statement.execute("DROP TABLE IF EXISTS pedido");
		statement.execute("DROP TABLE IF EXISTS articulosPedido");
		//statement.execute("DROP TABLE IF EXISTS clientes");
		//statement.execute("DROP TABLE IF EXISTS articulosStock");

	}

}
