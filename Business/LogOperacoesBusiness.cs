using EstoqueLojaV._0._2.Data;
using EstoqueLojaV._0._2.Interface.ILogOperacoesBusiness;
using EstoqueLojaV._0._2.Models.Log;

namespace EstoqueLojaV._0._2.Business
{
    public class LogOperacoesBusiness : ILogOperacoesBusiness
    {
        private readonly LogOperacoesData _logOperacoesData;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LogOperacoesBusiness(IHttpContextAccessor httpContextAccessor, LogOperacoesData log)
        {
            _httpContextAccessor = httpContextAccessor;
            _logOperacoesData = log;

        }

     

        public void RegistrarLog(string acao, string entidade, int entidadeId, string? usuario, string? usuarioRole)
        {
            var log = new LogAuditoria
            {
                Acao = acao,
                Entidade = entidade,
                EntidadeId = entidadeId,
                Horario = DateTime.UtcNow,
                IpUsuario = ObterIpUsuario(),
                Usuario = usuario,
                UsuarioRole = usuarioRole
            };

            _logOperacoesData.SalvarLog(log);
            
        }

        public string ObterIpUsuario()
        {
            // Agora usamos o _httpContextAccessor para chegar no HttpContext com segurança
            var context = _httpContextAccessor.HttpContext;

            if (context == null) return "127.0.0.1";

            string ip = context.Request.Headers["X-Forwarded-For"].FirstOrDefault();

            if (string.IsNullOrEmpty(ip))
            {
                ip = context.Connection.RemoteIpAddress?.ToString();
            }

            return ip;
        }
    }
}
