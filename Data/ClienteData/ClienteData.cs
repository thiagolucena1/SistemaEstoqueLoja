using EstoqueLojaV._0._2.Interface.IRepositoryData;
using EstoqueLojaV._0._2.Models;
using EstoqueLojaV._0._2.Models.ClientesEntites;
using EstoqueLojaV._0._2.Models.DTO;
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

       

        public int AdicionarCliente(Cliente cliente)
        {
            if (cliente is not null)
            {
                try
                {
                    _context.Clientes.Add(cliente);
                    _context.SaveChanges();

                    return cliente.Id;
                    }

                catch (SqlTypeException ex)
                {
                    ex.ToString();
                }

                
            }
            return 0;
        }

        public IList<Cliente> ListarClientes()
        {
            IList<Cliente> clientes = _context.Clientes.ToList();
            return clientes;
        }

        public Cliente ClienteUnico(int id)
        {
            return _context.Clientes.FirstOrDefault(c => c.Id == id);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            try { 

            if (cliente is not null)
            {

                _context.Clientes.Update(cliente);
                _context.SaveChanges();
                
            }
            }
            catch (SqlTypeException ex)
            {
                throw ex;
                
            }

            

        }

        public int ExcluirCliente(int id)
        {


            Cliente RegistroExcluir = new Cliente { Id = id };

            try
            {
                
                _context.Clientes.Remove(RegistroExcluir);
                _context.SaveChanges();

                return RegistroExcluir.Id;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
