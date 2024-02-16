using Microsoft.AspNetCore.Mvc;

namespace Libery.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
