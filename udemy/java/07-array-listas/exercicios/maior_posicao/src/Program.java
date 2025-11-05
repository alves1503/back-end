import java.util.Locale;
import java.util.Scanner;

public class Program {
    public static void main(String[] args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);


        System.out.print("Quantos números você vai digitar?");
        int numberQuantity = sc.nextInt();

        double[] numbers = new double[numberQuantity];

        for (int i = 0; i < numbers.length; i++) {
            System.out.print("Digite um numero: ");
            double myNumber = sc.nextDouble();
            numbers[i] = myNumber;
        }


        double bigger = 0;
        int biggerPosition = 0;

        for (int i = 0; i < numbers.length;i++) {
            if(numbers[i] > bigger) {
                bigger = numbers[i];
                biggerPosition = i;
            }
        }

        System.out.println("MAIOR VALOR = " + bigger);
        System.out.println("POSIÇÃO DO MAIOR VALOR = " + biggerPosition);
    }
}
