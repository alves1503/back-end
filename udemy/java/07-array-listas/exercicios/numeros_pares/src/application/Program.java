package application;

import java.util.Locale;
import java.util.Scanner;

public class Program {

    public static void main(String[] args) {

        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        System.out.print("Quantos números você vai digitar?");
        int quantityNumber = sc.nextInt();

        int[] pairsNumbers = new int[quantityNumber];

        // Adicionar elemento no Array
        for (int i = 0; i < pairsNumbers.length; i++) {
            System.out.print("Digite um numero: ");
            int numberEntered = sc.nextInt();
            pairsNumbers[i] = numberEntered;
        }

                System.out.println();

        // Imprimindo e adicionando a quantidade
        int pairQuantity = 0;
        for (int i = 0; i < pairsNumbers.length; i++) {
            if (pairsNumbers[i] % 2 == 0) {
                System.out.print(pairsNumbers[i] + "  ");
                pairQuantity += 1;
            }
        }
                System.out.println();
                System.out.println("Quantidade de pares: " + pairQuantity);




    }
}
