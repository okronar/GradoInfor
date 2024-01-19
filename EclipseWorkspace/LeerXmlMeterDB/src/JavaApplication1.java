import java.io.IOException;
import java.sql.Connection;
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
    public static void main(String[] args) throws IOException,ClassNotFoundException{
        DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
        try {
        	//implementacion sqlite
      	  Class.forName("org.sqlite.JDBC");
      	  Connection connection = DriverManager.getConnection("jdbc:sqlite:D://Sergio/test.db");
      	  
      	  
      	  //esto era para ejecutar consultas
      	  java.sql.Statement statement = connection.createStatement();
      	  
      	  //statement.execute("CREATE table pedido(Cliente String ,numeroPedido int);");
      	  //statement.execute("CREATE table articulos(numeroPedido int, cantidad int, Descripcion String);");
      	  
      	  
        	
        	
            DocumentBuilder builder = factory.newDocumentBuilder();
            Document document = builder.parse(new File("XMLEjer1.xml"));
            document.getDocumentElement().normalize();
            System.out.println("Elemento raiz: " + document.getDocumentElement().getNodeName());

            //lista con todos los nodos pedidos
            NodeList pedidos = document.getElementsByTagName("pedido");
            System.out.println("Nodos pedido a recorrer : " + pedidos.getLength());

            //recorrer la lista de pedidos
            for (int i = 0; i < pedidos.getLength(); i++) {
                Node pedi = pedidos.item(i);//obtiene un nodo pedido
                System.out.println("Pedido " + (i + 1));
                
                if (pedi.getNodeType() == Node.ELEMENT_NODE) {//tipo de nodo 
                    //obtener los elementos del nodo 
                    Element elemento = (Element) pedi;
                    
                    String nombre = getNodo("nombre", elemento);
                    String numPedidoString = getNodo("numero_pedido", elemento);
                    int numeroPedido = Integer.parseInt(numPedidoString);
                    
                    statement.execute("INSERT INTO pedido values('"+nombre+"','"+numeroPedido+"')");
                    
                    System.out.println("  Nombre:" + getNodo("nombre", elemento));
                    System.out.println("  Numero de pedido:" + getNodo("numero_pedido", elemento));

                    //lista con todos los nodos articulos
                    NodeList articulos = elemento.getElementsByTagName("articulo");
                   
                    for (int j = 0; j < articulos.getLength(); j++) {
                        Node articulo = articulos.item(j); // Obtener un nodo articulo
                        System.out.println("  Artículo " + (j + 1));
                        
                        if (articulo.getNodeType()== Node.ELEMENT_NODE) {
                            Element elementoArticulo = (Element) articulo;
                            
                            String descripcion = elementoArticulo.getAttribute("descripcion");
                            int cantidad = Integer.parseInt(elementoArticulo.getAttribute("cantidad"));
                            statement.execute("INSERT INTO articulos values('"+numeroPedido+"','"+cantidad+"','\"+Descripcion+\"')");
                            System.out.println("    Descripcion: " + elementoArticulo.getAttribute("descripcion"));
                            System.out.println("    Cantidad: "+ elementoArticulo.getAttribute("cantidad"));                           
                            
                        }
                    }
                }

            }

        } catch (Exception e) {
            e.printStackTrace();
        }

    }

    private static String getNodo(String etiqueta, Element elem) {
        NodeList nodos = elem.getElementsByTagName(etiqueta).item(0).getChildNodes();
        Node nodo = (Node) nodos.item(0);
        return nodo.getNodeValue();
    }
    

}

