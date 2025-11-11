package application;

import entities.Hotel;

import java.util.Locale;
import java.util.Scanner;

public class Program {
    public static void main(String[] args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        System.out.print("How many rooms will be rented? ");
        int rommNumbers = sc.nextInt();

        Hotel[] hotels = new Hotel[10];

        for (int i = 0; i < rommNumbers; i++) {

            sc.nextLine();
            System.out.println("Rent #" + (i + 1) + ":");

            System.out.print("Name: ");
            String name = sc.nextLine();
            System.out.print("Email: ");
            String email = sc.nextLine();
            System.out.print("Room: ");
            int room = sc.nextInt();
            hotels[room] = new Hotel(name, email, room);
        }
        System.out.println("Busy rooms: ");
        for (int i = 0; i < hotels.length; i++) {
            if (hotels[i] != null) {
                System.out.println(hotels[i].getRoom() + ": " + hotels[i].getName() + ", " + hotels[i].getEmail());
            }
        }


    }
}
