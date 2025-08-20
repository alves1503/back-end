🚀 Novo Desafio Node.js (Intermediário)
🎯 Objetivo: Criar uma API REST para gerenciar produtos de uma loja
📦 Funcionalidades da API
Verbo HTTP	Rota	Descrição
GET	/produtos	Listar todos os produtos
GET	/produtos/:id	Buscar um produto pelo ID
POST	/produtos	Criar um novo produto
PUT	/produtos/:id	Atualizar todos os dados de um produto
PATCH	/produtos/:id	Atualizar parcialmente os dados do produto
DELETE	/produtos/:id	Excluir um produto

🧾 Estrutura esperada do produto
json


{
  "id": "uuid",            // será gerado automaticamente
  "nome": "Mouse Gamer",
  "preco": 199.90,
  "descricao": "Mouse RGB com 6 botões",
  "estoque": 25
}