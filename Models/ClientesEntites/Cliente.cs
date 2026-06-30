using System.ComponentModel.DataAnnotations;

namespace EstoqueLojaV._0._2.Models.ClientesEntites
{
    public class Cliente //Classe padrão para o cadastro de clientes, com os campos basicos de identificação e contato.
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public string CpfCnpj { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public bool Ativo { get; set; } = true;
    }
}

