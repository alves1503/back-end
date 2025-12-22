<?php


$host = "localhost";
$db = "conexoes";
$user = "alves";
$pass = "1503";


$conn = new PDO("mysql:host=$host;dbname=$db", $user, $pass);

$id = 1;

$stmt = $conn->prepare("SELECT * FROM pessoas WHERE id > :id");
$stmt->bindParam(":id", $id);
$stmt->execute();

//$result = $stmt->fetch(PDO::FETCH_ASSOC);
//print_r($result);

$itens = $stmt->fetchAll(PDO::FETCH_ASSOC);
print_r($itens);