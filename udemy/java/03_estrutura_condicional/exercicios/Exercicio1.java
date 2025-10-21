
import java.util.Scanner;
import javax.swing.event.SwingPropertyChangeSupport;

public class Exercicio1 {

    public static void main(String[] args) {

        int numero;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite um número: ");
        numero = sc.nextInt();

        if(numero < 0) {
            System.out.println("O numero " + numero + " é negativo");
        } else {
            System.out.println("O numero " + numero + " é positivo");

        }

    }

}
