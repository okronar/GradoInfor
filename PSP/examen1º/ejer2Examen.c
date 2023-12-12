#include<stdio.h>
#include<string.h>
#include<pthread.h>
#include<stdlib.h>
#include<unistd.h>

pthread_t tid[2];

void* doSomeThing(void *arg)
{
    unsigned long i = 0;
    pthread_t id = pthread_self();

    if(pthread_equal(id,tid[0]))
    {
        printf("\n Hola soy un hijo\n");
    }
    else
    {
        printf("\n hola soy otro hijo\n");
    }

    for(i=0; i<(0xFFFFFFFF);i++);
    printf("\n ya hemos terminado ahora que diga algo el papá\n");
    return NULL;
}

int main(void)
{
    int i = 0;
    int err;

    while(i < 2)
    {
        err = pthread_create(&(tid[i]), NULL, &doSomeThing, NULL);
        if (err != 0)
            printf("\ncan't create thread :[%s]", strerror(err));
        else
            printf("\n Thread created successfully\n");

        i++;
    }

    sleep(2);
    printf("Acabados los niños cierra el padre");
    return 0;
}