<?php
include_once("templates/header.php")
?>

<div class="container">
    <?php include_once("templates/backbtn.html") ?>
    <h1 id="main-title">Criar contato</h1>

    <form id="create-form" action="<?= $BASE_URL ?>config/process.php" method="post">
        <input type="hidden" name="type" value="create">
        <div class="form-group">
            <label for="name">Nome do contato:</label>
            <input type="text" class="form-control" name="name" id="name" placeholder="Ex: Henrique Alves" required>
        </div>
        <div class="form-group">
            <label for="phone">Telefone do contato:</label>
            <input type="text" class="form-control" name="phone" id="phone" placeholder="Ex: (99) 99999-9999" required>
        </div>
            <div class="form-group">
            <label for="observations">Observação do contato:</label>
            <textarea name="observations" id="observations" class="form-control" placeholder="Insira as observações" rows="3"></textarea>
        </div>
        <button type="submit" class="btn btn-primary">Cadastrar</button>

    </form>
</div>

<?php
include_once("templates/footer.php")
?>