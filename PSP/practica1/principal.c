#include <stdio.h>
#define PI 3.14


void opcion1()
{
    // Código para la opción 1
    printf("Has seleccionado la opción 1.\n");
    double total;
    double radio;
    printf("Calculemos el area de un circulo, pasame el radio:");
    scanf("%d", &opcion);
    total = PI * (radio*radio);
    printf("El area de tu circulo es ");
    printf(total);
   
}

void opcion2()
{

    // Código para la opción 2
    printf("Has seleccionado la opción 2.\n");

    
}

void opcion3()
{
    // Código para la opción 3
    printf("Has seleccionado la opción 3.\n");
}
void opcion4()
{
    // Código para la opción 4
    printf("Has seleccionado la opción 3.\n");
}
void opcion5()
{
    // Código para la opción 5
    printf("Has seleccionado la opción 3.\n");
}
void opcion6()
{
    // Código para la opción 6
    printf("Has seleccionado la opción 3.\n");
}
void opcion7()
{
    // Código para la opción 7
    printf("Has seleccionado la opción 3.\n");
}
void opcion8()
{
    // Código para la opción 8
    printf("Has seleccionado la opción 3.\n");
}
void opcion9()
{
    // Código para la opción 9
    printf("Has seleccionado la opción 3.\n");
}
void opcion10()
{
    // Código para la opción 10
    printf("Has seleccionado la opción 3.\n");
}

int main()
{
    int opcion;

    do
    {
        // Mostrar el menú
        printf("Menú:\n");
        printf("1. Opción 1\n");
        printf("2. Opción 2\n");
        printf("3. Opción 3\n");
        printf("3. Opción 4\n");
        printf("3. Opción 5\n");
        printf("3. Opción 6\n");
        printf("3. Opción 7\n");
        printf("3. Opción 8\n");
        printf("3. Opción 9\n");
        printf("3. Opción 10\n");

        printf("0. Salir\n");
        printf("Selecciona una opción: ");
        scanf("%d", &opcion);

        // Procesar la selección del usuario
        switch (opcion)
        {
        case 1:
            opcion1();
            break;
        case 2:
            opcion2();
            break;
        case 3:
            opcion3();
            break;
        case 4:
            opcion4();
            break;
        case 5:
            opcion5();
            break;
        case 6:
            opcion6();
            break;
        case 7:
            opcion7();
            break;
        case 8:
            opcion8();
            break;
        case 9:
            opcion9();
            break;
        case 10:
            opcion10();
            break;

        case 0:
            printf("Saliendo del programa. ¡Hasta luego!\n");
            break;
        default:
            printf("Opción inválida. Por favor, selecciona una opción válida.\n");
            break;
        }
    } while (opcion != 0);

    return 0;
}