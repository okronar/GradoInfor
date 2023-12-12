#include <sys/types.h>
#include <unistd.h>
#include <stdio.h>
 
int main(int argc, char *argv[])
{
    pid_t pid;
    
    if ( (pid=fork()) == 0 )
    { /* hijo */
        printf("Soy el hijo (%d, hijo de %d)\n", getpid(), getppid());
        int resultado = 3*3*3;
        printf("El resultado de la potencia de 3 es: %d \n",resultado);
        return 0;
    }
    else
     if((pid=fork())>0){ /* padre */
        sleep(4);
        printf("Soy el padre (%d, hijo de %d)\n", getpid(), getppid());
        return 0;
    }
 
    return 0;
}