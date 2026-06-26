using EstoqueLojaV._0._2.Interface.ILogOperacoesBusiness;
using EstoqueLojaV._0._2.Models.AcountModel;
using EstoqueLojaV._0._2.Models.EnumTypes;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueLojaV._0._2.Controllers
{
    public class AccountController : Controller
    {
        #region Metodos e contrutores
        private readonly ILogOperacoesBusiness _logOperacoesBusiness;
        public AccountController(ILogOperacoesBusiness log)
        {
            _logOperacoesBusiness = log;
        }

        #endregion


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
                _logOperacoesBusiness.RegistrarLog(AcaoAuditoriaLogEnum.Login.ToString(), "Login bem-sucedido", 0, null, null);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Autenticação falhou, exibir mensagem de erro
                ViewBag.ErrorMessage = "Credenciais inválidas. Tente novamente.";
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ImportarClientes(IFormFile arquivo)
        {
            // trata clientes
            return RedirectToAction(nameof(Index));
        }
    }
}
