<?php

$host = "localhost";
$user = "alves";
$pass = "1503";
$db = "conexoes";


$nome = "Ana Luiza";
$idade = 25;

$conn = new mysqli($host, $user, $pass, $db);

$stmt = $conn->prepare("INSERT INTO pessoas (nome, idade) VALUES (?, ?)");

$stmt->bind_param("si", $nome, $idade);

$stmt->execute();
