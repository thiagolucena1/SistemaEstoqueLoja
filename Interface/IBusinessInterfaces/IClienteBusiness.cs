using EstoqueLojaV._0._2.Models.ClientesEntites;
using EstoqueLojaV._0._2.Models.DTO;

namespace EstoqueLojaV._0._2.Interface.IBusinessInterfaces
{
    public interface IClienteBusiness
    {

        bool CadastrarCliente(Cliente entidade);

        IList<Cliente> ListarClientes();

        ClienteEditarDTO ClienteUnico(int id);

        void AtualizarCliente(ClienteEditarDTO cliente);

        bool ExcluirCliente(int id);



    }
}