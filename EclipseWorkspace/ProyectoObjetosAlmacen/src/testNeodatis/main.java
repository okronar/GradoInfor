package testNeodatis;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Scanner;

import org.neodatis.odb.*;

public class main {

	public static void main(String[] args) {

		
		
		System.out.println("elige opcion");
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


