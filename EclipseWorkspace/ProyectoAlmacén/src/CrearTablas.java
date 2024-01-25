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
        
       
        	//implementacion sqlite
      	  Class.forName("org.sqlite.JDBC");
      	  Connection connection = DriverManager.getConnection("jdbc:sqlite:D://Sergio/proyectoAlmacen.db");
      	  
      	  
      	  //esto era para ejecutar consultas
      	  java.sql.Statement statement = connection.createStatement();
      	  
      	  statement.execute("CREATE TABLE IF NOT EXISTS pedido(numero-cliente int ,numeroPedido int,fecha String);");
      	  statement.execute("CREATE TABLE IF NOT EXISTS articulos(numeroPedido int, codigo int, cantidad int);");
      	  
      	  
     }

    }


