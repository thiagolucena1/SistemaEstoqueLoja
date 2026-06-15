using EstoqueLojaV._0._2.Models;

namespace EstoqueLojaV._0._2.Interface.IBusinessInterfaces
{
    public interface IEstoqueBusiness
    {
        public void AdicionarProdutoEstoque(Produto produto);

        public void RemoverProduto();
        public IList<Produto> ListarProdutosEstoque();
        public void AtualizarDadosDosProdutos();

        public bool ValidarProduto(Produto produto);
    }
}
