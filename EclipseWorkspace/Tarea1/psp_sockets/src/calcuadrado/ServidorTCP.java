package calcuadrado;
//ServidorTCP.java
import java.io.*;
import java.net.*; 

public class ServidorTCP {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// Primero indicamos la dirección IP local 
		try {
			System.out.println("LocalHost = " +InetAddress.getLocalHost().toString()); 
		} catch (UnknownHostException uhe)
		{
			System.err.println("No puedo saber la dirección IP local : " + uhe); 
		}
		
		// Abrimos un "Socket de Servidor" TCP en el puerto 1234.
		ServerSocket ss = null; 
		
		try {
			//abres el socket de servidor para escuchar en el puerto 1234
			ss = new ServerSocket(1234);  
		} catch (IOException ioe)
		{
			System.err.println("Error al abrir el socket de servidor : " + ioe);
			System.exit(-1);  
		}
		
		int entrada;
		int entrada2;
		
		//salia error y pedia inicializar
		long salida = 0;
		// Bucle infinito 
		while(true)
		 { 
			try
			 { 
				// Esperamos a que alguien se conecte a nuestroSocket
				 Socket sckt = ss.accept();
				 
				 
				 // Extraemos los Streams de entrada y de salida
				 DataInputStream dis = new
				 DataInputStream(sckt.getInputStream());
				 DataOutputStream dos = new DataOutputStream(sckt.getOutputStream());
				 
				 
				 // Podemos extraer información del socket
				 // Nº de puerto remoto
				 int puerto = sckt.getPort();
				 
				 // Dirección de Internet remota
				 InetAddress direcc = sckt.getInetAddress();
				 
				 // Leemos datos de la peticion
				 entrada = dis.readInt();
				 entrada2 = dis.readInt();
				 if(entrada == 1) {
				 // Calculamos resultado!!!!!!!!!!!!
				 salida = (long)entrada2*(long)entrada2;}
				 else {
					salida = calcularFactorial(entrada2);
					 }
				 // Escribimos el resultado
				 dos.writeLong(salida);
				 // Cerramos los streams
				 dis.close();
				 dos.close();
				 sckt.close();
				 //ss.close();
				 // Registramos en salida estandard
				 System.out.println( "Cliente = " + direcc + ":" + puerto
				 + "\tEntrada = " + entrada + "\tSalida = " +
				 salida ); 
			 }  catch(Exception e) {
				 System.err.println("Se ha producido la excepción : " +e);
			 }
		 }
		

	}
	 public static int calcularFactorial(int n) {
	        if (n < 0) {
	            throw new IllegalArgumentException("El factorial no está definido para números negativos");
	        }
	        
	        int factorial = 1;
	        for (int i = 1; i <= n; i++) {
	            factorial *= i;
	        }
	        
	        return factorial;
	    }

}
