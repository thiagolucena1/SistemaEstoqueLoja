using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gerenciamentoEstoque.models;

namespace gerenciamentoEstoque.models
{
    public class Estoque
    {

        private List<Produto> produtos;

        public Estoque()
        {
            produtos = new List<Produto>();  // Criação da classe ESTOQUE do da lista do tipo Produtos da classe Produtos.cs
        }

        public void AdicionarProdutoEstoque(Produto produto) //Esta função ira adicionar o produto em estoque após a instância do OBJETO. 
        {
            
                bool idExistente = produtos.Any(p => p.Id == produto.Id); // Esta expressão serve para verificar se o produto a ser adicionado contém id repetido. 

            if (idExistente) // Caso retorne TRUE, ou seja caso tenha ID repetido, o codigo retornara com um erro. 
            {

                Console.WriteLine($"Não é possivel cadastrar o produto ${produto.Nome} visto que o ID do mesmo ja se encontra registrado para outro produto.");

                return;
            }

            else
            {
                produtos.Add(produto);
                Console.WriteLine("Produto adicionado com sucesso!");
            }
                
            }
        

        public void ListaProdutosEstoque()
        {
            foreach (var produto in produtos)      // Toda vez que o usuário desejar verificar as informações dos produtos em estoque, deve chamar esta função.
            {
                Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");
            }
        }

        public void RemoverProduto( )  // Basicamente remove o produto. 
        {
            Console.WriteLine("Deseja remover o produto ? ");
            Console.WriteLine("SIM - NÃO ");
            string opcao = Console.ReadLine();

            if (opcao.Equals ("Sim", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Digite a senha do ADM");   //Esta senha é apenas para validar o acesso do ADM, atualmente esta definida como 123.
                int senha = int.Parse(Console.ReadLine());

                if (senha == 123)
                {
                    Console.WriteLine("Digite o ID do produto para a remoção do mesmo.");
                    int iden = int.Parse(Console.ReadLine());
                    Produto produtoParaRemover = null;

                    foreach (var produtoo in produtos)
                    {
                        if (produtoo.Id == iden)
                        {
                            produtoParaRemover = produtoo;
                            break;
                        }
                    }
 
                    if (produtoParaRemover != null)
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
            
        }
    }
