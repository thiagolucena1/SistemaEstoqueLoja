namespace EstoqueLojaV._0._2.Interface.ILogOperacoesBusiness
{
    public interface ILogOperacoesBusiness
    {
        void RegistrarLog(string acao, string entidade, int entidadeId, string usuario, string usuarioRole);
    }
}
