using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace lab4.Controllers
{
    public class ImanController : Controller
    {
        public IActionResult Index()

        {


            return View();
        }
        public string i()
        {
            return "ImanaRAMA";
        }
    }
}
