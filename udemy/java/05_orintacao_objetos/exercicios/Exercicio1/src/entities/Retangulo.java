package entities;

public class Retangulo {

    public double largura;
    public double altura;


    // Metodo area do retangulo
    public double area(){
        return largura * altura;
    }

    // Metodo perimetro do retangulo
    public double perimetro() {
        return (largura + altura) * 2;
    }

//Metodo de diagonal do retangulo
    public double diagonal() {
        return Math.sqrt(Math.pow(largura,2) + Math.pow(altura,2));
    }


    //Exibir resultado
    public String toString() {
        return "Area = "+ String.format("%.2f", area()) + "\n" +
                "Perimetro = " + String.format("%.2f", perimetro()) + "\n" +
                "Diagonal = " + String.format("%.2f", diagonal());

    }


}
