<?php




function alteraDados($nome, $idade) {


    $nome = "Sr. $nome";
    $idade = "$idade anos";


    return [$nome, $idade];



}


$dados = alteraDados("Henrique", 20);
print_r($dados);

echo "<br>";

echo "Ola $dados[0], você tem $dados[1]";