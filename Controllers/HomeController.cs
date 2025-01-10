using Microsoft.AspNetCore.Mvc;

namespace FanClub.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Renderiza a tela inicial
        }
    }
}
