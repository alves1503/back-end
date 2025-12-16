<?php


$dataA = new DateTime();
$dataB = new DateTime();

$dataB->setDate(2001, 10, 15);
print_r($dataA);
echo "<br>";
print_r($dataB);

$diferenca = $dataA->diff($dataB);
echo "<br>";
print_r($diferenca);