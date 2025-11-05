package application;

import entities.Person;

import java.util.Locale;
import java.util.Scanner;

public class Program {


    public static void main(String[] args) {

        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        System.out.print("Quantos alunos serão digitados? ");
        int personNumber = sc.nextInt();

        Person[] persons = new Person[personNumber];

        for (int i = 0; i < persons.length; i++) {
            sc.nextLine();
            System.out.println("Digite nome, primeira e segunda nota do " + (i + 1) + "° aluno");
            String name = sc.nextLine();
            double note1 = sc.nextDouble();
            double note2 = sc.nextDouble();
            persons[i] = new Person(name, note1, note2);
        }


        double sun = 0;
        double average = 0;
        System.out.println("ALUNOS APROVADOS: ");
        for (int i = 0; i < persons.length; i++) {
            sun = persons[i].getNote1() + persons[i].getNote2();
            average = sun / 2;
            if(average >= 6) {
                System.out.println(persons[i].getName());
            }
        }


    }

}
