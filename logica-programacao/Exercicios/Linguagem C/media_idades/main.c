#include <stdio.h>
#include <stdlib.h>

int main()
{
    double media;
    int qtd,soma,x;



    printf("Digite as idades: \n");
    scanf("%d",&x);


    soma = 0;
    qtd = 0;


    while (x >= 0)
    {
        soma = soma + x;
        qtd = qtd + 1;
        scanf("%d",&x);
    }

    if (qtd == 0)
    {
        printf("IMPOSSIVEL CALCULAR");
    }
    else
    {

        media = (double)soma / qtd;
        printf("MEDIA = %.2lf",media);

    }

    return 0;
}
