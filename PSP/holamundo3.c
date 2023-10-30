
#include <stdlib.h>

const int VERDADERO = 1;
const int FALSO = 0;

int es_cierto() {
    return FALSO;
}
 
int funcion_devolver(int lo_que_entra) {
    int lo_que_sale;
    return lo_que_sale = lo_que_entra+1;
}

void subprobrama_no_devolvible(int lo_que_entra) {
    int lo_que_se_hace = lo_que_entra+1;º
    printf("Hago lo que quiero con lo que entra: \n");
}


int main (int argc, char *argv[]){

        printf("Hola Mundo \n");

        printf("Tu nombre es: %s y peinas cabras %s \n",argv[6],argv[3]);

        int lo_que_entra = 3;
        printf("El valor devuelto por la funcion devolver es:  %d \n", funcion_devolver(lo_que_entra));

        if(es_cierto()) {
            printf("Es verdadero");
        }
        else {
            printf("Es falso");
        }

        return 0;
}