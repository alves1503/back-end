<?php



$cont = 4;


while ($cont < 30) {

    echo $cont . "<br>";

    if ($cont === 24) {
        echo "Fim do Programa!";
        break;
    }



    $cont += 2;
}