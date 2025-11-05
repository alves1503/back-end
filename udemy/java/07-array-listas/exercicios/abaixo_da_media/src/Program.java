import java.util.Locale;
import java.util.Scanner;

public class Program {
    public static void main(String[] args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        System.out.print("Quantos elementos vai ter seu Array: ");
        int numbersQuantity = sc.nextInt();

        double[] numbers = new double[numbersQuantity];

        for (int i = 0; i < numbers.length; i++) {
            System.out.print("Digite um numero: ");
            double myNumber = sc.nextDouble();
            numbers[i] = myNumber;
        }

        double sun = 0.0;

        for (int i = 0; i < numbers.length; i++) {
            sun += numbers[i];
        }

        double bigger = sun / numbers.length;
        System.out.printf("MEDIA DO VETOR: %.3f%n", bigger);

        System.out.println("ELEMENTOS ABAIXO DA MEDIA: ");
        for (int i = 0; i < numbers.length; i++) {
            if (numbers[i] < bigger) {
                System.out.printf("%.1f%n", numbers[i]);
            }
        }


    }
}
