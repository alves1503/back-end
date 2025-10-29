
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o valor que deseja saber a tabuada: ");
        int x = sc.nextInt();
        int i = 0;

        while (i <= 10) {
            System.out.println(x + " X " + i + " = " + i * x);
            i++;
        }



        sc.close();
    }


}