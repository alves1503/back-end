<?php



$meuArray = ["Henrique", 20, true, 10,2, "Ana", 50, false, "Pedro", "Matheus", 50,5];

$count = 0;

echo "Tamanho do Array: " . sizeof($meuArray);
echo "<br>";


while($count <= sizeof($meuArray)) {

    if(is_string($meuArray[$count])) {
        echo "Sua String: " . $meuArray[$count];
        echo "<br>";
    }

    $count++;


}