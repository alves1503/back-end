<?php


function sumDigits($number)
{

    $soma = 0;
    $numberString = (string)$number;


    for ($i = 0; $i < strlen($numberString); $i++) {

        $soma += (int) $numberString[$i];

    }

    return $soma;
}


echo sumDigits(2225);
