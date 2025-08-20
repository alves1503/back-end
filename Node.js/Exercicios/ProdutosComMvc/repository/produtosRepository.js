const { v4: uuidv4 } = require('uuid');

const produtos = [];

// Criar novo produto
const criarProduto = (nome, preco, descricao, estoque) => {
    const novoProduto = {
        id: uuidv4(),
        nome,
        preco,
        descricao,
        estoque
    };

    produtos.push(novoProduto);
    return novoProduto;
}

// Buscar todos os produtos
const pesquisarTodosProdutos = () => {
    return produtos;
}

// Buscar produto por ID
const pesquisarProdutosPorId = (id) => {
    return produtos.find(p => p.id === id);
}

// Atualizar produto completamente (PUT)
const atualizarProdutoCompleto = (id, nome, preco, descricao, estoque) => {
    const produto = produtos.find(p => p.id === id);

    if (!produto) return null;

    produto.nome = nome;
    produto.preco = preco;
    produto.descricao = descricao;
    produto.estoque = estoque;

    return produto;
}

// Atualizar apenas o estoque (PATCH)
const atualizarProdutoEstoque = (id, novoEstoque) => {
    const produto = produtos.find(p => p.id === id);

    if (!produto) return null;
    if (typeof novoEstoque !== 'number' || novoEstoque < 0) return false;

    produto.estoque = novoEstoque;
    return produto;
}

// Deletar produto
const deletarProduto = (id) => {
    const index = produtos.findIndex(p => p.id === id);

    if (index === -1) return false;

    produtos.splice(index, 1);
    return true;
}

module.exports = {
    criarProduto,
    pesquisarTodosProdutos,
    pesquisarProdutosPorId,
    atualizarProdutoCompleto,
    atualizarProdutoEstoque,
    deletarProduto
};
