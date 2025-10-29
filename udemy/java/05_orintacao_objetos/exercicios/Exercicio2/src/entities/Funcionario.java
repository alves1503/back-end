package entities;

public class Funcionario {


    public String nome;
    public double salario;
    public double imposto;



    public double retirarTaxa() {
        return salario -=  imposto;
    }

    public void adicionarTaxa(double taxa) {
        this.salario =+ (taxa / 100 * salario) + salario;
    }

    public String toString() {
        return nome + ", $ " + String.format("%.2f",salario);
    }



}
