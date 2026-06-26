using System.ComponentModel;

namespace EstoqueLojaV._0._2.Models.EnumTypes
{
    public enum AcaoAuditoriaLogEnum
    {
        
        Criar = 1,
        Atualizar = 2,
        Deletar = 3,
        Consultar = 4,

        [Description("Login")]
        Login = 5,
    }
}
