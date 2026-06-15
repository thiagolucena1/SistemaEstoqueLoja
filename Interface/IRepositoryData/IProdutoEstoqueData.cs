using EstoqueLojaV._0._2.Models;

namespace EstoqueLojaV._0._2.Interface.IRepositoryData
{
    public interface IProdutoEstoqueData
    {
        public void AdicionarProduto(Produto produto);

        public IList<Produto> ListarProdutos();
    }
}
