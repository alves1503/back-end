<?php




$str = "carro, navio, helicóptero, barco, jangada";

$strParaArray = explode(",", $str);

print_r($strParaArray);


// Todo: Imprimir na tela

for ($i = 0; $i < count($strParaArray); $i++) {
    echo "Dados Array posição #" . $i . ": " . $strParaArray[$i] . "<br>";
}