<?php


$x = 0;



while ($x < 6) {
    $y = 1;
    echo "Loop externo $x <br>";
    $x++;

    while ($y < 4) {
        echo "Loop interno $y <br>";
        $y++;
    }
}
