
import java.util.Scanner;

public class Exercicio4 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int horaInicial, horaFinal;

        System.out.print("Digite a hora que começou: ");
        horaInicial = sc.nextInt();

        System.out.print("Digite a hora que acabou: ");
        horaFinal = sc.nextInt();

        int duracao;

        if (horaInicial < horaFinal) {
            duracao = horaFinal - horaInicial;
            System.out.println("O jogo durou: " + duracao + " Hora(S)");
        } else {
            duracao = 24 - horaInicial + horaFinal;
            System.out.println("O jogo durou: " + duracao + " Hora(S)");
        }

    }

}
