<?php

$host = "localhost";
$user = "alves";
$pass = "1503";
$db = "conexoes";


$conn = new mysqli($host, $user, $pass, $db);


$sql = "SELECT * FROM pessoas";

$result = $conn->query($sql);

print_r($result);

$conn->close(); // Fecha conexão




?>