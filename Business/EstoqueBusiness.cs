using EstoqueLojaV._0._2.Interface.IBusinessInterfaces;
using EstoqueLojaV._0._2.Interface.ILogOperacoesBusiness;
using EstoqueLojaV._0._2.Interface.IRepositoryData;
using EstoqueLojaV._0._2.Models;
using System.Text.Json.Serialization;
using System.Xml;

namespace EstoqueLojaV._0._2.Business
{
    public class EstoqueBusiness : IEstoqueBusiness
    {
        #region Contrutores e variaveis

        private readonly IProdutoEstoqueData _produtoRepositoryData;
        private readonly ILogOperacoesBusiness _logOperacoesBusiness;

        public EstoqueBusiness(IProdutoEstoqueData ProdutoRepositorioData, ILogOperacoesBusiness log) { 
        
            _produtoRepositoryData = ProdutoRepositorioData;
            _logOperacoesBusiness = log;
        }

        #endregion



        public void AdicionarProdutoEstoque(Produto produto) //Esta função ira adicionar o produto em estoque após a instância do OBJETO. 
        {

            if (produto is not null)
            {

                var idExistente = false; // Futuramente, puxar diretamente no repositorio para validar o ID do produto. 

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
                        try
                        {
                            _logOperacoesBusiness.RegistrarLog("RegistrarProduto", produto.Nome, produto.Id, null, null);
                            _produtoRepositoryData.AdicionarProduto(produto);
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine($"Ocorreu um erro ao tentar adicionar o produto {produto.Nome} no estoque. Detalhes do erro: {ex.Message}");
                            return;
                        }
                        // Correção de codigo realizada, com o Append, o codigo sempre ira escrever após a ultima linha no arquivo JSON.

                        // File.AppendAllText(caminhoId, serial); // Correção de codigo realizada, com o Append, o codigo sempre ira escrever após a ultima linha no arquivo JSON.

                    }
               


                }
            }
        }


       
        public IList<Produto> ListarProdutosEstoque()
        {
            return _produtoRepositoryData.ListarProdutos();
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

        public void ListaProdutosEstoque()
        {
            throw new NotImplementedException();
        }

      
        void IEstoqueBusiness.RemoverProduto()
        {
            throw new NotImplementedException();
        }

        

        void IEstoqueBusiness.AtualizarDadosDosProdutos()
        {
            throw new NotImplementedException();
        }

        bool IEstoqueBusiness.ValidarProduto(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}

