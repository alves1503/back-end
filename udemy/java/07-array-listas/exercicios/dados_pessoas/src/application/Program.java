package application;

import entities.Person;

import java.util.Locale;
import java.util.Scanner;

public class Program {

    public static void main(String[] args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        System.out.print("Quantas pessoas serão digitadas? ");
        int personNumber = sc.nextInt();

        Person[] persons = new Person[personNumber];

        for (int i = 0; i < persons.length; i++) {
            System.out.print("Altura da " + (i + 1) + "° pessoa: ");
            double height = sc.nextDouble();
            System.out.print("Genero da " + (i + 1) + "° pessoa: ");
            char gender = sc.next().charAt(0);
            persons[i] = new Person(height, gender);
        }


        double greaterHeight = 0;   // Maior altura
        double shorterHeight = 0;   // Menor altura
        for (int i = 0; i < persons.length; i++) {
            // Validação de maior/menor altura
            if (persons[i].getHeight() > greaterHeight) {
                greaterHeight = persons[i].getHeight();
            } else if (persons[i].getHeight() < greaterHeight) {
                shorterHeight = persons[i].getHeight();
            }

        }

        System.out.printf("Menor altura: %.2f%n", shorterHeight);
        System.out.printf("Maior altura: %.2f%n", greaterHeight);


        double sunWomen = 0;
        double womenQuantity = 0;
        int menQuantity = 0;
        for (int i = 0; i < persons.length; i++) {
            if (persons[i].getGender() == 'f' || persons[i].getGender() == 'F') {
                sunWomen += persons[i].getHeight();
                womenQuantity += 1;
            } else {
                menQuantity += 1;
            }
        }

        double womenAverage = sunWomen / womenQuantity;

        System.out.printf("Media das alturas das mulheres %.2f%n: ", womenAverage);
        System.out.println("Numero de homens " + menQuantity);


    }
}
