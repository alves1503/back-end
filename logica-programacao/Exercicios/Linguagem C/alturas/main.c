#include <stdio.h>
#include <stdlib.h>

void limpar_entrada()
{
    char c;
    while ((c = getchar()) != '\n' && c != EOF) {}
}

void ler_texto(char *buffer, int length)
{
    fgets(buffer, length, stdin);
    strtok(buffer, "\n");
}


int main(){

    int i,n;


    printf("Quantas pessoas serao digitadas? ");
    scanf("%d", &n);

    char nome[n];
    int idade[n];
    double altura[n];


    for (i = 0 ; i < n ; i++){
            limpar_entrada;
            printf("Dados da %da pessoa: \n", i+1);
            printf("Nome: ");
            ler_texto("nome[i]");
            printf("Idade: ");
            scanf("%d", idade[i]);
            printf("Altura: ");
            scanf("%lf", altura[i]);

    }











    return 0;
}
