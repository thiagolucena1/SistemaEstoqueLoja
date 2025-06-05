using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gerenciamentoEstoque.models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        



        public Produto(int id, string nome, string descricao, decimal preco, int quantidade )
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Quantidade = quantidade;
            
        }
        
    }
}