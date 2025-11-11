package entities;

public class Funcionario {

    private int id;
    private String name;
    private double salario;


    public Funcionario(int id, String name, double salario) {
        this.id = id;
        this.name = name;
        this.salario = salario;
    }


    public int getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    public double getSalario() {
        return salario;
    }

    public void setSalario(double salario) {
        this.salario = salario;
    }
}
