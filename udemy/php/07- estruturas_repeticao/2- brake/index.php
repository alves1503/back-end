<?php





$cont = 0;


while ($cont < 10) {
    echo $cont;
    echo "<br>";

    if ($cont === 5) {
        echo "Teminando o loop";
        break;
    }

    $cont++;
}