<?php


$host = "localhost";
$db = "conexoes";
$user = "alves";
$pass = "1503";


$conn = new PDO("mysql:host=$host;dbname=$db", $user, $pass);

$stmt = $conn->prepare("INSERT INTO pessoas (nome, idade) VALUES (:nome, :idade)");

$nome = "Jose Rodrigues da Silva";
$idade = 20;

$stmt->bindParam(":nome", $nome);
$stmt->bindParam(":idade", $idade);

$stmt->execute();