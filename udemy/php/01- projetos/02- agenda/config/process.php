<?php


session_start();
include_once("conection.php");
include_once("url.php");

$data = $_POST;

// MODIFICAÇÕES DO BANCO DE DADOS
if (!empty($data)) {


    // Criar contato
    if ($data["type"] === "create") {
        $name = $data["name"];
        $phone = $data["phone"];
        $observations = $data["observations"];

        $query = "INSERT INTO contacts (name, phone, observations) VALUES (:name, :phone, :observations)";

        $smtm = $conn->prepare($query);
        $smtm->bindParam(":name", $name);
        $smtm->bindParam(":phone", $phone);
        $smtm->bindParam(":observations", $observations);


        try {
            $smtm->execute();
            $_SESSION["msg"] = "Contato criado com sucesso!";
        } catch (PDOException $e) {
            //Erro de conexão
            $error = $e->getMessage();
            echo "Erro: $error";
        }
    } else if ($data["type"] === "edit") {
        $name = $data["name"];
        $phone = $data["phone"];
        $observations = $data["observations"];
        $id = $data["id"];

        $query = "UPDATE contacts 
                  SET name = :name, phone = :phone, observations = :observations 
                  WHERE id = :id";
        $smtm = $conn->prepare($query);

        $smtm->bindParam(":name", $name);
        $smtm->bindParam(":phone", $phone);
        $smtm->bindParam(":observations", $observations);
        $smtm->bindParam(":id", $id);

        try {
            $smtm->execute();
            $_SESSION["msg"] = "Contato editado com sucesso!";
        } catch (PDOException $e) {
            //Erro de conexão
            $error = $e->getMessage();
            echo "Erro: $error";
        }
    } else if ($data["type"] === "delete") {
        $id = $data["id"];

        $query = 'DELETE FROM contacts WHERE id = :id';
        $smtm = $conn->prepare($query);
        $smtm->bindParam(":id", $id);

        try {
            $smtm->execute();
            $_SESSION["msg"] = "Contato removido com sucesso!";
        } catch (PDOException $e) {
            //Erro de conexão
            $error = $e->getMessage();
            echo "Erro: $error";
        }
    }

    // REDIRECT HOME
    header("Location:" . $BASE_URL . "../index.php");

    // SELEÇÃO DE DADOS
} else {
    $id;
    if (!empty($_GET)) {
        $id = $_GET['id'];
    }

    //RETORNA APENAS UM CONTATO
    if (!empty($id)) {

        $query = "SELECT * FROM contacts WHERE id = :id";
        $smtm = $conn->prepare($query);
        $smtm->bindParam(":id", $id);
        $smtm->execute();

        $contact = $smtm->fetch();
    } else {
        //RETORNA TODOS OS CONTATOS
        $contacts = [];
        $query = "SELECT * FROM contacts";

        $smtm = $conn->prepare($query);
        $smtm->execute();

        $contacts = $smtm->fetchAll();
    }
}

// FECHAR CONEXÃO
$conn = null;
