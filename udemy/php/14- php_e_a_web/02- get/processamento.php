<?php


$nome = $_GET['nome'];
$idade = $_GET['idade'];

?>

<?php if ($nome == "" || $idade == ""): ?>
    <h1>O campo nome e idade deve ser prenchido</h1>
<?php else: ?>
    <h1>O seu nome é <?= $nome ?> e você tem <?= $idade?> anos</h1>
<?php endif ?>