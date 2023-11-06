#include <stdio.h>
#include <stlib.h>
void main(){

printf("Ejemplo de uso de system():");
printf("\n\tListado del directorio actual y envio a un fichero:");
printf("%d",system("ls > ficsalida"));
printf("\n\tAbrimos con el nano el fichero ...");
printf("%d",system("nano ficsalida"));
printf("\n\tEste comando es erróneo: %d",system("ged"));
printf("\nFin de programa........\n");




}