<?php


$pessoa = new class() {

    public $nome = "Henrique <br>";
    
    public function dizerNome() {
        echo "Olá, meu nome é $this->nome <br>";
    }


};

echo $pessoa->nome;
$pessoa->dizerNome();