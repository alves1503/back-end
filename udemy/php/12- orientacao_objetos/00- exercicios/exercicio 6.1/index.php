<?php


class Pessoa {
    //Propriedade
    public $nome;
    public $idade;


    //Metodo
    function andar($m) {
        echo "O " . $this->nome . " andou " . $m . " mts";
    }
}

$henrique = new Pessoa;
$henrique->nome = "Henrique";
$henrique->idade = 20;
echo "A instancia do objeto tem nome de: " . $henrique->nome . " e idade de: ". $henrique->idade . " anos";
echo "<br>";
echo "<br>";
echo "Metodo: ";
echo "<br>";
$henrique->andar(500);