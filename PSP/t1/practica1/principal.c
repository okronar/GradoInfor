#include <stdio.h>
#define PI 3.14

int sacarArea(); //le pasas el radio y sacas el area
void opcion1();//llama a la de arriba
bool esPrimo();//comprueba si es primo el numero que se le pasa
void opcion2();//le pasa los numeros a la de arriba
void fibonacci();//Desarrolla un programa en c que imprima los primeros N (que pases en la opcion3)términos de la secuencia de Fibonacci
void opcion3();// Solicita al usuario el número de términos que desea imprimir
double calcularPotencia();//se calcula la potencia con la base y exponente que pedira en la opcion 4
void opcion4();//solicita los datos
double sumar();//suma
double restar();//resta
double dividir();//division
double multiplicar();//multiplicacion
void opcion5();//realiza el switch y dependiendo el input se usa una funcion u otra
long calcularFactorial();//pasas un numero y si no es 0 o 1 calcula el factorial
void opcion6();//pide el numero de  calcularFactorial()
double raizCuadrada();// ejecuta el metodo sqrt despues de hacer una comprobacion basiquilla
void opcion7();//simplemente pasa el metodo raiz cuadrada y lo printea
void opcion8();
void opcion9();
void opcion10();//el genial y dificil holamundo





 opcion8()
{
    // Código para la opción 8
    printf("Has seleccionado la opción 3.\n");
}
 opcion9()
{
    // Código para la opción 9
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
sacarArea(){
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
 opcion1()
{
    sacarArea();
   
}

 esPrimo(int numero) {
    if (numero <= 1) {
        return false;
    }
    for (int i = 2; i * i <= numero; i++) {
        if (numero % i == 0) {
            return false;
        }
    }
    return true;
}

 opcion2()
{

    int num;

    
    printf("Ingrese un número: ");
    scanf("%d", &num);

    
    if (esPrimo(num)) {
        printf("%d es un número primo.\n", num);
    } else {
        printf("%d no es un número primo.\n", num);
    }

    return 0;

 fibonacci(int n) {
    int a = 0, b = 1, c;

    printf("Los primeros %d términos de la secuencia de Fibonacci son:\n", n);

    for (int i = 0; i < n; i++) {
        printf("%d ", a);
        c = a + b;
        a = b;
        b = c;
    }
    printf("\n");
}
    
}
opcion3()
{
    int numero;

    
    printf("Ingrese el número de términos de la secuencia de Fibonacci a imprimir: ");
    scanf("%d", &num_terminos);
    fibonacci(numero);
}
calcularPotencia(double base, int exponente) {
    double resultado = 1.0;

    
    for (int i = 0; i < exponente; i++) {
        resultado *= base;
    }

    return resultado;
}

opcion4()
{
    double base, resultado;
    int exponente;

    // Solicitar al usuario que ingrese la base y el exponente
    printf("Ingrese la base: ");
    scanf("%lf", &base);

    printf("Ingrese el exponente (entero no negativo): ");
    scanf("%d", &exponente);

    resultado = calcularPotencia(base,exponente);
    printf("el resultado es " + resultado);

}
 sumar(double a, double b) {
    return a + b;
}


 restar(double a, double b) {
    return a - b;
}


 multiplicar(double a, double b) {
    return a * b;
}


 dividir(double a, double b) {
    
    if (b != 0) {
        return a / b;
    } else {
        printf("Error: No se puede dividir por cero.\n");
        return 0.0; 
    }
}

opcion5()
{
    double num1, num2;
    char operador;

  
    printf("Ingrese el primer número: ");
    scanf("%lf", &num1);

    printf("Ingrese el operador (+, -, *, /): ");
    scanf(" %c", &operador); 

    printf("Ingrese el segundo número: ");
    scanf("%lf", &num2);

    
    switch (operador) {
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
calcularFactorial(long n) {
   

    if (n == 0 || n == 1) {
        return 1; 
    } else {
        
        int factorial = 1;
        for (int i = 2; i <= n; i++) {
            
        

            factorial *= i;
        }
        return factorial;
    }
}
 opcion6()
{
    long numero;

   
    printf("Ingrese un número entero para calcular su factorial: ");
    scanf("%d", &numero);

    
    long resultado = calcularFactorial(numero);
    printf("El factorial de %d es %d\n", numero, resultado);
} 

raizCuadrada(double num) {
    if (num < 0) {
        printf("No se puede calcular la raíz cuadrada de un número negativo.\n");
        return -1.0; 
    }

    return sqrt(num);
}

opcion7()
{
   double numero;
    printf("Ingrese un número para calcular su raíz cuadrada: ");
    scanf("%lf", &numero);

    
    double resultado = raizCuadrada(numero);

    printf("el resultado es :" + resultado)
} 
opcion10()
{   
    printf("Hola mundo!!");
    
}