<?php


$arr = [

    'Henrique' => 200,
    'João' => 300,
    'Maria' => 10

];

arsort($arr)
?>


<h1>Ranking</h1>
<hr>
<ol>
    <?php foreach ($arr as $nome => $value): ?>

        <li><?= $nome .  " => " . $value . " pontos" ?></li>


    <?php endforeach; ?>
    </ol\>