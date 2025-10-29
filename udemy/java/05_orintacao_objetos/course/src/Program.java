import entities.Product;

import java.util.Locale;
import java.util.Scanner;
import java.util.concurrent.locks.LockSupport;

public class Program {


    public static void main(String[] args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        Product produto = new Product();
        System.out.println("Entre com a data do produto: ");
        System.out.print("Name: ");
        produto.name = sc.nextLine();
        System.out.print("Price: ");
        produto.price = sc.nextDouble();

        System.out.print("Quantidade: ");
        produto.quantity = sc.nextInt();


        System.out.println();
        System.out.println("Product data: " + produto);

        System.out.println();
        System.out.print("Entre com a quantidade de numeros para ser adicionados em estoque: ");
        int quantity = sc.nextInt();
        produto.addProduct(quantity);

        System.out.println();
        System.out.println("Update data: " + produto);

        System.out.println();
        System.out.print("Entre com a quantidade de numeros para ser retirados em estoque: ");
        int saida = sc.nextInt();
        produto.removeProduct(saida);

        System.out.println();
        System.out.println("Update data: " + produto);







    }



}
