using EstoqueLojaV._0._2.Business;
using EstoqueLojaV._0._2.Interface.IBusinessInterfaces;
using EstoqueLojaV._0._2.Models;
using EstoqueLojaV._0._2.Models.ClientesEntites;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueLojaV._0._2.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteBusiness _clienteBusiness;

        public ClienteController(IClienteBusiness clienteBusiness)
        {
            _clienteBusiness = clienteBusiness;
        }

        public IActionResult Index()
        {
            var model = _clienteBusiness.ListarClientes();
            return View(model);
        }

        public IActionResult CriarClientesModal(Cliente cliente)
        {

            _clienteBusiness.CadastrarCliente(cliente);

            return RedirectToAction(nameof(Index));
        }


    }
}
