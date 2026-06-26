using EstoqueLojaV._0._2.Models.ClientesEntites;

namespace EstoqueLojaV._0._2.Interface.IRepositoryData
{
    public interface IClienteData
    {
        void AdicionarCliente(Cliente cliente);
        IList<Cliente> ListarClientes();

    }
}