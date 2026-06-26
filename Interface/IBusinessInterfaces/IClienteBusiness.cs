using EstoqueLojaV._0._2.Models.ClientesEntites;

namespace EstoqueLojaV._0._2.Interface.IBusinessInterfaces
{
    public interface IClienteBusiness
    {

        bool CadastrarCliente(Cliente entidade);

        IList<Cliente> ListarClientes();



    }
}