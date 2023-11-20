#include <stdio.h>
#include <stdbool.h>
#include <math.h>
#include <unistd.h>      
#include <stdlib.h>
#include <sys/types.h>
#define PI 3.14

void sacarArea();                                    // le pasas el radio y sacas el area
void opcion1();                                      // llama a la de arriba
bool esPrimo(int numero);                            // comprueba si es primo el numero que se le pasa
void opcion2();                                      // le pasa los numeros a la de arriba
void fibonacci(int n);                               // Desarrolla un programa en c que imprima los primeros N (que pases en la opcion3)términos de la secuencia de Fibonacci
void opcion3();                                      // Solicita al usuario el número de términos que desea imprimir
double calcularPotencia(double base, int exponente); // se calcula la potencia con la base y exponente que pedira en la opcion 4
void opcion4();                                      // solicita los datos
double sumar(double a, double b);                    // suma
double restar(double a, double b);                   // resta
double dividir(double a, double b);                  // division
double multiplicar(double a, double b);              // multiplicacion
void opcion5();                                      // realiza el switch y dependiendo el input se usa una funcion u otra
long calcularFactorial(long n);                      // pasas un numero y si no es 0 o 1 calcula el factorial
void opcion6();                                      // pide el numero de  calcularFactorial()
long raizCuadrada(long num);                     // ejecuta el metodo sqrt despues de hacer una comprobacion basiquilla
void opcion7();                                      // simplemente pasa el metodo raiz cuadrada y lo printea
void opcion8();                                      // hace un system que permite al usuario escribir alguna cosilla
void nacimiento();                                   // se ejecuta un metodo fork, si todo sale bien nacerá un proceso nuevo y el padre estará contento, sino no se dará a luz.
void opcion9();                                      // llama al metodo nacimiento();
void opcion10();                                     // el genial y dificil holamundo

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
        printf("4. Opción 4\n");
        printf("5. Opción 5\n");
        printf("6. Opción 6\n");
        printf("7. Opción 7\n");
        printf("8. Opción 8\n");
        printf("9. Opción 9\n");
        printf("10. Opción 10\n");

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
void sacarArea()
{

    printf("Has seleccionado la opción 1.\n");
    double total;
    double radio;
    printf("Calculemos el area de un circulo, pasame el radio:");
    scanf("%lf", &radio);
    fflush(stdin);
    total = PI * (radio * radio);
    printf("El area de tu circulo es  \n");
    printf("%lf", total);
}
void opcion1()
{
    sacarArea();
}

bool esPrimo(int numero)
{
    if (numero <= 1)
    {
        return false;
    }
    for (int i = 2; i * i <= numero; i++)
    {
        if (numero % i == 0)
        {
            return false;
        }
    }
    return true;
}

void opcion2()
{

    int num;

    printf("Ingrese un número para ver si es primo: ");
    scanf("%d", &num);

    if (esPrimo(num))
    {
        printf("%d es un número primo.\n", num);
    }
    else
    {
        printf("%d no es un número primo.\n", num);
    }
}

void fibonacci(int n)
{
    int a = 0, b = 1, c;

    printf("Los primeros %d términos de la secuencia de Fibonacci son:\n", n);
    printf("%d %d ", a, b); // Print the first two terms (0 and 1)

    for (int i = 2; i < n; i++)
    {
        c = a + b;
        printf("%d ", c);
        a = b;
        b = c;
    }
    printf("\n");
}

void opcion3()
{
    int numero;

    printf("Ingrese el número de términos de la secuencia de Fibonacci a imprimir: ");
    scanf("%d", &numero);
    fibonacci(numero);
}
double calcularPotencia(double base, int exponente)
{
    double resultado = 1.0;

    for (int i = 0; i < exponente; i++)
    {
        resultado *= base;
    }

    return resultado;
}

void opcion4()
{
    double base, resultado;
    int exponente;

    // Solicitar al usuario que ingrese la base y el exponente
    printf("Ingrese la base: ");
    scanf("%lf", &base);

    printf("Ingrese el exponente (entero no negativo): ");
    scanf("%d", &exponente);

    resultado = calcularPotencia(base, exponente);
    printf("el resultado es %lf \n", resultado);
}
double sumar(double a, double b)
{
    return a + b;
}

double restar(double a, double b)
{
    return a - b;
}

double multiplicar(double a, double b)
{
    return a * b;
}

double dividir(double a, double b)
{

    if (b != 0)
    {
        return a / b;
    }
    else
    {
        printf("Error: No se puede dividir por cero.\n");
        return 0.0;
    }
}

void opcion5()
{
    double num1, num2;
    char operador;

    printf("Ingrese el primer número: ");
    scanf("%lf", &num1);

    printf("Ingrese el operador (+, -, *, /): ");
    scanf(" %c", &operador);

    printf("Ingrese el segundo número: ");
    scanf("%lf", &num2);

    switch (operador)
    {
    case '+':
        printf("%.2lf + %.2lf = %.2lf\n", num1, num2, sumar(num1, num2));
        break;
    case '-':
        printf("%.2lf - %.2lf = %.2lf\n", num1, num2, restar(num1, num2));
        break;
    case '*':
        printf("%.2lf * %.2lf = %.2lf\n", num1, num2, multiplicar(num1, num2));
        break;
    case '/':
        printf("%.2lf / %.2lf = %.2lf\n", num1, num2, dividir(num1, num2));
        break;
    default:
        printf("Operador no válido. Por favor, ingrese +, -, *, o /.\n");
        break;
    }
}
long calcularFactorial(long n)
{

    if (n == 0 || n == 1)
    {
        return 1;
    }
    else
    {

        int factorial = 1;
        for (int i = 2; i <= n; i++)
        {

            factorial *= i;
        }
        return factorial;
    }
}
void opcion6()
{
    long numero;

    printf("Ingrese un número entero para calcular su factorial: ");
    scanf("%ld", &numero);

    long resultado = calcularFactorial(numero);
    printf("El factorial de %ld es %ld\n", numero, resultado);
}

long raizCuadrada(long num)
{
    if (num < 0)
    {
        printf("No se puede calcular la raíz cuadrada de un número negativo.\n");
        
    }
    long resultado = sqrt(num);
    return resultado;
}

void opcion7()
{
    long numero;
    printf("Ingrese un número para calcular su raíz cuadrada: ");
    scanf("%ld", &numero);

    long resultado = raizCuadrada(numero);

    printf("el resultado es : %ld ", resultado);
}
void opcion8()
{
    printf("%d", system("nano ficheroEscritura"));
}
void nacimiento()
{

    pid_t intentoProceso = fork();

    if (intentoProceso == 0)
    {
        printf("Hola, acabo de nacer, soy %d y mi padre es %d", getpid(), getppid());
    }
    if (intentoProceso > 0)
    {   wait(10);
        printf("Mi hijo ya ha nacido y muerto despues :S, soy %d",getpid());
    }
    if(intentoProceso<0){
        printf("Parece que ha habido un problema en la creación");
    }

}
void opcion9()
{
    nacimiento();
}
void opcion10()
{
    printf("Hola mundo!! \n");
}