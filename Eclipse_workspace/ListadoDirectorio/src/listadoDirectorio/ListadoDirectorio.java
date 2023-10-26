//el paquete del que sale
package listadoDirectorio;
// se importa de la libreria de java 
import java.io.File;
//la clase 
public class ListadoDirectorio {
//el metodo main que hace la clase ejecutable, se le pueden pasar argumentos en forma de strings 
	public static void main(String[] args) { 
		// variable String con un . esto indica que se refiere a la misma carpeta
		String ruta=".";
        //aqui indica que, si se le han pasado parametros, se quedara con el primero con lo cual
        //se le puede pasar el nombre de un fichero o carpeta diferente al que se esta ejecutando 
        if(args.length>=1) ruta=args[0];
        // creamos el objeto fichero con el parametro que se le haya dado o . sino hay
        File fich=new File(ruta); 
        // condicional negativo es decir, si NO existe se ejecuta el println
        
        if(!fich.exists()) {
        	// este metodo saca por pantalla lo que hay entre parentesis
            System.out.println("No existe el fichero o directorio ("+ruta+").");
        }
        //sino pasa la condicion de arriba se ejecutara esto 
        else {
        	
        	//con el metodo de la clase file .isfile deduce si se trata de un fichero 
            if(fich.isFile()) {
            	//si lo es, lo imprime como antes
                System.out.println(ruta+" es un fichero.");
            }
            //sino es un fichero, tiene que ser un directorio porque sino no existe por la linea 19
            else {
            	//entonces te imprime el directorio
                System.out.println(ruta+" es un directorio. Contenidos: ");
                
                //creamos un array de objetos File para luego ir recorriendolo
                File[] ficheros=fich.listFiles(); // Ojo, ficheros o directorios
                //esto es un for each, dice por cada File f en el array que acabamos de crear
                for(File f : ficheros) {
                	//hace lo mismo de arriba pero de otra forma expresado, esto es un operador ternario esto asigna a una nueva variable
                //	el valor de / si es un directorio, el valor _ si es un fichero o ? si se ha colado algo
                    String textoDescr=f.isDirectory() ? "/" : 
                    	f.isFile() ? "_" : "?";
                        //despues printea el simbolo y le añade el nombre del file en sí    	
                    System.out.println("("+textoDescr+") "+f.getName());
                }
            }
        }
    }//se acaba el programa
}
