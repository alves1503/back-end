package entities;

public class Product {

    public String name;
    public double price;
    public int quantity;

    public double totalValueInStock(){
        return price * quantity;
    }


    public void addProduct(int quantity) {
        this.quantity += quantity;
    }


    public void removeProduct(int quantity) {
        this.quantity -= quantity;
    }

    public String toString() {
        return name + " , " + "Price: R$ " + String.format("%.2f", price) + " , " + "Quantity: " + quantity + " , " + "Valor total em estoque: R$ " + String.format("%.2f", totalValueInStock());
    }

}
