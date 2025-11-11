import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collector;
import java.util.stream.Collectors;

public class Program {
    public static void main(String[] args) {


        List<String> list = new ArrayList<>();

        list.add("Henrique");
        list.add("Maria");
        list.add("Ana");
        list.add("Marcos");

        list.add(2, "Alves"); // Adiciona na posição desejada
        System.out.println(list.size()); // Ve o tamanho


        for (String x : list) {
            System.out.println(x);
        }

            System.out.println(list.indexOf("Henrique"));


        list.remove("Ana"); // Remove dados
        list.removeIf(x -> x.charAt(0) == 'M');

        List<String> result = list.stream().filter(x -> x.charAt(0) == 'H').collect(Collectors.toList());


        for (String x : list) {
            System.out.println(x);
        }
    }
}
