/* 
Crie um servidor Node.js com Express que gerencia um cadastro de usuários, com as seguintes rotas:

✨ Requisitos:
GET /usuarios → Lista todos os usuários.

POST /usuarios → Adiciona um novo usuário com nome e email.

GET /usuarios/:id → Mostra os dados de um usuário específico pelo ID.

DELETE /usuarios/:id → Remove um usuário pelo ID.

✅ Regras:

Armazene os usuários em um array de objetos, igual ao exemplo.

Use id numérico e autoincrementado.

O servidor deve rodar em http://localhost:3000. */


const express = require('express');
const app = express();
const PORT = 3000;


app.use(express.json()); //Importação express


let usuario = [

    { id: 0, nome: "Henrique Alves Gonçalves", email: "seuemail@gmail.com" },
    { id: 1, nome: "João Pedro", email: "seuemail@gmail.com" },
    { id: 2, nome: "Maria Clara", email: "seuemail@gmail.com" }


]

//Rota para pesquisa
app.get('/usuario', (req, res) => {
    res.status(200).json(usuario);
});

//Rota para pesquisa id
app.get('/usuario/:id', (req, res) => {
    const id = parseInt(req.params.id);
    const userId = usuario.find(u => u.id === id);

    if (!userId) {
        return res.status(404).json({
            status: 404,
            message: "Usuario não encontrado!"
        });
    }

    res.status(200).json(userId)
});


//Rota para postagem
app.post('/usuario', (req, res) => {
    const { nome, email } = req.body;

    if (!nome) {
        return res.status(400).json({
            status: 400,
            message: "Campo nome é obrigatorio!"
        });
    }

    if (!email) {
        return res.status(400).json({
            status: 400,
            message: "Campo email é obrigatorio"
        });
    }

    const novoUsuario = {
        id: usuario.length + 1,
        nome,
        email
    }

    usuario.push(novoUsuario);
    res.status(201).json(novoUsuario)
});

//Rotapara deletar
app.delete('/usuario/:id', (req, res) => {
    const id = parseInt(req.params.id);
    const index = usuario.findIndex(u => u.id === id);

    if (index === -1) {
        return res.status(404).json({
            message: "Usuario não encontrado!"
        });
    }

    usuario.splice(index, 1);
    res.status(204).send();

});





app.listen(PORT, () => {
    console.log(`Servidor rodando na porta ${PORT}`);
});