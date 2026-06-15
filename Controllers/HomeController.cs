using EstoqueLojaV._0._2.Interface.IBusinessInterfaces;
using EstoqueLojaV._0._2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EstoqueLojaV._0._2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEstoqueBusiness _estoqueBusiness;

        public HomeController(IEstoqueBusiness estoqueBusiness)
        {
            _estoqueBusiness = estoqueBusiness;
        }
        public IActionResult Index()
        {
            var produtos = _estoqueBusiness.ListarProdutosEstoque();

            return View(produtos);
        }

        public  IActionResult CriarProdutosModal(Produto produto)
        {

            _estoqueBusiness.AdicionarProdutoEstoque(produto);

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
