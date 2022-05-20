using Microsoft.AspNetCore.Mvc;

namespace lab5mvc.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
