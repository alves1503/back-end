
import java.util.Scanner;

public class Exercicio5 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int codigo, quantidade;

        System.out.println("------------------------------");
        System.out.println("Codigo | Especificação | Preço");
        System.out.println("------------------------------");
        System.out.println(" 1 | Cachorro quente | R$ 4,00");
        System.out.println(" 2 | X - salada | R$ 4,50");
        System.out.println(" 3 | X - Bacon | R$ 5,00");
        System.out.println(" 4 | Torrada simples | R$ 2,00");
        System.out.println(" 5 | Refrigerante | R$ 1,50");
        System.out.println("------------------------------");

        System.out.print("Digite o codigo do produto desejado: ");
        codigo = sc.nextInt();

        System.out.print("Digite a quantidade de produto desejado: ");
        quantidade = sc.nextInt();

        double total;
        if (codigo == 1) {
            total = 4 * quantidade;
            System.out.println("Total: R$ " + total);
        } else if (codigo == 2) {
            total = 4.50 * quantidade;
            System.out.println("Total: R$ " + total);
        } else if (codigo == 3) {
            total = 5 * quantidade;
            System.out.println("Total: R$ " + total);
        } else if (codigo == 4) {
            total = 2 * quantidade;
            System.out.println("Total: R$ " + total);
        } else if (codigo == 5) {
            total = 1.50 * quantidade;
            System.out.println("Total: R$ " + total);
        }

    }

}
