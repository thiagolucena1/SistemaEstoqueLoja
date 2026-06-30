using EstoqueLojaV._0._2.Business;
using EstoqueLojaV._0._2.Interface.IBusinessInterfaces;
using EstoqueLojaV._0._2.Models;
using EstoqueLojaV._0._2.Models.ClientesEntites;
using EstoqueLojaV._0._2.Models.DTO;
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


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var cliente = _clienteBusiness.ClienteUnico(id);

            return PartialView("~/Views/Shared/Modais/_ModalEditarCliente.cshtml", cliente);
        }


        [HttpPost]

        public IActionResult Edit(ClienteEditarDTO clienteDto)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));

            }
            _clienteBusiness.AtualizarCliente(clienteDto);
            return RedirectToAction(nameof(Index));

        }
    }
}
