using EstoqueLojaV._0._2.Models.ClientesEntites;
using EstoqueLojaV._0._2.Models.DTO;

namespace EstoqueLojaV._0._2.Interface.IRepositoryData
{
    public interface IClienteData
    {
        int AdicionarCliente(Cliente cliente);
        IList<Cliente> ListarClientes();

        Cliente ClienteUnico(int id);

        void AtualizarCliente(Cliente cliente);

        int ExcluirCliente(int id);
    }
}