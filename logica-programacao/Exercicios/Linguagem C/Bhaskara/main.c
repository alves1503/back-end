#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    double a, b, c, x1, x2, delta;

    printf("Coeficiente A: ");
    scanf("%lf", &a);
    printf("Coeficiente B: ");
    scanf("%lf", &b);
    printf("Coeficiente C: ");
    scanf("%lf", &c);


    if (a == 0) {
        printf("Nao e uma equacao de segundo grau.\n");
    }

    delta = pow(b, 2) - 4 * a * c;


    if (delta >= 0) {
        x1 = (-b + sqrt(delta)) / (2 * a);
        x2 = (-b - sqrt(delta)) / (2 * a);
        printf("X1 = %.4lf\nX2 = %.4lf\n", x1, x2);
    } else {
        printf("Esta equacao nao possui raizes reais.\n");
    }

    return 0;
}
