import entities.Estudante;

import java.util.Locale;
import java.util.Scanner;

public class Program {

    public static void main(String[] args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        Estudante estudante1 = new Estudante();
        estudante1.nome = sc.nextLine();
        System.out.println("Digite suas tres notas: ");
        estudante1.nota1 = sc.nextDouble();
        estudante1.nota2 = sc.nextDouble();
        estudante1.nota3 = sc.nextDouble();


        System.out.println("Nota: " + estudante1.soma());

        if(estudante1.soma() < 60) {
            System.out.println("Reprovado!");
            System.out.println("Faltam: " + estudante1.resultado() + "pontos");
        } else {
            System.out.println("Aprovado");
        }


    }
}
