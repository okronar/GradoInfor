#include <stdio.h>
#define ATAULFO 500
const int VERDADERO =1;
const int FALSO = 0;

int funcion_devolver(int lo_que_entre){
int lo_que_sale;
return lo_que_sale=lo_que_entre;

}
void subprograma_no_devolvible(int lo_que_entra){

    int lo_que_se_hace = lo_que_entra+1;
    printf("Hago lo que quiero con lo que entra: \n");

}
int suma(int numero1, int numero2){
    return numero1 + numero2;

}
int resta(int num1, int num2){
        return num1 - num2;
}
void opcion1() {
    // Código para la opción 1
    int numero_devuelto = suma (5,4);
    printf("Has seleccionado la opción 1.\n");

    printf("El valor de la suma es : %d " , numero_devuelto);
}

void opcion2() {


    // Código para la opción 2
        int numero_devueltoResta = resta(6,5);
    printf("Has seleccionado la opción 2.\n");
        printf("el valor de la resta es : %d ", numero_devueltoResta);

}

void opcion3() {
    // Código para la opción 3
        int superando_a_ataulfo;
    printf("Has seleccionado la opción 3.\n");
        superando_a_ataulfo = ATAULFO*ATAULFO;
printf("el valor de Ataulfo al cuadrado es : %d",superando_a_ataulfo );

}

int main() {
    int opcion;

    do {
        // Mostrar el menú
        printf("Menú:\n");
        printf("1. Opción 1\n");
        printf("2. Opción 2\n");
        printf("3. Opción 3\n");
        printf("0. Salir\n");
        printf("Selecciona una opción: ");
        scanf("%d", &opcion);
         // Procesar la selección del usuario
        switch(opcion) {
            case 1:
                opcion1();
                break;
            case 2:
                opcion2();
                break;
            case 3:
                opcion3();
                break;
            case 0:
                printf("Saliendo del programa. ¡Hasta luego!\n");
                break;
            default:
                printf("Opción inválida. Por favor, selecciona una opción válida.\n");
                break;
        }
    } while(opcion != 0);

    return 0;
}