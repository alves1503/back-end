#include <stdio.h>
#include <stdlib.h>

int main()
{
    double lar,comp,metro,area,preco;



    printf("Digite a largura do terreno:");
    scanf("%lf", &lar);
    printf("Digite o comprimento do terreno:");
    scanf("%lf", &comp);
    printf("Digite o valor do metro quadrado: ");
    scanf("%lf", &metro);

    area = lar * comp;
    preco = metro * area;


    printf("Area do terreno= %.2lf\n",area);
    printf("Preco do terreno= %.2lf",preco);

    return 0;

}
