const express = require('express');
const erroHandler = require('./utils/erroHandler');
const produtosRoutes = require('./routes/produtosRoutes');

const app = express();

app.use(express.json());
app.use('/produtos', produtosRoutes);
app.use(erroHandler);

app.listen(3000, () => {
     console.log(`Servidor rodando em http://localhost:3000`);
});