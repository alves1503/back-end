package application;

import entities.Person;

import java.util.Locale;
import java.util.Scanner;

public class Program {
    public static void main(String[] args) {

        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        System.out.print("Quantas pessoas você vai digitar? ");
        int personsQuantity = sc.nextInt();

        Person[] persons = new Person[personsQuantity];

        for (int i = 0; i < persons.length; i++) {
            sc.nextLine();
            System.out.println("Dados da " + (i + 1) + "° pessoa:");

            System.out.print("Nome: ");
            String name = sc.nextLine();
            System.out.print("Idade: ");
            int age = sc.nextInt();

            persons[i] = new Person(name, age);

        }

        int old = 0;
        String older = "";
        for (int i = 0; i < persons.length;i++){
            if(persons[i].getAge() > old) {
                old += persons[i].getAge();
                older = persons[i].getName();
            }
        }

        System.out.println("PESSOA MAIS VELHA: " + older);


    }


}
