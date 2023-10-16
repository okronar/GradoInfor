#include <stdio.h>
int suma(int numero1, int numero2){
    return numero1 + numero2;

}
void opcion1() {
    // Código para la opción 1
    int numero_devuelto = suma (5,4);
    printf("Has seleccionado la opción 1.\n");

    printf("El valor de la suma es : %d " , numero_devuelto);
}

void opcion2() {
    // Código para la opción 2
    printf("Has seleccionado la opción 2.\n");
}

void opcion3() {
    // Código para la opción 3
    printf("Has seleccionado la opción 3.\n");
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
