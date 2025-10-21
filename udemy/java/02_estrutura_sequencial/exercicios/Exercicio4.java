
import java.util.Scanner;

public class Exercicio4 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int quantidadeDeHoras;
        double valorHora, salario, horaTrabalhada;

        System.out.print("Digite a quantidade de horas que você tem: ");
        quantidadeDeHoras = sc.nextInt();

        //--------------

        System.out.print("Digite a quantidade de horas trabalhadas: ");
        horaTrabalhada = sc.nextDouble();


        System.out.print("Digite o valor que você recebe por hora: ");
        valorHora = sc.nextDouble();


        salario = valorHora * horaTrabalhada;

        System.out.println("Quantidade de horas: " + quantidadeDeHoras);
        System.out.printf("Salario = R$ %.2f%n", salario);

    }

}
