namespace EstoqueLojaV._0._2.Models.Log
{
    public class LogAuditoria
    {
        public int Id { get; set; }
        public string Acao { get; set; }
        public string Entidade { get; set; }
        public int EntidadeId { get; set; }
        public DateTime Horario { get; set; }
        public string IpUsuario { get; set; }
        public string Usuario { get; set; }
        public string UsuarioRole { get; set; } // <-- Propriedade Futura para armazenar o cargo do usuário por token, caso seja necessário para auditoria mais detalhada.

    }
}
