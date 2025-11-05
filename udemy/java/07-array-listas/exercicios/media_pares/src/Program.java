import java.util.Locale;
import java.util.Scanner;

public class Program {
    public static void main(String[] args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);


        System.out.print("Quantos elementos vai ter seu Array? ");
        int numberQuantiy = sc.nextInt();

        double[] numbers = new double[numberQuantiy];

        for (int i = 0; i < numbers.length; i++) {
            System.out.print("Digite um número: ");
            double myNumber = sc.nextInt();
            numbers[i] = myNumber;
        }


        boolean hasPair = false;
        double sun = 0;
        int pairQuantity = 0;
        for (int i = 0; i < numbers.length; i++) {
            if (numbers[i] % 2 == 0) {
                sun += numbers[i];
                pairQuantity += 1;
                hasPair = true;
            }
        }

        double bigger = sun / pairQuantity;

        if (!hasPair) {
            System.out.println("NENHUM NUMERO PAR!");
        } else {
            System.out.printf("MEDIA DOS PARES: %.1f%n", bigger);

        }


    }

}
