
import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
      
        // Estrutura IF/ELSE

        Scanner sc = new Scanner(System.in);

        String nome;
        int idade;

        System.out.print("Qual seu nome? ");
        nome = sc.nextLine();
        \
        System.out.println();

        System.out.print("Qual sua idade? ");
        idade = sc.nextInt();


        if(idade >= 18) {
            System.out.println("Acesso liberado: " + nome);
            System.out.println("Maior de idade");
        } else {
            System.out.println("Acesso negado: " + nome);
            System.out.println("Menor de idade");
        }








    }
}
