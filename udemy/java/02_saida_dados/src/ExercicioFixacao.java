import java.util.Locale;
import static java.util.Locale.setDefault;

public class ExercicioFixacao {

    public static void main(String[] args) {
        setDefault(Locale.US);

    String product1 = "Computer";
    String product2 = "Office desk";
    
    int age = 30;
    int code = 5290;
    char gender = 'F';


    double price1 = 2100.00;
    double price2 = 650.50;
    double measure = 53.234567;

    System.out.println("Products: ");
    System.out.println(product1 + ", which price is $ " + price1);
    System.out.println(product2 + ", which price is $" + price2);

    System.out.println();

    System.out.println("Record: " + age + " years old, code " + code + " and gender: " + gender);

    System.out.println("Measue with eight decimal places: " + measure);
    System.out.printf("Rouded (three decimal places) %.3f%n", measure);
    System.out.printf("US decimal point: " + measure);




}
}
