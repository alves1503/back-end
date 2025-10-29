package exercicios;

import java.util.Scanner;

public class Exercicio1 {

	
	//Leitura de senha correta
	public static void main(String[] args) {
	
		Scanner sc = new Scanner(System.in);
		
		int senhaCorreta = 2002;
		
		System.out.println("Digite a sua senha: ");
		int senha = sc.nextInt();
		
		
		while(senha != senhaCorreta) {
			System.out.println("Senha incorreta");
			System.out.println("Digite a sua senha: ");
			senha = sc.nextInt();
		}
		
		System.out.println("Senha correta");
		

	}

}
