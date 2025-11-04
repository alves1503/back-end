package aplication;

import entities.Produto;

import java.util.Locale;
import java.util.Scanner;

public class Program {

    public static void main(String[] args) {


        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();

        Produto[] vetor = new Produto[n];

        for(int i = 0; i < n; i++) {
            sc.nextLine();
            String name = sc.nextLine();
            double price = sc.nextDouble();
            vetor[i] = new Produto(name, price);
        }

        double soma = 0;
        for(int i =0; i < n; i++) {
            soma += vetor[i].getPreco(); // Pega somente o preço
        }

        double media = soma / n;

        System.out.printf("Media = %.2f%n", media);


    }
}
