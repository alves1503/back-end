
import java.util.Scanner;
import javax.sound.midi.SysexMessage;

public class Exercicio2 {


    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        double raio, pi, area;

        pi = 3.14159;

        System.out.print("Digite o valor do raio: ");
        raio = sc.nextDouble();

        area = pi * Math.pow(raio, 2);

        System.out.printf("A area é: %.4f%n", area);








    }





}
