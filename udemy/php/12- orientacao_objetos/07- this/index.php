<?php



class Pessoa {
    public $nome;

    function seuNome($nome) {
       $this->nome = $nome;
    }
}


$henrique = new Pessoa;
$henrique->seuNome("Henrique");
echo "Seu nome é " . $henrique->nome;