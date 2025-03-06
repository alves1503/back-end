#include <stdio.h>
#include <stdlib.h>

int main()
{

    int soma,i,j,n;


    printf("Qual a ordem da matriz? ");
    scanf("%d", &n);

    int mat[n][n];



    for (i = 0 ; i < n ; i++ ) {
        for (j = 0 ; j < n ; j++) {
                printf("Elemento [%d , %d]: ",i,j);
                scanf("%d",&mat[i][j]);

        }
    }


   printf("DIAGONAL PRINCIPAL: \n");



   for (i = 0 ; i < n ; i++ ) {
        for (j = 0 ; j < n ; j++) {
                printf("%d  ", mat[i][i]);
        }
    }

   soma = 0;


     for (i = 0 ; i < n ; i++ ) {
        for (j = 0 ; j < n ; j++) {
                if (mat[i][j] < 0) {
                    soma = soma + 1;
                }
        }
    }


   printf("\nQUANTIDADE DE NEGATIVOS = %d", soma);









    return 0;
}
