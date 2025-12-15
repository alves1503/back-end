<?php



class Pessoa
{
    public $nome = "Herique";
    public $idade = 20;

    function saudacao()
    {
        echo "Ola, meu nome é $this->nome e tenho $this->idade anos <br>";
    }
}

class Programador extends Pessoa
{
    function desenvolvedor()
    {
        echo "Ola, meu nome é $this->nome e tenho $this->idade anos e sou desenvolvedor <br>";
    }
}


$henrique = new Pessoa;
$henrique->saudacao();
$henriqueDev = new Programador();
$henriqueDev->saudacao();
$henriqueDev->desenvolvedor();
