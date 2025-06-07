using gerenciamentoEstoque.models;

while (true) {
Estoque estoque = new Estoque();

        Console.WriteLine("Seja Bem vindo ao sistema de estoque.");
        Console.WriteLine("1 - Adicionar um produto no estoque");

        Console.WriteLine("2 - Remover um produto do estoque");

        Console.WriteLine("3 - Listar produtos registrados ");

        Console.WriteLine("4 - Atualizar dados de um produto em especifico");

        Console.WriteLine("5 - SAIR ");


        int option = int.Parse(Console.ReadLine());


switch (option)
{
    case 1:

        Console.WriteLine("Escreva o nome do produto: ");
        string nomeProduto = Console.ReadLine();

        Console.WriteLine("Escreva a descrição do produto: ");
        string descricaoProduto = Console.ReadLine();

        Console.WriteLine("Escreva o preço do produto: ");
        decimal precoProduto = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Escreva a quantidade disponíveis em estoque");
        int quantidadeProduto = int.Parse(Console.ReadLine());

        int novoID = estoque.ContarProdutos() + 1;

        Produto novoProduto = new Produto(novoID, nomeProduto, descricaoProduto, precoProduto, quantidadeProduto);
        estoque.AdicionarProdutoEstoque(novoProduto);
        break;

    case 2:

        estoque.RemoverProduto();

        break;
    case 3:

        estoque.ListaProdutosEstoque();

        break;

    case 4:

        estoque.AtualizarDadosDosProdutos();

        break;

    case 5:
        Console.WriteLine("Saindo...");
        return;

    default:

        Console.WriteLine("Opção inválida!");
        break;
    

        }
        }
        


    


