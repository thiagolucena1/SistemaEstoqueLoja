using EstoqueLojaV._0._2.Interface.IBusinessInterfaces;
using EstoqueLojaV._0._2.Interface.IRepositoryData;
using EstoqueLojaV._0._2.Models.ClientesEntites;

namespace EstoqueLojaV._0._2.Business.ClienteBusiness
{
    public class ClienteBusiness : IClienteBusiness
    {
        private readonly IClienteData _clienteData;
        public ClienteBusiness(IClienteData clienteData)
        {
            _clienteData = clienteData;
        }

        public bool CadastrarCliente(Cliente entidade)
        {
            try
            {
                _clienteData.AdicionarCliente(entidade);

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public IList<Cliente> ListarClientes()
        {
            return _clienteData.ListarClientes();
        }
    }
}
