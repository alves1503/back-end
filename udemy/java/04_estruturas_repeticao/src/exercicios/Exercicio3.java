package exercicios;

import java.util.Scanner;

public class Exercicio3 {

	public static void main(String[] args) {

		// 1.Álcool
		// 2.Gasolina
		// 3.Diesel
		// 4.Fim)

		Scanner sc = new Scanner(System.in);

		int numero;

		int alcool = 0;
		int gasolina = 0;
		int diesel = 0;

		System.out.println("Alcool: 1 ");
		System.out.println("Gasolina: 2 ");
		System.out.println("Diesel: 3 ");
		System.out.println("Finalizar o program: 3 ");
		System.out.print("Qual o produto de sua preferencia? ");
		numero = sc.nextInt();

		while (numero != 4) {
			 if (numero == 1) {
				alcool ++;
			} else if (numero == 2) {
				gasolina ++;
			} else if (numero == 3){
				diesel ++;
			}

			System.out.println();
			System.out.print("Qual o produto de sua preferencia (Ou digite 4 para finalizar)");
			numero = sc.nextInt();

		}

		System.out.println("Muito obrigado!");
		System.out.println("Alcool: " + alcool);
		System.out.println("Gasolina: " + gasolina);
		System.out.println("Diesel: " + diesel);

	}

}
