package aplication;

import java.util.Locale;
import java.util.Scanner;

public class Program {

    public static void main(String[] args) {

        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        System.out.print("Quantos numeros voce vai digitar? ");
        int numberQuantity = sc.nextInt();

        double[] numbers = new double[numberQuantity];

        // Adicionando valores ao array
        for (int i = 0; i < numbers.length; i++) {
        System.out.print("Digite um numero: ");
        double myNumber = sc.nextDouble();
        numbers[i] = myNumber;
        }

        System.out.println();
        System.out.print("VALORES: ");
        double sun = 0;

        for (int i =0; i < numbers.length; i++) {
        System.out.print(numbers[i] + " ");
        sun += numbers[i];
        }

        double average = sun / numberQuantity;
        System.out.println();
        System.out.printf("SOMA: %.2f%n", sun);
        System.out.printf("SOMA: %.2f%n", average);







    }
}
