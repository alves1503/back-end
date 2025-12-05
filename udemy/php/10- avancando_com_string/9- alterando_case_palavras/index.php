<?php

$frase1 = "testando o case de uma palavra <br>";
$frase2 = "Testando o case de uma palavra <br>";
$frase3 = "testando o case de uma palavra <br>";

// Primeira letra em maiúsculo 
echo ucfirst($frase1);
echo ucfirst($frase2);

echo "<br>";

// Todas as palavras com a primeira letra em maiúsculo 
echo ucwords($frase3);
echo ucwords($frase2);