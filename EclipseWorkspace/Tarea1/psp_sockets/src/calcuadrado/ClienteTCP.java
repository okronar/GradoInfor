package calcuadrado;

//ClienteTCP.java
import java.io.*;
import java.net.*;
import java.util.Scanner; 

public class ClienteTCP {

	public static void main(String[] args) {
	/**
		Leemos el primer parámetro, donde debe ir la dirección
		IP del servidor
	*/
		 InetAddress direcc = null;
		 try
		 {
			 direcc = InetAddress.getByName(args[0]);
		 }
		 catch(UnknownHostException uhe)
		 {
			 System.err.println("Host no encontrado : " + uhe);
			 System.exit(-1);
		 }
		 
		// Puerto que hemos usado para el servidor
		 int puerto = 1234;
		// Para cada uno de los argumentos...
		
			 Socket sckt = null;
			 DataInputStream dis = null;
			 DataOutputStream dos = null; 
			 try {
				// Convertimos el texto en número
				 Scanner scanner = new Scanner(System.in);

			        // Menú de opciones
			       System.out.println("Seleccione una opción:");
			       System.out.println("1. Calcular el cuadrado de un número");
			       System.out.println("2. Factorial");
			       System.out.print("Opción: ");
			       int numero = scanner.nextInt();
			       System.out.println("Que numero?");
			       int numero2 = scanner.nextInt();
				 // Creamos el Socket
				 sckt = new Socket(direcc,puerto);
				 // Extraemos los streams de entrada y salida
				 dis = new
				DataInputStream(sckt.getInputStream());
				 dos = new
				DataOutputStream(sckt.getOutputStream());
				 // Lo escribimos
				 dos.writeInt(numero);
				 
				 // Leemos el resultado final
				 long resultado = dis.readLong();
				 // Indicamos en pantalla
				 System.out.println( "Solicitud = " + numero +"\tResultado = " +resultado );
				 // y cerramos los streams y el socket
				 dis.close();
				 dos.close(); 
			 }
			 catch(Exception e)
			 {
				 System.err.println("Se ha producido la excepción : " +e);
			 }
			 
			 
			 try
			 {
				 if (sckt!=null) sckt.close();
			 }
			 catch(IOException ioe)
			 {
				 System.err.println("Error al cerrar el socket :" + ioe);
			 } 
		 
		 
	}

}
