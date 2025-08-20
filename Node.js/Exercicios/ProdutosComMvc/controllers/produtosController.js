const produtosRepository = require('../repository/produtosRepository');

// Classe de erro personalizada
class APIError extends Error {
    constructor(status, message) {
        super(message);
        this.status = status;
        this.name = 'APIError';
    }
}

// GET /produtos
const getProdutos = (req, res, next) => {
    try {
        const produtos = produtosRepository.pesquisarTodosProdutos();
        res.status(200).json(produtos);
    } catch (error) {
        next(error);
    }
}

// GET /produtos/:id
const getProdutosPorId = (req, res, next) => {
    try {
        const { id } = req.params;
        const produto = produtosRepository.pesquisarProdutosPorId(id);

        if (!produto) {
            return next(new APIError(404, "Produto não encontrado!"));
        }

        res.status(200).json(produto);
    } catch (error) {
        next(error);
    }
}

// POST /produtos
const criarProdutos = (req, res, next) => {
    try {
        const { nome, preco, descricao, estoque } = req.body;

        if (!nome || preco === undefined || !descricao || estoque === undefined) {
            return next(new APIError(400, "Todos os campos são obrigatórios."));
        }

        const novoProduto = produtosRepository.criarProduto(nome, preco, descricao, estoque);
        res.status(201).json(novoProduto);
    } catch (error) {
        next(error);
    }
}

// PUT /produtos/:id
const atualizarProdutoTodos = (req, res, next) => {
    try {
        const { id } = req.params;
        const { nome, preco, descricao, estoque } = req.body;

        if (!nome || preco === undefined || !descricao || estoque === undefined) {
            return next(new APIError(400, "Todos os campos são obrigatórios."));
        }

        const produtoAtualizado = produtosRepository.atualizarProdutoCompleto(id, nome, preco, descricao, estoque);

        if (!produtoAtualizado) {
            return next(new APIError(404, "Produto não encontrado."));
        }

        res.status(200).json(produtoAtualizado);
    } catch (error) {
        next(error);
    }
}

// PATCH /produtos/:id
const atualizarProdutoEstoque = (req, res, next) => {
    try {
        const { id } = req.params;
        const { estoque } = req.body;

        if (estoque === undefined) {
            return next(new APIError(400, "O campo estoque é obrigatório."));
        }

        const produtoAtualizado = produtosRepository.atualizarEstoque(id, estoque);

        if (!produtoAtualizado) {
            return next(new APIError(404, "Produto não encontrado."));
        }

        res.status(200).json(produtoAtualizado);
    } catch (error) {
        next(error);
    }
}

// DELETE /produtos/:id
const deletarProduto = (req, res, next) => {
    try {
        const { id } = req.params;

        const deletado = produtosRepository.deletarProduto(id);

        if (!deletado) {
            return next(new APIError(404, "Produto não encontrado."));
        }

        res.status(204).send();
    } catch (error) {
        next(error);
    }
}

module.exports = {
    getProdutos,
    getProdutosPorId,
    criarProdutos,
    atualizarProdutoTodos,
    atualizarProdutoEstoque,
    deletarProduto
}
