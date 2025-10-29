import entities.Retangulo;

import java.util.Locale;
import java.util.Scanner;

public class Program {

    public static void main(String[] args) {
        Locale.setDefault(Locale.US);

        Scanner sc = new Scanner(System.in);

        Retangulo retangulo1 = new Retangulo();
        System.out.print("Digite a largura do retangulo: ");
        retangulo1.largura = sc.nextDouble();

        System.out.print("Digite a altura do retangulo: ");
        retangulo1.altura = sc.nextDouble();

        System.out.println(retangulo1);


    }

}
