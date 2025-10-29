import entities.Funcionario;

import java.util.Locale;
import java.util.Scanner;

public class Program {

    public static void main(String[] args) {

        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        Funcionario funcionario1 = new Funcionario();

        System.out.print("Digite Seu nome: ");
        funcionario1.nome = sc.nextLine();

        System.out.print("Digite Seu salario: ");
        funcionario1.salario = sc.nextDouble();

        System.out.print("Taxa: ");
        funcionario1.imposto = sc.nextDouble();


        System.out.println();

        funcionario1.retirarTaxa();

        System.out.println("Dados: " + funcionario1);


        System.out.println();

        System.out.print("Digite o percentual do salario: ");
        int taxa = sc.nextInt();
        funcionario1.adicionarTaxa(taxa);

        System.out.println();

        System.out.println("Update data: " + funcionario1);


    }

}
