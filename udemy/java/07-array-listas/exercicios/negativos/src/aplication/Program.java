package aplication;

import java.util.Locale;
import java.util.Scanner;

public class Program {

    public static void main(String[] args) {

        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        System.out.print("Quantos numeros voce vai digitar? ");
        int numberQuantity = sc.nextInt();

        int[] numbers = new int[numberQuantity];

        for (int i = 0; i < numbers.length; i++) {
            System.out.print("Digite um numero: ");
            int number = sc.nextInt();
            numbers[i] = number;
        }

        System.out.println();
        System.out.println("NUMEROS NEGATIVOS: ");

        for (int i = 0; i < numbers.length; i++) {
            if (numbers[i] < 0) {
                System.out.println(numbers[i]);
            }

        }


    }

}
