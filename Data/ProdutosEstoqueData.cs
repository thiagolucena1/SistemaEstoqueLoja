using EstoqueLojaV._0._2.Interface.IRepositoryData;
using EstoqueLojaV._0._2.Models;
using System.Data.SqlTypes;

namespace EstoqueLojaV._0._2.Data
{
    public class ProdutosEstoqueData : IProdutoEstoqueData
    {

        private Produto[] produtos =
                    {
            new Produto
            {
                Id = 1,
                Nome = "Mouse Gamer",
                Descricao = "Mouse RGB com 6 botões programáveis",
                Preco = 129.90m,
                Quantidade = 15
            },

            new Produto
            {
                Id = 2,
                Nome = "Teclado Mecânico",
                Descricao = "Teclado mecânico switch blue",
                Preco = 249.90m,
                Quantidade = 8
            },

            new Produto
            {
                Id = 3,
                Nome = "Monitor 24",
                Descricao = "Monitor Full HD 75Hz",
                Preco = 799.90m,
                Quantidade = 5
            },

            new Produto
            {
                Id = 4,
                Nome = "Headset",
                Descricao = "Headset com microfone removível",
                Preco = 199.90m,
                Quantidade = 12
            }
};
        public void AdicionarProduto(Produto produto)
        { 
            if(produto is not null)
            {
                try
                {
                    produtos = produtos.Append(produto).ToArray(); ; //Simular Registro do produto no estoque, futuramente, puxar diretamente do repositorio para validar o ID do produto.
                }

                catch (SqlTypeException ex)
                {
                    ex.ToString();
                }
            }
        
        }

        public IList<Produto> ListarProdutos()
        {
            return produtos;
        }
    }
}
