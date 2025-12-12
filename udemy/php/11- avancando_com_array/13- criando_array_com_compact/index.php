<?php



$nome = "Henrique";
$idade = 20;
$profissao = "Estudante";

$pessoa = compact("nome", "idade", "profissao");
print_r($pessoa);