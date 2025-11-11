package application;

import entities.Funcionario;

import java.util.ArrayList;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;

public class Program {
    public static void main(String[] args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);


        System.out.print("How many employees be registeres? ");
        int number = sc.nextInt();

        List<Funcionario> funcionariosLista = new ArrayList<>();

        for (int i = 0; i < number; i++) {
            System.out.println("Emplyoee #" + (i + 1) + ":");
            System.out.print("Id: ");
            int id = sc.nextInt();
            sc.nextLine();
            System.out.print("Name: ");
            String name = sc.nextLine();
            System.out.print("Salary: ");
            double salario = sc.nextDouble();
            funcionariosLista.add(new Funcionario(id, name, salario));
        }

        System.out.print("Enter the employee id that will have salary increase: ");
        int idBuscado = sc.nextInt();


        for (Funcionario f : funcionariosLista) {
            if (f.getId() == idBuscado) {
                System.out.print("Enter the percentage: ");
                int porcentagem = sc.nextInt();
                double somaPorentagem = ((double) porcentagem / 100 * f.getSalario()) + f.getSalario();
                ;
                f.setSalario(somaPorentagem);
            } else {
                System.out.print("Usuario não encontrado ");
            }
        }

        System.out.println("List of employess: ");
        for (Funcionario f : funcionariosLista) {
            System.out.printf(f.getId() + ", " + f.getName() + ", " + "%.2f%n", f.getSalario());
        }


    }

}
