#include <stdio.h>
#include <stdlib.h>

int main()
{


    int x1,x2,x3,soma,qtd;


    qtd = 0;

    printf("Primeiro valor: ");
    scanf("%d", &x1);
    printf("Segundo valor: ");
    scanf("%d", &x2);
    printf("Terceiro valor: ");
    scanf("%d", &x3);


    if (x1 < x2 && x1 < x3) {
        printf("Menor = %d", x1);
    }
    else if (x2 < x3) {
         printf("Menor = %d", x2);
    }
    else {
         printf("Menor = %d", x3);
    }


    return 0;
}
