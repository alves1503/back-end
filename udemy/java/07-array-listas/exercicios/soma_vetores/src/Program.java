import java.util.Locale;
import java.util.Scanner;

public class Program {
    public static void main(String[] args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);


        System.out.print("Quantos valores vai ter cada vetor? ");
        int numberQuantity = sc.nextInt();


        int[] numbersA = new int[numberQuantity];

        int[] numbersB = new int[numberQuantity];


        System.out.println("Digite o valor do Array 'A': ");
        for (int i = 0; i < numbersA.length; i++) {
            int myNumber = sc.nextInt();
            numbersA[i] = myNumber;
        }

        System.out.println("Digite o valor do Array 'B': ");
        for (int i = 0; i < numbersB.length; i++) {
            int myNumber = sc.nextInt();
            numbersB[i] = myNumber;
        }


        System.out.println("VALOR RESULTANTE: ");
        for (int i = 0; i < numberQuantity; i++) {
            System.out.println(numbersA[i] + numbersB[i]);
        }


    }

}
