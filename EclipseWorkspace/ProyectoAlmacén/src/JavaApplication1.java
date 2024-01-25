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
    public static void main(String[] args) throws IOException,ClassNotFoundException{
    	
    	
        DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
        try {
        	//implementacion sqlite
      	  Class.forName("org.sqlite.JDBC");
      	  Connection connection = DriverManager.getConnection("jdbc:sqlite:D://Sergio/proyectoAlmacen.db");
      	  //llamo a la clase para crear
      	  CrearTablas.Tablas();
      	  
      	  //esto era para ejecutar consultas
      	  java.sql.Statement statement = connection.createStatement();
      	  
      	         	
        	
            DocumentBuilder builder = factory.newDocumentBuilder();
            Document document = builder.parse(new File("Pedidos_Tiendas.xml"));
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
                    
                    
                    String numClienteString = getNodo("numero_pedido", elemento);
                    int numClienteInt = Integer.parseInt(numClienteString);
                    String numPedidoString = getNodo("numero_pedido", elemento);
                    int numPedidoInt = Integer.parseInt(numPedidoString);
                    String fecha = getNodo("fecha", elemento);
                    
                    statement.execute("INSERT INTO pedido values('"+numClienteString+"','"+numPedidoString+"','"+fecha+"')");
                    
                    System.out.println("  Numero de cliente:" + getNodo("numero_cliente", elemento));
                    System.out.println("  Numero de pedido:" + getNodo("numero_pedido", elemento));

                    //lista con todos los nodos articulos
                    NodeList articulos = elemento.getElementsByTagName("articulo");
                   
                    for (int j = 0; j < articulos.getLength(); j++) {
                        Node articulo = articulos.item(j); // Obtener un nodo articulo
                        System.out.println("  Artículo " + (j + 1));
                        
                        if (articulo.getNodeType()== Node.ELEMENT_NODE) {
                            Element elementoArticulo = (Element) articulo;
                            
                            String codigoString = getNodo("codigo", elementoArticulo);
                            int codigoint = Integer.parseInt(codigoString);
                            String cantidadString = getNodo("cantidad", elementoArticulo);
                            int cantidadInt = Integer.parseInt(cantidadString);
                            
                           statement.execute("INSERT INTO articulos values('"+numPedidoString+"','"+codigoString+"','"+cantidadString+"')");
                           System.out.println("  Numero de cliente:" + getNodo("numero_pedido", elemento));
                           System.out.println("  Codigo:" + getNodo("codigo", elemento));
                           System.out.println("  Cantidad:" + getNodo("cantidad", elemento));
                           
                            
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

