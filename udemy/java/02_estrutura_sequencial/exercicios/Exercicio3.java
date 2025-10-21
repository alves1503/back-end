
import java.util.Scanner;

public class Exercicio3 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int A, B, C, D, diferenca;

        System.out.print("Digite o valor de x: ");
        A = sc.nextInt();

        System.out.print("Digite o valor de x: ");
        B = sc.nextInt();

        System.out.print("Digite o valor de x: ");
        C = sc.nextInt();

        System.out.print("Digite o valor de x: ");
        D = sc.nextInt();

        diferenca = A * B - C * D;

        System.out.println("Diferença: " + diferenca);

    }

}
