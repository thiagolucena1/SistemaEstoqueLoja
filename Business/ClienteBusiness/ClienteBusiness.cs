using AutoMapper;
using EstoqueLojaV._0._2.Interface.IBusinessInterfaces;
using EstoqueLojaV._0._2.Interface.ILogOperacoesBusiness;
using EstoqueLojaV._0._2.Interface.IRepositoryData;
using EstoqueLojaV._0._2.Models.ClientesEntites;
using EstoqueLojaV._0._2.Models.DTO;
using EstoqueLojaV._0._2.Models.EnumTypes;

namespace EstoqueLojaV._0._2.Business.ClienteBusiness
{
    public class ClienteBusiness : IClienteBusiness
    {
        private readonly IClienteData _clienteData;
        private readonly IMapper _mapper;
        private readonly ILogOperacoesBusiness _logger;
        public ClienteBusiness(IClienteData clienteData, IMapper mapper, ILogOperacoesBusiness log)
        {
            _logger = log;
            _clienteData = clienteData;
            _mapper = mapper;
        }

        public bool CadastrarCliente(Cliente entidade)
        {
            try
            {
                var id = _clienteData.AdicionarCliente(entidade);
                _logger.RegistrarLog(AcaoAuditoriaLogEnum.Criar.ToString(), TabelasEnum.Clientes.ToString(), id, null, null);

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
            try
            {
                var Cliente = _mapper.Map<Cliente>(cliente);

                _clienteData.AtualizarCliente(Cliente);
                _logger.RegistrarLog(AcaoAuditoriaLogEnum.Atualizar.ToString(), TabelasEnum.Clientes.ToString(), Cliente.Id, null, null);
            } catch (Exception ex)
            {
                _logger.RegistrarLog(AcaoAuditoriaLogEnum.Falha.ToString(), TabelasEnum.Clientes.ToString(), 0, null, null);

            } }

        public bool ExcluirCliente(int id)
        {
            try
            {

                var retorno = _clienteData.ExcluirCliente(id);
                _logger.RegistrarLog(AcaoAuditoriaLogEnum.Deletar.ToString(), TabelasEnum.Clientes.ToString(), retorno, null, null);

                return true;

            }
            catch (Exception ex)
            {

                _logger.RegistrarLog(AcaoAuditoriaLogEnum.Falha.ToString(), TabelasEnum.Clientes.ToString(), 0, null, null);
                return false;

            }
        }
    }
}
