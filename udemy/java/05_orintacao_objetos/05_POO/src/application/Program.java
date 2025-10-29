package application;

import entities.Triangle;

import javax.swing.plaf.synth.SynthOptionPaneUI;
import java.util.Locale;
import java.util.Scanner;

public class Program {

    public static void main(String[] args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        Triangle x, y;
        x = new Triangle();
        y = new Triangle();


        System.out.println("Entre com o valor do triangulo de x: ");
        x.a = sc.nextDouble();
        x.b = sc.nextDouble();
        x.c = sc.nextDouble();

        System.out.println("Entre com o valor do triangulo de y: ");
        y.a = sc.nextDouble();
        y.b = sc.nextDouble();
        y.c = sc.nextDouble();



        double areaX = x.area();

        double areaY = y.area();


        System.out.printf("Area do triangulo Y: %.4f", areaX);
        System.out.println();
        System.out.printf("Area do triangulo Y: %.4f", areaY);

        if (areaX > areaY) {
            System.out.println("A maior area é: " + areaX);
        } else {
            System.out.println("A maior area é: " + areaY);

        }


    }


}
