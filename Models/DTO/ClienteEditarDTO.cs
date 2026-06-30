namespace EstoqueLojaV._0._2.Models.DTO
{
    public class ClienteEditarDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CpfOuCnpj { get; set; }
        public string Email { get; set; }

        public string Telefone { get; set; }

        public ClienteEditarDTO()
        {
            Nome = string.Empty;
            CpfOuCnpj = string.Empty;
            Email = string.Empty;
            Telefone = string.Empty;
        }

        public ClienteEditarDTO(int id, string nome, string cpfOuCnpj, string email, string telefone)
        {
            Id = id;
            Nome = nome;
            CpfOuCnpj = cpfOuCnpj;
            Email = email;
            Telefone = telefone;
        }
    }
}