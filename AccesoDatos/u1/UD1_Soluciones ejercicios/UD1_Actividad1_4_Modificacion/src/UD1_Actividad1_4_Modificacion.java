
import java.io.EOFException;
import java.io.File;
import java.io.IOException;
import java.io.RandomAccessFile;

public class UD1_Actividad1_4_Modificacion {

	public static void main(String[] args) throws IOException {

		if (args.length != 2) {
			System.out.println("HAY QUE INTRODUCIR DOS ARGUMENTOS....");
		} else {
			String num = args[0]; // numero empleado
			String importe = args[1]; // importe
			int nemp = 0;
			Double salar = 0.0;
			try {
				nemp = Integer.parseInt(num);// paso a entero
				salar = Double.parseDouble(importe);
			} catch (NumberFormatException n) {
				System.out.println("La entrada tiene queser numerica");
				System.exit(2);
			}

			if (nemp <= 0 || salar <= 0) {
				System.out
						.println("EL IMPORTE Y EL NUM EMPLEADO DEBEN SER > 0");
			} else {
				File fichero = new File("AleatorioEmple.dat");
				RandomAccessFile file = new RandomAccessFile(fichero, "rw");

				int posicion = (nemp - 1) * 36;
				char ape[] = new char[10], aux;
				int x;

				file.seek(posicion);// ME POSICIONO PARA LEER EL APELLIDO
				try {
				x = file.readInt();// leo id
				if (x ==nemp) {
				for (int i = 0; i < ape.length; i++) {
					aux = file.readChar();
					ape[i] = aux;
				}
				String apellidoS = new String(ape);// obtengo apellido
				x = file.readInt();// leo dep
				Double salarioactual = file.readDouble(); // leo salario

				Double salarionuevo = salarioactual + salar; // calculo el nuevo
				System.out.println("APELLIDO :" + apellidoS.trim());
				System.out.println("SALARIO ANTIGUO :" + salarioactual);
				System.out.println("SALARIO NUEVO :" + salarionuevo);

				posicion = posicion + 4 + 20 + 4;// avanzo BYTES
				file.seek(posicion);// ME POSICIONO EN EL SALARIO
				file.writeDouble(salarionuevo);// modif salario
				}
				else 
					System.out.println("EL REGISTRO A MODIFICAR NO EXISTE - hueco");									
				}
				catch(EOFException e) {
					System.out.println("EL REGISTRO A MODIFICAR NO EXISTE");
				}
				file.close();
			}

		}// else

	}// main
}// clase
