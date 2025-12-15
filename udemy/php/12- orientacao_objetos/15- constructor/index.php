<?php


class Pessoa {
    public $nome;
    public $idade;
    public $profissao;


    function __construct($nome, $idade, $profissao)
    {
        $this->nome = $nome;
        $this->idade = $idade;
        $this->profissao = $profissao;

    }

}

$henrique = new Pessoa("Henrique", 20, "Estudante");
echo "Seja bem vindo $henrique->nome, sua idade é de $henrique->idade anos e você atua como $henrique->profissao";