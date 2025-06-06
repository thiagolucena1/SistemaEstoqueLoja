using gerenciamentoEstoque.models;

Estoque estoque = new Estoque();

Produto p1 = new Produto(1, " Logitech G305 Lightspeed", "O G305 apresenta o sensor HERO de última geração com sensibilidade de 200 a 12.000 DPI para precisão de nível de competição.", 234.99M, 4);
Produto p2 = new Produto(2, "Carrinho", "teste de descriao ", 21M, 2);
estoque.AdicionarProdutoEstoque(p1);
estoque.AdicionarProdutoEstoque(p2);
