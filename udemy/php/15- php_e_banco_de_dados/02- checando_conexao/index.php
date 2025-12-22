<?php

$host = "localhost";
$user = "alves";
$pass = "1503";
$db = "conexoses";


$conn = new mysqli($host, $user, $pass, $db);


if($conn->connect_errno) {
    echo "Erro na conexão! <br>";
    echo "Erro: " . mysqli_connect_error();
    echo "<br>";
    echo "Erro: " . $conn->connect_error;
} 




?>