#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/wait.h>

#define MAX_LINE 80

int ejecutarComando(char* comando) {
    pid_t pid = fork();

    if (pid == 0) {
        char *args[MAX_LINE / 2 + 1];
        char *token = strtok(comando, " ");

        int i = 0;
        while (token != NULL) {
            args[i] = token;
            token = strtok(NULL, " ");
            i++;
        }
        args[i] = NULL;
        execvp(args[0], args);
        exit(EXIT_FAILURE); // Si execvp falla, se sale con código de error
    } else if (pid > 0) {
        int estado;
        wait(&estado);
        
        if (WIFEXITED(estado)) {
            if (WEXITSTATUS(estado) == EXIT_SUCCESS) {
                return 0; // Éxito
            } else {
                return -1; // El comando falló
            }
        } 
    } else {
        return -1; // Error al crear el proceso hijo
    }
}
int main() {
    char comando[] = "ls"; // Cambiar el comando según lo que desees probar
    int resultado = ejecutarComando(comando);

    if (resultado == 0) {
        printf("Prueba 1: Pasada - El comando '%s' se ejecutó correctamente.\n", comando);
    } else {
        printf("Prueba 1: Fallida - Error al ejecutar el comando '%s'.\n", comando);
    }

    return 0;
}

