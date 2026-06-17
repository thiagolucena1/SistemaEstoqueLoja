using EstoqueLojaV._0._2.Models.AcountModel;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueLojaV._0._2.Controllers
{
    public class AccountController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login(LoginModel login)
        {
            // Lógica de autenticação (exemplo simples)
            if (login.Username == "1" && login.Senha == "1")
            {
                // Autenticação bem-sucedida, redirecionar para a página principal
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Autenticação falhou, exibir mensagem de erro
                ViewBag.ErrorMessage = "Credenciais inválidas. Tente novamente.";
                return View();
            }
        }
    }
}
