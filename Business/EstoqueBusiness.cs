using EstoqueLojaV._0._2.Interface.IBusinessInterfaces;
using EstoqueLojaV._0._2.Models;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace EstoqueLojaV._0._2.Business
{
    public class EstoqueBusiness : IEstoqueBusiness
    {
        private List<Produto> produtos;

        

        public void AdicionarProdutoEstoque(Produto produto) //Esta função ira adicionar o produto em estoque após a instância do OBJETO. 
        {

            if (produto is not null)
            {

                bool idExistente = produtos.Any(p => p.Id == produto.Id); // Futuramente, puxar diretamente no repositorio para validar o ID do produto. 

                if (idExistente) // Caso retorne TRUE, ou seja caso tenha ID repetido, o codigo retornara com um erro. 
                {

                    Console.WriteLine($"Não é possivel cadastrar o produto {produto.Nome} visto que o ID do mesmo ja se encontra registrado para outro produto.");

                    return;
                }

                else
                {
                    bool produtoIsValido = ValidarProduto(produto);

                    if (produtoIsValido)
                    {
                        string caminhoId = "IdsProducts/IDprodutos.json";
                        produtos.Add(produto);
                        Console.WriteLine("Produto adicionado com sucesso!");

                        string serial = JsonConvert.SerializeObject(produtos);

                        File.AppendAllText(caminhoId, serial); // Correção de codigo realizada, com o Append, o codigo sempre ira escrever após a ultima linha no arquivo JSON.

                    }
               


                }
            }
        }


        public void ListaProdutosEstoque()
        {
            foreach (var produto in produtos)      // Toda vez que o usuário desejar verificar as informações dos produtos em estoque, deve chamar esta função.
            {
                Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");
            }
        }

        public void RemoverProduto() 
        {
            Console.WriteLine("Deseja remover o produto ? ");
            Console.WriteLine("SIM - NÃO ");
            string opcao = Console.ReadLine();

            if (opcao.Equals("Sim", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Digite a senha do ADM");   //Esta senha é apenas para validar o acesso do ADM, atualmente esta definida como 123.
                int senha = int.Parse(Console.ReadLine());

                if (senha == 123)
                {
                    Console.WriteLine("Digite o ID do produto para a remoção do mesmo.");
                    int idCodigo = int.Parse(Console.ReadLine());
                    Produto produtoParaRemover = null;

                    foreach (var produtoo in produtos)
                    {
                        if (produtoo.Id == idCodigo)
                        {
                            produtoParaRemover = produtoo;
                            break;
                        }
                    }

                    if (produtoParaRemover is not null)
                    {
                        produtos.Remove(produtoParaRemover);
                        Console.WriteLine("Produto removido com sucesso. ");



                    }
                    else
                    {
                        Console.WriteLine("ID do produto não foi localizado! ");
                    }

                }
            }


        }


        public void AtualizarDadosDosProdutos() //Esta linha ira autualizar os dados de um produto já cadastrado. 
        {

            Console.WriteLine("Informe o numero do ID para a alteração dos demais dados.");
            int idEscolhido = int.Parse(Console.ReadLine());

            foreach (var produto in produtos)
            {
                if (produto.Id == idEscolhido)
                {
                    Console.WriteLine($"Escreve o novo nome do produto do ID ( {idEscolhido} )");
                    string novoNome = Console.ReadLine();
                    produto.Nome = novoNome;

                    Console.WriteLine($"Escreva a nova descrição do produto ({novoNome})");
                    string novaDscr = Console.ReadLine();
                    produto.Descricao = novaDscr;

                    Console.WriteLine($"Escreva o novo preço do produto ({novoNome})");
                    decimal novoPreco = decimal.Parse(Console.ReadLine());
                    produto.Preco = novoPreco;



                }
                else
                {
                    Console.WriteLine($"Id {idEscolhido}, não localizado. ");

                }


            }
        }

        public bool ValidarProduto(Produto produto)
        {
            bool isValid = true;
            
            if (produto is not null)
            {
                if (produto.Descricao.Length > 2000)
                {
                    return false;
                }


                return isValid;
            
            }
            
            else
            {
                isValid = false;
                return isValid;
            }

        }
    }
}

