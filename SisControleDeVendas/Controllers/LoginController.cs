using Microsoft.AspNetCore.Mvc;

namespace SisControleDeVendas.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
