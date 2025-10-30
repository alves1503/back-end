package entities;

import java.util.SplittableRandom;

public class Conta {

    private int numero;
    private String nome;
    private double saldo;


    public Conta() {

    }

    // Cosntrutor se quiser deositar no inicio
    public Conta(int numero, String nome, double deposito) {
        this.numero = numero;
        this.nome = nome;
        this.saldo = deposito;
    }

    // Construtor se não quiser depositar
    public Conta(int numero, String nome) {
        this.numero = numero;
        this.nome = nome;
    }


    // Numero da conta não pode ser alterado
    public int getNumero() {
        return numero;
    }

    // Encapsulamento nome
    public String getNome() {
        return nome;
    }

    // TODO: pode ser implementado
    public void setNome(String nome) {
        this.nome = nome;
    }

    // Encapsulamento saldo
    public double getSaldo() {
        return saldo;
    }


    // Metodo para deposito:
    public double deposito(double deposito) {
        return this.saldo += deposito;
    }

    // Metodo para saque:
    public double saque(double saque) {
        return this.saldo = saldo - saque - 5;
    }



    // Metodo "toString" para exibir informações
    public String toString() {
        return "Conta: " + numero + ", " + "Nome: " + nome + ", " + "Saldo: $ " + String.format("%.2f", saldo);
    }
}
