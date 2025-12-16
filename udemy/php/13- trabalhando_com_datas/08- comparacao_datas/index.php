<?php


$dataA = new DateTime();
$dataB = new DateTime();

$dataB->setDate(2022, 05, 15);

if ($dataA > $dataB) {
    echo "A data 'A' é maior que 'B'";
} else {
    echo "A data 'B' é maior que 'A'";
}