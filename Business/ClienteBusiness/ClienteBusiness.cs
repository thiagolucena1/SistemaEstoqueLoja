using AutoMapper;
using EstoqueLojaV._0._2.Interface.IBusinessInterfaces;
using EstoqueLojaV._0._2.Interface.IRepositoryData;
using EstoqueLojaV._0._2.Models.ClientesEntites;
using EstoqueLojaV._0._2.Models.DTO;

namespace EstoqueLojaV._0._2.Business.ClienteBusiness
{
    public class ClienteBusiness : IClienteBusiness
    {
        private readonly IClienteData _clienteData;
        private readonly IMapper _mapper;
        public ClienteBusiness(IClienteData clienteData, IMapper mapper)
        {
            _clienteData = clienteData;
            _mapper = mapper;
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

        public ClienteEditarDTO ClienteUnico(int id)
        {
            var retorno = _clienteData.ClienteUnico(id);
            return _mapper.Map<ClienteEditarDTO>(retorno);
        }

        public IList<Cliente> ListarClientes()
        {
            return _clienteData.ListarClientes();
        }

        public void AtualizarCliente(ClienteEditarDTO cliente)
        {
            var Cliente = _mapper.Map<Cliente>(cliente);

            _clienteData.AtualizarCliente(Cliente);
        }

        public bool ExcluirCliente(int id)
        {
            return _clienteData.ExcluirCliente(id);
            }
    }
}
