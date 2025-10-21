import java.util.Locale;

public class App {
    public static void main(String[] args) throws Exception {

        String nome = "Henrique";
        double x = 98.550;
        int y = 10;
        System.out.println(nome);
        System.out.println(y);
        
        System.out.printf("%.2f%n", x); //Formata para duas casas decimais
        Locale.setDefault(Locale.US);

        System.out.print("Ola " + nome + " seu valor inicial " + x * 2);




    }
}
