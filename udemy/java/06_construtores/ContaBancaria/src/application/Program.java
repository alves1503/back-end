package application;

import entities.Conta;

import java.util.Locale;
import java.util.Scanner;

public class Program {

    public static void main(String[] args) {

        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        System.out.print("Enter account number: ");
        int numeroConta = sc.nextInt();

        sc.nextLine();

        System.out.print("Enter account holder: ");
        String name = sc.nextLine();

        Conta usuario1;


        //Verificar sim/não
        System.out.print("Is there na initial deposit (y/n)?");
        char depositoInicialCaractere = sc.next().charAt(0);
        if (depositoInicialCaractere == 'y' || depositoInicialCaractere == 'Y') {
            System.out.print("Enter initial deposit value: ");
            double deposito = sc.nextDouble();
            usuario1 = new Conta(numeroConta, name, deposito);
        } else {

            usuario1 = new Conta(numeroConta, name);
        }

        System.out.println();

        System.out.println("Acount data: ");
        System.out.println(usuario1);

        System.out.println();

        //Deposito
        System.out.print("Enter a deposit value: ");
        double deposito = sc.nextDouble();
        usuario1.deposito(deposito);
        System.out.println("Updated account data:");
        System.out.println(usuario1);

        System.out.println();

        //Saque
        System.out.print("Enter a withdraw value: ");
        double saque = sc.nextDouble();
        usuario1.saque(saque);
        System.out.println("Updated account data:");
        System.out.println(usuario1);


        sc.close();
    }
}
