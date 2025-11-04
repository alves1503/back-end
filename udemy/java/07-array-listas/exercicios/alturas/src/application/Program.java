package application;

import entities.Person;

import java.util.Locale;
import java.util.Scanner;

public class Program {


    public static void main(String[] args) {

        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);


        System.out.print("Quantas pessoas você vai digitar? ");
        int personNumbers = sc.nextInt();
        Person[] persons = new Person[personNumbers]; // Cria um array de pessoas

        for (int i = 0; i < persons.length; i++) {
            sc.nextLine();
            System.out.println("Dados da " + (1 + i) + "° pessoa: ");
            System.out.print("Nome: ");
            String name = sc.nextLine();
            System.out.print("Idade: ");
            int age = sc.nextInt();
            System.out.print("Altura: ");
            double height = sc.nextDouble();
            persons[i] = new Person(name, age, height); // Cria a pessoa

        }

        // Altura media
        int underSixteen = 0; // menor de 16
        double sun = 0;
        for (int i = 0; i < persons.length; i++) {
            sun += persons[i].getAHeight();
            if (persons[i].getAge() < 16) {
                underSixteen += 1;
            }
        }

        double average = sun / personNumbers;
        System.out.printf("Altura Media: %.2f%n", average);
        double PercentageSixteen = (double) underSixteen / personNumbers * 100; //Valor em percentual dos menores de 16
        System.out.println("Pessoas com menos de 16 anos: " + PercentageSixteen + "%");

        //Menores de 16
        for (int i = 0; i < persons.length; i++) {
            if (persons[i].getAge() < 16) {
               System.out.println(persons[i].getName());
            }
        }


    }

}

