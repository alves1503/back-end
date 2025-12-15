<?php


class Cachorro {

    private $nome;
    private $raca;
    private $idade;

    function __construct($nome, $raca, $idade)
    {
        $this->nome = $nome;
        $this->raca = $raca;
        $this->idade = $idade;
    }

    public function exibirCachorro() {
        echo "Seu chachorro $this->nome é da raça $this->raca e tem $this->idade anos!";
    }


}

$bob = new Cachorro("BOB", "Vira Lata", 12);
$bob->exibirCachorro();