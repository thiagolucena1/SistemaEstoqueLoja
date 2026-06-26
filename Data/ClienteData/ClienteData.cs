using EstoqueLojaV._0._2.Interface.IRepositoryData;
using EstoqueLojaV._0._2.Models;
using EstoqueLojaV._0._2.Models.ClientesEntites;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;

namespace EstoqueLojaV._0._2.Data.ClienteData
{
    public class ClienteData : IClienteData
    {
        private readonly ApplicationDbContext _context;

        public ClienteData(ApplicationDbContext context)
        {
            _context = context;
        }

       

        public void AdicionarCliente(Cliente cliente)
        {
            if (cliente is not null)
            {
                try
                {
                    _context.Clientes.Add(cliente);
                    _context.SaveChanges();
                    }

                catch (SqlTypeException ex)
                {
                    ex.ToString();
                }
            }

        }

        public IList<Cliente> ListarClientes()
        {
            IList<Cliente> clientes = _context.Clientes.ToList();
            return clientes;
        }
    }
}
