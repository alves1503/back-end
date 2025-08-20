const express = require('express');
const app = express();
const { v4: uuidv4 } = require('uuid');
const PORT = 3000;


//Saber mexer com dados
app.use(express.json());


//Meus dados
const produtos = [];


//Rota GET
app.get('/produtos', (req, res) => {
    res.status(200).json(produtos);
})

//Get ID
app.get('/produtos/:id', (req, res) => {
    const { id } = req.params;
    const produto = produtos.find(p => p.id === id);

    if (!produto) {
        return res.status(404).json({
            status: 404,
            message: "Usuario não encontrado!"
        });
    }
    res.status(200).json(produto);
});


//Metodo post
app.post('/produtos', (req, res) => {
    const { nome, preco, descricao, estoque } = req.body;

    if (!nome) {
        return res.status(400).json({
            status: 400,
            message: "O campo nome é obrigatorio!"
        });
    }

    if (!preco) {
        return res.status(400).json({
            status: 400,
            message: "O campo preco é obrigatorio!"
        });
    }

    if (!descricao) {
        return res.status(400).json({
            status: 400,
            message: "O campo descricao é obrigatorio!"
        });
    }

    if (!estoque) {
        return res.status(400).json({
            status: 400,
            message: "O campo estoque é obrigatorio!"
        });
    }

    const novoProduto = {
        id: uuidv4(),
        nome,
        preco,
        descricao,
        estoque
    }

    produtos.push(novoProduto);
    res.status(201).json(novoProduto);

});


//Metodo PUT
app.put('/produtos/:id', (req, res) => {
    const { id } = req.params;
    const { nome, preco, descricao, estoque } = req.body;
    const produto = produtos.find(p => p.id === id)

    if (!produto) {
        return res.status(404).json({
            message: "Ocorrencia não encontrada"
        });
    }

    if (!nome) {
        return res.status(400).json({
            status: 400,
            message: "O campo nome é obrigatorio!"
        });
    }

    if (preco =     == undefined) {
        return res.status(400).json({
            status: 400,
            message: "O campo preco é obrigatorio!"
        });
    }

    if (!descricao) {
        return res.status(400).json({
            status: 400,
            message: "O campo descricao é obrigatorio!"
        });
    }

    if (estoque === undefined) {
        return res.status(400).json({
            status: 400,
            message: "O campo estoque é obrigatorio!"
        });
    }

    produto.nome = nome;
    produto.preco = preco;
    produto.descricao = descricao;
    produto.estoque = estoque;

    res.status(200).json(produto);


});


//Metodo PATCH
app.patch('/produtos/:id', (req, res) => {
    const { id } = req.params;
    const { nome, preco, descricao, estoque } = req.body;
    const produto = produtos.find(p => p.id === id);

    if (!produto) {
        return res.status(404).json({
            message: "Ocorrencia não encontrada"
        });
    }

    if (!nome) {
        return res.status(400).json({
            status: 400,
            message: "O campo nome é obrigatorio!"
        });
    }

    if (preco === undefined) {
        return res.status(400).json({
            status: 400,
            message: "O campo preco é obrigatorio!"
        });
    }

    if (!descricao) {
        return res.status(400).json({
            status: 400,
            message: "O campo descricao é obrigatorio!"
        });
    }

    if (estoque === undefined) {
        return res.status(400).json({
            status: 400,
            message: "O campo estoque é obrigatorio!"
        });
    }

    if (nome !== undefined) {
        produto.nome = nome;
    }

    if (preco !== undefined) {
        produto.preco = preco;
    }

    if (descricao !== undefined) {
        produto.descricao = descricao;
    }

    if (estoque !== undefined) {
        produto.estoque = estoque;
    }

    res.status(200).json(produto);

});


//Metodo delete
app.delete('/produtos/:id', (req, res) => {
    const { id } = req.params;
    const index = produtos.findIndex(p => p.id === id);

    if (index === -1) {
        return res.status(404).json({
            status: 404,
            message: "Produtos não encontrados"
        });
    }

    produtos.splice(index, 1);
    res.status(204).send();

});





//Porta
app.listen(PORT, () => {
    console.log(`Servidor rodando na porta ${PORT}`);
});

