<?php


$usuario = [

    'nome' => 'Henrique Alves',
    'idade' => 20,
    'profissao' => 'Desenvolvedor'

];


    if($usuario) {
        $nome = $usuario['nome'];
        $idade = $usuario['idade'];
        $profissao = $usuario['profissao'];
    }

?>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>


<form>

<div>
    <input type="text" name="nome" placeholder="Digite seu nome" value="<?= $nome ?>">
</div>

<div>
    <input type="text" name="idade" placeholder="Digite sua idade" value="<?= $idade ?>">
</div>

<div>
    <input type="text" name="profissão" placeholder="Digite sua profissão" value="<?= $profissao ?>">
</div>

</form>  


</body>
</html>