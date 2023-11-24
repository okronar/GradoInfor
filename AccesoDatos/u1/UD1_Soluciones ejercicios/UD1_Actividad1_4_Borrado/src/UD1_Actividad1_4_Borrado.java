
import java.io.File;
import java.io.FileNotFoundException;
import java.io.RandomAccessFile;

import java.io.IOException;

public class UD1_Actividad1_4_Borrado {
	static File fichero = new File("AleatorioEmple.dat");

	public static void main(String[] args) throws IOException {
		if (args.length != 1) {
			System.out.println("ARGUMENTOS ERRONEOS");
			System.exit(0);
		}
		int id = 0;
		try {
			id = Integer.parseInt(args[0]); // recoger id de empleado a
											// consultar
		} catch (NumberFormatException n) {
			System.out.println("EL ID NO ES CORRECTO");
			System.exit(1);
		}

		// declara el fichero de acceso aleatorio
		RandomAccessFile file = new RandomAccessFile(fichero, "rw");

		int posicion;
		posicion = (id - 1) * 36;

		if (posicion >= file.length()) {
			System.out.println("REGISTRO INEXISTENTE");
			file.close();
			System.exit(0);
		}

		file.seek(posicion); // nos posicionamos en posicion
		id = file.readInt(); // obtengo id de empleado
		if (id <= 0) {
			System.out.println("REGISTRO INEXISTENTE");
			file.close();
			System.exit(0);
		}

		file.seek(posicion);
		int id2 = -1;
		file.writeInt(id2); // uso id para identificar empleado

		String datos = "* " + args[0] + " *";
		StringBuffer buffer = new StringBuffer(datos);
		buffer.setLength(10); // 10 caracteres para el apellido

		file.writeChars(buffer.toString());// insertar apellido
		file.writeInt(0); // insertar departamento
		file.writeDouble(0);// insertar salario

		System.out.println("REGISTRO ELIMINADO: " + id);

		file.close(); // cerrar fichero

		ListadoEliminados();

	}

	static void ListadoEliminados() throws IOException {
		RandomAccessFile file = new RandomAccessFile(fichero, "r");

		int id, dep, posicion;
		Double salario;
		char apellido[] = new char[10], aux;

		posicion = 0; // para situarnos al principio

		for (;;) { // recorro el fichero
			file.seek(posicion); // nos posicionamos en posicion
			id = file.readInt(); // obtengo id de empleado
			for (int i = 0; i < apellido.length; i++) {
				aux = file.readChar();// recorro uno a uno los caracteres del
										// apellido
				apellido[i] = aux; // los voy guardando en el array
			}
			String apellidoS = new String(apellido);// convierto a String el
													// array
			dep = file.readInt();// obtengo dep
			salario = file.readDouble(); // obtengo salario

			if (id == -1)
				System.out.println("id empleado eliminado: " + apellidoS);

			posicion = posicion + 36; // me posiciono para el sig empleado
			// Cada empleado ocupa 36 bytes (4+20+4+8)

			// Si he recorrido todos los bytes salgo del for
			if (file.getFilePointer() == file.length())
				break;

		} // fin bucle for
		file.close(); // cerrar fichero
	}

}
