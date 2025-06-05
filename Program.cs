using gerenciamentoEstoque.models;

Estoque estoque = new Estoque();

Produto p1 = new Produto(1, " Logitech G305 Lightspeed", "O G305 apresenta o sensor HERO de última geração com sensibilidade de 200 a 12.000 DPI para precisão de nível de competição.", 234.99M, 4);
Produto p2 = new Produto(2, "Mouse generico", "teste de descrição", 23M, 1);
Produto p3 = new Produto(3, "telcado ", "teste ", 2M, 3);


estoque.AdicionarProdutoEstoque(p1);
estoque.AdicionarProdutoEstoque(p2);
estoque.AdicionarProdutoEstoque(p3);


Produto p4 = new Produto(4, "Cavalo branco", "descricao",  2M, 2);

estoque.AdicionarProdutoEstoque(p4);

estoque.ListaProdutosEstoque();

