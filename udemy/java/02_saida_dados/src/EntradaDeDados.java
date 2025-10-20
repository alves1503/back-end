import java.util.Scanner;

public class EntradaDeDados {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite seu nome: ");
        String nome = sc.next();  // lê uma palavra (até o espaço)
        
        System.out.println("Seja bem-vindo: " + nome);


        System.out.print("Digite um numero: ");
        int x;
        x = sc.nextInt(); //Le um numero inteiro
         System.out.println("Seu numero é: " + x);




        System.out.print("Digite um numero 'double': ");
        double y;
        y = sc.nextDouble(); //Le um numero double
         System.out.println("Seu numero 'double' é: " + y);




         System.out.print("Digite um caractere : ");
        char ch;
        ch = sc.next().charAt(0); //Le um caractere
         System.out.println("Você digitou: " + ch);



         //Lendo varios dados de uma vez
        String h;
        int w;
        double z;

        System.out.print("Digite um nome: ");
        h = sc.nextLine();
        System.out.println("Seu nome " + h);
        
        
        
        System.out.print("Digite um numero2: ");
        w = sc.nextInt();
        System.out.println("Seu nome " + w);
        
        
        
        
        System.out.print("Digite um nome: ");
        z = sc.nextDouble();
        System.out.println("Seu nome " + z);

        sc.close();
    }
}
