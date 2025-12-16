<?php

// Data atual
$data = new DateTime();
echo $data -> format('d/m/y') . "<br>";
echo $data -> format('D - M - Y') . "<br>";


//Data mais 5 dias
$data->modify('+5 days');
echo $data -> format('d/m/y') . "<br>";
