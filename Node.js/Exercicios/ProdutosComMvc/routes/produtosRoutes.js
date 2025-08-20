const express = require('express');
const produtosController = require('../controllers/produtosController');

const router = express.Router();

router.get('/', produtosController.getProdutos);
router.get('/:id', produtosController.getProdutosPorId);
router.post('/', produtosController.criarProdutos);
router.put('/:id', produtosController.atualizarProdutoTodos);
router.patch('/:id', produtosController.atualizarProdutoEstoque);
router.delete('/:id', produtosController.deletarProduto);

module.exports = router;