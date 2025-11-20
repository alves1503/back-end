<?php



$x = 0;

while ($x < 10) {
    echo "$x <br>";

    if ($x === 5) {
        echo "Chegou ao continue e pulou o 5";
        echo "<br>";
        $x++;
        continue;
    }



    $x++;
}