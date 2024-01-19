import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

import javax.lang.model.element.Element;
import javax.swing.text.Document;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class Main {

	public static void main(String[] args) throws IOException,ClassNotFoundException {
		// TODO Auto-generated method stub
		
	
			
			
		
		
		
		
      try {
    	  
    	  
    	  
    	  
    	  Class.forName("org.sqlite.JDBC");
    	  Connection connection = DriverManager.getConnection("jdbc:sqlite:D://Sergio/test.db");
    	  
    	  
    	  //esto era para ejecutar consultas
    	  java.sql.Statement statement = connection.createStatement();
    	  
    	  statement.execute("CREATE table pedido(Cliente String ,numeroPedido int);");
    	  statement.execute("CREATE table articulos(numeroPedido int, cantidad int, Descripcion String);");
    	  
    	  ResultSet resultset = statement.executeQuery("INSERT INTO pedido values('paco', '1234')");
    	  
    	  //y con esto guardamos las consultas en una variable
    	  
    	  
    	  
    	  
    	  while (resultset.next())
    		  
    	  {
    	  System.out.println("ID: " + resultset.getString("campo1"));
    	  System.out.println("Cliente: "+ resultset.getString("campo2"));
    	  System.out.println();		
      }
    	
    	  connection.close();
    	  
      }
      
      
      catch(SQLException e) {
    	  
    	  e.printStackTrace();
      }
	}

	

}
