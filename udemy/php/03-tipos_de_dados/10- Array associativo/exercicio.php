<?php


$car = ['marca' => 'Civic', 'ano' => 2025, 'cor' => 'Black', 'automatico' => false];


if ($car['automatico'] == true) {
    echo "Vish, devolve e pegue um manual";
    echo "<br>";
    echo "Ai não meu amigo, pegou logo um ";
    echo $car['marca'];
    echo " automatico";
} else {
echo "Ai sim Bro!<br>Ai sim meu amigo, pegou logo um " . $car['marca'] . " manual";
}
