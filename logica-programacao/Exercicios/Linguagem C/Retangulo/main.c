#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    double base, altura, area, perim,diag;


    printf("Base do retangulo: ");
    scanf("%lf", &base);
    printf("Altura do retangulo: ");
    scanf("%lf", &altura);

    area = base * altura;
    perim = 2 * (base + altura);
    diag = sqrt(pow(base,2) + pow(altura,2));

    printf("AREA = %.4lf\n", area);
    printf("PERIMETRO = %.4lf\n", perim);
    printf("DIAGONAL = %.4lf", diag);


    return 0;
}
