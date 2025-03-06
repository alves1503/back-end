#include <stdio.h>
#include <stdlib.h>

int main()
{


    int n,i,soma;



    printf("Deseja a tabuada para qual valor? ");
    scanf("%d", &n);


    soma = 0;


    for (i = 1; i <=10; i++){
            soma = n * i;
            printf("%d x %d = %d\n",n,i,n * i);
    }




    return 0;
}
