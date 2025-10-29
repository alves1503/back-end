package entities;

public class Estudante {

    public String nome;
    public double nota1;
    public double nota2;
    public double nota3;


    public double soma() {
        return nota1 + nota2 + nota3;
    }

    public double resultado() {
        if(soma() < 60) {
            return 60.0 - soma();
        }
        return 0;
    }



}
