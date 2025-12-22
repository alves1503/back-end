<?php


$host = "localhost";
$user = "alves";
$pass = "1503";
$db = "conexoes";

$conn = new mysqli($host, $user, $pass, $db);

$id = 1;
$stmt =  $conn->prepare("SELECT * FROM pessoas WHERE id = ?");

$stmt->bind_param("i", $id);

$stmt->execute();

$result = $stmt->get_result();

$item = $result->fetch_row();


print_r($item);

$conn->close();
