package testNeodatis;

import java.math.BigInteger;
import java.util.Scanner;

import org.neodatis.odb.*;
import org.neodatis.odb.core.query.IValuesQuery;
import org.neodatis.odb.core.query.criteria.ICriterion;
import org.neodatis.odb.core.query.criteria.Where;
import org.neodatis.odb.impl.core.query.criteria.CriteriaQuery;
import org.neodatis.odb.impl.core.query.values.ValuesCriteriaQuery;

public class main {

	public static void main(String[] args) {

		System.out.println("elije opcion");
		Scanner scanner = new Scanner(System.in);

		int opcion = scanner.nextInt();

		switch (opcion) {

		case 1:

			// TODO Auto-generated method stub
			Sujeto s1 = new Sujeto("Maria", 23, "Madrid");
			Sujeto s2 = new Sujeto("Juan", 26, "Madrid");
			Sujeto s3 = new Sujeto("Lucia", 28, "Zaragoza");
			Sujeto s4 = new Sujeto("Marcos", 20, "Zaragoza");
			ODB odb = ODBFactory.open("D:/Sergio/Base_datos_OO/tutorial.odb");
			odb.store(s1);
			odb.store(s2);
			odb.store(s3);
			odb.store(s4);
			odb.close();
			break;

		case 2:

			// Listar objetos de la base de datos
			ODB odb2 = ODBFactory.open("D:/Sergio/Base_datos_OO/tutorial.odb");
			Objects<Sujeto> objects = odb2.getObjects(Sujeto.class);
			while (objects.hasNext()) {
				Sujeto sujeto_actual2 = objects.next();
				System.out.println("\t: " + sujeto_actual2.getName() + " " + sujeto_actual2.getEdad() + " "
						+ sujeto_actual2.getCiudad());
			}
			odb2.close();
			break;

		case 3:
			// Seleccionar objetos
			ODB odb3 = ODBFactory.open("D:/Sergio/Base_datos_OO/tutorial.odb");
			ICriterion criterio = Where.equal("edad", 23);
			CriteriaQuery query = new CriteriaQuery(Sujeto.class, criterio);
			Objects<Sujeto> objects3 = odb3.getObjects(query);
			while (objects3.hasNext()) {
				Sujeto sujeto_actual3 = objects3.next();
				System.out.println("\t: " + sujeto_actual3.getName() + " " + sujeto_actual3.getEdad() + " "
						+ sujeto_actual3.getCiudad());

			}
			odb3.close();
			break;

		case 4:
			// Eliminar objetos
			ODB odb4 = ODBFactory.open("D:/Sergio/Base_datos_OO/tutorial.odb");
			ICriterion criterio4 = Where.gt("edad", 1);
			CriteriaQuery query4 = new CriteriaQuery(Sujeto.class, criterio4);
			Objects<Sujeto> objects4 = odb4.getObjects(query4);
			while (objects4.hasNext()) {
				Sujeto sujeto_actual4 = objects4.next();
				System.out.println("\t: " + sujeto_actual4.getName() + " " + sujeto_actual4.getEdad() + " <--Elimiado");
				odb4.delete(sujeto_actual4);
			}
			odb4.close();
			break;

		case 5:

			// Modificar objetos
			ODB odb5 = ODBFactory.open("D:/Sergio/Base_datos_OO/tutorial.odb");
			ICriterion criterio5 = Where.gt("edad", 2);
			CriteriaQuery query5 = new CriteriaQuery(Sujeto.class, criterio5);
			Objects<Sujeto> objects5 = odb5.getObjects(query5);
			while (objects5.hasNext()) {
				Sujeto sujeto_actual5 = objects5.next();
				System.out.println(
						"\t: " + sujeto_actual5.getName() + " " + sujeto_actual5.getEdad() + " <--Ciudad Cambiada");
				sujeto_actual5.setCiudad("Palencia");
				odb5.store(sujeto_actual5);
				odb5.commit();
			}
			odb5.close();
			break;

		case 6:

			// Agregados
			ODB odb6 = ODBFactory.open("D:/Sergio/Base_datos_OO/tutorial.odb");
			IValuesQuery valuesQuery6 = new ValuesCriteriaQuery(Sujeto.class).count("nombre");
			Values values6 = odb6.getValues(valuesQuery6);
			ObjectValues objectValues6 = values6.nextValues();
			BigInteger count6 = (BigInteger) objectValues6.getByAlias("nombre");
			System.out.println("NÃºmero de Jugadores: " + count6.intValue());
			odb6.close();
			break;
		case 7:
			// Agregados con selección
			ODB odb7 = ODBFactory.open("D:/Sergio/Base_datos_OO/tutorial.odb");
			IValuesQuery valuesQuery7 = new ValuesCriteriaQuery(Sujeto.class, Where.gt("edad", 21)).count("nombre")
					.field("ciudad").groupBy("ciudad");
			Values values7 = odb7.getValues(valuesQuery7);
			while (values7.hasNext()) {
				ObjectValues objectValues7 = (ObjectValues) values7.next();
				System.out.println(objectValues7.getByAlias("ciudad") + " ---> " + objectValues7.getByAlias("nombre"));
			}
			odb7.close();
			break;

		case 8:
			// Agrupados
			ODB odb8 = ODBFactory.open("D:/Sergio/Base_datos_OO/tutorial.odb");
			IValuesQuery valuesQuery8 = new ValuesCriteriaQuery(Sujeto.class, Where.gt("edad", 1)).avg("edad")
					.field("ciudad").groupBy("ciudad");
			Values values8 = odb8.getValues(valuesQuery8);
			while (values8.hasNext()) {
				ObjectValues objectValues8 = (ObjectValues) values8.next();
				System.out.println(objectValues8.getByAlias("ciudad") + " ---> " + objectValues8.getByAlias("edad"));
			}
			odb8.close();
			break;

		default:
			break;

		}

	}

}
