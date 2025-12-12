
<?php

$pessoas = [
'Henrique' => 20,
'Maria' => 10,
'Ana' => 30,
'Marcos' => 25

];

?>

<table border="1px solid black">
    <tr>
        <th>Nome</th>
        <th>Idade</th>
    </tr>
    <?php foreach($pessoas as $nome => $idade): ?>
            <tr>
                <td><?= $nome ?></td>
                <td><?= $idade ?></td>
            </tr>

        <?php endforeach; ?>
</table>