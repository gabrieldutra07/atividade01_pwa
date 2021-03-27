using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProjetoAtividade.Controllers
{
    public class InternoController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public InternoController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Entrar()
        {
            return View();
        }

        public IActionResult Ajuda()
        {
            return View();
        }

        public IActionResult Secao1()
        {
            return View();
        }
        public IActionResult Secao2()
        {
            return View();
        }
        public IActionResult Secao3()
        {
            return View();
        }
    }
}