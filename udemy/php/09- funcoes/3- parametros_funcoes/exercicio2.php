<?php


function numeroParOuImpar($x) {
    if ($x % 2 == 0) {
        echo "O número $x é par <br>";
    } else {
        echo "O número $x é impar <br>";
    }
}


numeroParOuImpar(2);
numeroParOuImpar(3);