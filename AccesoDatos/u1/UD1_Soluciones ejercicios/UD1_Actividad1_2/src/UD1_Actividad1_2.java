/* Muestra en la consola el contenido de un fichero de texto
 * que se le pasa al programa como un par�metro.
 */


import java.io.*;

public class UD1_Actividad1_2 {
	  public static void main(String[] args)  {
	    
		if (args.length!=1) {
			System.out.println("HAY QUE INTRODUCIR UN ARGUMENTO....")	;
		}
		else
		{	
	      try {	
			String entrada=args[0]; 		
		    File fichero = new File(entrada); //"ejemplofichtexto.txt";
	    
	        FileReader fic = new FileReader(fichero);    
	        int i;
		    //pinta uno a uno los caracteres   
	        while ((i = fic.read()) != -1)
	           System.out.println((char) i);  // (char) convierte el valor entero i a car�cter
	        fic.close();
			}catch (IOException e) {
			   System.out.println("NO EXISTE EL FICHERO....");
			}
		}    
	  } //main
	} //clase
