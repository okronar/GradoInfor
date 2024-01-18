import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

public class Main {

	public static void main(String[] args) throws IOException,ClassNotFoundException {
		// TODO Auto-generated method stub
      try {
    	  
    	  Class.forName("org.sqlite.JDBC");
    	  Connection connection = DriverManager.getConnection("jdbc:sqlite:D://Sergio/test.db");
    	  
    	  
    	  //esto era para ejecutar consultas
    	  java.sql.Statement statement = connection.createStatement();
    	  
    	  statement.execute("CREATE table tabla3(campo5 int,campo6 int);");
    	  
    	  //y con esto guardamos las consultas en una variable
    	  ResultSet resultset = statement.executeQuery("SELECT * FROM tabla1");
    	  
    	  
    	  
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
