
import java.util.Scanner;

public class Exercicio2 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int numero;

        System.out.print("Digite um número: ");
        numero = sc.nextInt();

        if (numero % 2 == 0) {
            System.out.println("Numero: " + numero + " = Par");
        } else {
            System.out.println("Numero: " + numero + " = Impar");
        }

    }

}
