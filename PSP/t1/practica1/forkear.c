#include <sys/types.h>
#include <unistd.h>
#include <stdio.h>
 
int main(int argc, char *argv[])
{
    pid_t pid;
 
    if ( (pid=fork()) == 0 )
    { /* hijo */
        printf("Soy el hijo (%d, hijo de %d)\n", getpid(), getppid());
        return 0;
    }
    else
     if((pid=fork())>0){ /* padre */
        printf("Soy el padre (%d, hijo de %d)\n", getpid(), getppid());
        return 0;
    }else {

        printf("Error al crear un hijo, se acabó")
    }
 
    return 0;
}