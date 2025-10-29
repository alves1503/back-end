package exercicios;

import java.util.Scanner;


public class Exercicio2 {

	public static void main(String[] args) {

		int x,y;
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Digite o valor de x: ");		
		x = sc.nextInt();
		
		System.out.print("Digite o valor de y: ");
		y = sc.nextInt();
		
		
		while(x != 0 && y != 0 ) {
			if(x > 0 && y > 0) {
				System.out.println("Primeiro quadrante");
			} else if(x > 0 && y < 0) {
				System.out.println("Quarto quadrante");
			} else if(x < 0 && y <0) {
				System.out.println("Terceiro quadrante");
			} else if (x < 0 && y > 0) {
				System.out.println("Segundo quadrante");
			}
			
			System.out.print("Digite o valor de x: ");		
			x = sc.nextInt();
			
			System.out.print("Digite o valor de y: ");
			y = sc.nextInt();
				
		}
		


		sc.close();
		System.out.println("Programa encerrado");
	}

}
