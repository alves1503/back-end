<?php


$tipo = "Cachorro";
$nome = "BOB";
$idade = 10;
$raca = "Pastor Alemão";

$animal = compact("tipo", "nome", "idade", "raca");
print_r($animal);

echo "<br>";


echo "Seu animal: <br>";


foreach ($animal as $caracteristicas => $value) {
    echo "$caracteristicas: $value <br>";
}